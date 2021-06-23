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
    public partial class frmSideEffects : Form
    {
        private Model.VaccinationProcess vaccinationProcess = new Model.VaccinationProcess();
        private Model.VaccinationProcess ProcessDBdata = new Model.VaccinationProcess();
        private Model.PresentedSideEffect vaccinationSideEffect = new Model.PresentedSideEffect();
        private Model.Appointment anAppointment = new Model.Appointment();
        public frmSideEffects(Model.Appointment appointment, Model.VaccinationProcess process)
        {
            InitializeComponent();

            anAppointment = appointment;
            vaccinationProcess = process;
        }

        private void frmSideEffects_Load(object sender, EventArgs e)
        {
            var db = new Model.G4ProyectoDBContext();

            cmbSideEffectsList.DataSource = db.SideEffects.ToList();
            cmbSideEffectsList.ValueMember = "id";
            cmbSideEffectsList.DisplayMember = "effect";
        }

        private void btnSideEffectsSave_Click(object sender, EventArgs e)
        {
            var db = new Model.G4ProyectoDBContext();

            ProcessDBdata = db.VaccinationProcesses
                .Where(u => u.DuiCitizen == vaccinationProcess.DuiCitizen)
                .Where(u => u.ShotType == vaccinationProcess.ShotType)
                .FirstOrDefault();

            // saves the side effect in database
            vaccinationSideEffect.AppearanceTime = Convert.ToInt32(nudAppearanceTime.Value);
            vaccinationSideEffect.IdVaccinationProcess = ProcessDBdata.Id;
            vaccinationSideEffect.IdSideEffect = (cmbSideEffectsList.SelectedIndex + 1);

            db.PresentedSideEffects.Add(vaccinationSideEffect);
            db.SaveChanges();
        }

        private void btnSideEffectsCancel_Click(object sender, EventArgs e)
        {
            var db = new Model.G4ProyectoDBContext();

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
                int idVaccinationCenter = anAppointment.IdCenter;

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
                        newAppointment.DuiCitizen = anAppointment.DuiCitizen;
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

            MessageBox.Show("Proceso de vacunación registrado correctamente",
               "Vacunación COVID-19",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
