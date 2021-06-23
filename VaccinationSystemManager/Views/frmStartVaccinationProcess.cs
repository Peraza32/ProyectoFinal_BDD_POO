using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccinationSystemManager.Views
{
    public partial class frmStartVaccinationProcess : Form
    {
        private Model.Citizen vaccinationCitizen = new Model.Citizen();
        private Model.Appointment vaccinationAppointment = new Model.Appointment();
        private Model.DoseType vaccinationDose = new Model.DoseType();

        public frmStartVaccinationProcess(Model.Citizen citizen, Model.Appointment appointment)
        {
            InitializeComponent();

            //Initialize data
            vaccinationCitizen = citizen;
            vaccinationAppointment = appointment;

            //Assign data to txt
            txtStartVaccinationDUI.Text = vaccinationCitizen.Dui;
            txtStartVaccinationName.Text = vaccinationCitizen.CitizenName;
            txtStartVaccinationAddress.Text = vaccinationCitizen.CitizenAddress;
            txtStartVaccinationPhone.Text = vaccinationCitizen.PhoneNumber;
            txtStartVaccinationMail.Text = vaccinationCitizen.EMail;
            txtStartVaccinationIdentifier.Text = vaccinationCitizen.IdentifierNumber;

            //Select Dose type from db
            var db = new Model.G4ProyectoDBContext();
            
            vaccinationDose = db.DoseTypes
                .Where(u => u.Id == vaccinationAppointment.ShotType)
                .FirstOrDefault();

            txtStartVaccinationDose.Text = vaccinationDose.ShotType;
            
            dtpStartVaccinationDate.Value = DateTime.Now;
            dtpStartVaccinationStart.Value = DateTime.Now;
            dtpStartVaccinationVaccine.Value = DateTime.Now;
            dtpStartVaccinationEnd.Value = DateTime.Now;
        }

        private void btnVerifyCitizenSearch_Click(object sender, EventArgs e)
        {
            var minutesFromStartToVaccine = ((dtpStartVaccinationStart.Value - dtpStartVaccinationVaccine.Value).Minutes);

            //Verify timer
            if (dtpStartVaccinationStart.Value <= dtpStartVaccinationVaccine.Value)
            {
                if ((dtpStartVaccinationVaccine.Value < dtpStartVaccinationEnd.Value) && ((((dtpStartVaccinationVaccine.Value - dtpStartVaccinationEnd.Value).Minutes >= -30)) || (((dtpStartVaccinationVaccine.Value - dtpStartVaccinationEnd.Value).Hours >= 0))))
                {
                    DateTime vaccineDay = dtpStartVaccinationDate.Value;
                    TimeSpan vaccineStart = dtpStartVaccinationStart.Value.TimeOfDay;
                    TimeSpan vaccineShot = dtpStartVaccinationVaccine.Value.TimeOfDay;
                    TimeSpan vaccineEnd = dtpStartVaccinationEnd.Value.TimeOfDay;

                    Model.VaccinationProcess vaccinationProcess = new Model.VaccinationProcess()
                    {
                        VaccinationDate = vaccineDay,
                        StartTime = vaccineStart,
                        VaccinationTime = vaccineShot,
                        EndTime = vaccineEnd,
                        ShotType = vaccinationDose.Id,
                        DuiCitizen = vaccinationCitizen.Dui
                    };

                    var db = new Model.G4ProyectoDBContext();

                    db.VaccinationProcesses.Add(vaccinationProcess);
                    db.SaveChanges();

                    //Check Side Effects
                    DialogResult result = MessageBox.Show("¿El paciente presentó efectos secundarios?",
                        "Vacunación COVID-19",
                        MessageBoxButtons.YesNo);
                    
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Proceso de vacunación registrado correctamente",
                            "Vacunación COVID-19",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Check if it's necesary to schedule a new appointment for dose 2
                        if (vaccinationProcess.ShotType == 1)
                        {
                            MessageBox.Show("Agendando cita para la segunda dosis",
                            "Vacunación COVID-19",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ASIGNAMOS UNA FECHA Y HORA DE VACUNACIÓN PARA LA SEGUNDA DOSIS

                            // variable que nos permite controlar el bucle
                            bool next = true;
                            // acumuladores que nos permiten asignar una fecha y hora de vacunación
                            int days = 0;
                            int hours = 8;
                            DateTime appointmentDate;
                            Model.Appointment newAppointment = new Model.Appointment();
                            int idVaccinationCenter = vaccinationAppointment.IdCenter;

                            // buscamos el centro de vacunación en la base de datos usando
                            // el número aleatorio generado como id del centro de vacunación
                            Model.VaccinationCenter vaccinationCenterBDD = db.Set<Model.VaccinationCenter>()
                                .SingleOrDefault(vc => vc.Id == idVaccinationCenter);

                            // tomamos como fecha base la fecha del día de la cita
                            DateTime baseDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, .000);

                            // le añadimos 42 días (el equivalente a 6 semanas)
                            baseDate = baseDate.AddDays(42).AddHours(0).AddMinutes(0).AddSeconds(0).AddMilliseconds(.000);

                            while (next)
                            {
                                // a la fecha base le vamos sumando 1 hora o 1 día según se vaya agotando la disponibilidad
                                // de cupos en el centro de vacunación asignado
                                appointmentDate = baseDate.AddDays(days).AddHours(hours).AddMinutes(0).AddSeconds(0).AddMilliseconds(.000);

                                // recuperamos una lista de las reservas realizadas en la hora y centro de vacunación
                                // generado para el ciudadano
                                var totalAppointments = db.Appointments
                                    .Where(ap => ap.AppointmentDate == appointmentDate && ap.IdCenter == idVaccinationCenter)
                                    .ToList();

                                // comparamos que existan cupos disponibles
                                if ((vaccinationCenterBDD.Capacity - totalAppointments.Count) > 0)
                                {
                                    // saves the new appointment in the database
                                    newAppointment.AppointmentDate = appointmentDate;
                                    newAppointment.ShotType = 2;
                                    newAppointment.IdCenter = idVaccinationCenter;
                                    newAppointment.DuiCitizen = vaccinationAppointment.DuiCitizen;
                                    newAppointment.IdEmployee = 1; // cambiar por el id real del empleado cuando se implemente con el login

                                    db.Appointments.Add(newAppointment);
                                    db.SaveChanges();

                                    MessageBox.Show($"Cita agendada con éxito!", "Vacunación COVID-19", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                    // gets out of the loop
                                    next = false;
                                }
                                else
                                {
                                    // si no hay cupos, sumamos horas a la fecha generada
                                    if (hours < 17)
                                        hours++;
                                    else // si ya no hay cupos para antes de las 5 de la tarde, sumamos 1 día
                                    {
                                        hours = 8;
                                        days++;
                                    }
                                }
                            }

                            //Devolver al form de "Ver Detalle de citas"
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                            //Devolver al Dashboard
                        }
                    }
                    else
                    {
                        //Create an Side Effect form
                        frmSideEffects VaccineSideEffect = new frmSideEffects(vaccinationAppointment, vaccinationProcess);
                        VaccineSideEffect.Show();
                        
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Como mínimo, debieron pasar 30 minutos entre de la hora de vacunación y la hora de finalización",
                            "Vacunación COVID-19",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("La hora de vacunación no puede ser antes de la hora de inicio",
                        "Vacunación COVID-19",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerifyCitizenCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //Devolver al Dashboard
        }
    }
}
