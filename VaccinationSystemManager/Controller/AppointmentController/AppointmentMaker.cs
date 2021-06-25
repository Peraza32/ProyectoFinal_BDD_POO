using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using VaccinationSystemManager.Model;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Geom;
using iText.Layout.Borders;

namespace VaccinationSystemManager.Controller.AppointmentController
{
    class AppointmentMaker : IAppointment, IPDFCreator
    {
        G4ProyectoDBContext database;

        public AppointmentMaker(G4ProyectoDBContext db)
        {
            database = db;
        }

        public Model.Appointment MakeAppointment(DoseType shotType, Citizen person, Employee manager, int idVaccinationCenter, DateTime date)
        {
            // searching with the random index in the database
            VaccinationCenter vaccinationCenterBDD = database.Set<VaccinationCenter>()
                .SingleOrDefault(vc => vc.Id == idVaccinationCenter);

            //creating the new appointment with the given data and a valid date
            Model.Appointment newAppointment = new Model.Appointment
            {
                AppointmentDate = date,
                ShotType = shotType.Id,
                IdCenter = idVaccinationCenter,
                DuiCitizen = person.Dui,
                IdEmployee = manager.Id
            };

            database.Appointments.Add(newAppointment);

            database.SaveChanges();

            MessageBox.Show($"Cita agendada con éxito!", "Vacunación COVID-19", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return newAppointment;
        }


        public DateTime GetAvailability(DateTime possibleDate, VaccinationCenter location)
        {
            //Bucle control
            bool next = true;


            while (next)
            {
                // getting all appointments in an specific center
                var totalAppointments = database.Appointments
                    .Where(ap => ap.AppointmentDate == possibleDate && ap.IdCenter == location.Id)
                    .ToList();

                // checking if the capacity is not exceeded
                if ((location.Capacity - totalAppointments.Count) > 0)
                {
                    //if there is enough room for another apointment just exists the loop
                    next = false;
                }
                else
                {
                    //otherwise it keeps adding hours until 17:00
                    if (possibleDate.Hour < 17)
                        possibleDate.AddHours(1);
                    else // when it reaches the end of the day adds another day and resets the date
                    {
                        possibleDate.AddDays(1);
                        possibleDate = possibleDate.Date.AddHours(8);
                    }
                }
            }


            return possibleDate;
        }

        public void SavePDF(Citizen patient, Appointment appointment)
        {
            //Create the path and the file in order to write the pdf
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "/" + patient.CitizenName + "_" + appointment.DuiCitizen + ".pdf", FileMode.Create, FileAccess.Write)));
            using (Document document = new Document(pdfDocument, PageSize.A4))
            {
                //Setting margins 
                document.SetMargins(5, 5, 5, 5);
                //Setting font type
                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
                //List to Save all the paragraph
                List<Paragraph> paragraphs = new List<Paragraph>();

                //Creating the Title
                Paragraph header = new Paragraph("INFORMACION DE CITA")
                                                .SetTextAlignment(TextAlignment.CENTER)
                                                .SetFontSize(20);
                
                
                Paragraph user =  new Paragraph(patient.CitizenName)
                                      .SetTextAlignment(TextAlignment.CENTER)
                                      .SetFontSize(16);

                LineSeparator ls = new LineSeparator(new SolidLine());

                document.Add(header);
                document.Add(user);
                document.Add(ls);

                Table table = new Table(2);
                table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                table.AddCell(new Cell().SetTextAlignment(TextAlignment.JUSTIFIED)
                                        .Add(new Paragraph("Fecha de la cita"))
                                        .SetBorder(Border.NO_BORDER));

                table.AddCell(new Cell().SetTextAlignment(TextAlignment.JUSTIFIED)
                                        .Add(new Paragraph(appointment.AppointmentDate.ToString()))
                                        .SetBorder(Border.NO_BORDER));


                table.AddCell(new Cell().SetTextAlignment(TextAlignment.JUSTIFIED)
                                        .Add(new Paragraph("Centro de Vacunacion")
                                        .SetBorder(Border.NO_BORDER)));


                table.AddCell(new Cell().SetTextAlignment(TextAlignment.JUSTIFIED)
                                        .Add(new Paragraph(UserInformation.GetVaccinationCenter(appointment.IdCenter).CenterName)
                                        .SetBorder(Border.NO_BORDER)));

                table.AddCell(new Cell().SetTextAlignment(TextAlignment.JUSTIFIED)
                                        .Add(new Paragraph("Direccion del Centro de Vacunacion")
                                        .SetBorder(Border.NO_BORDER)));


                table.AddCell(new Cell().SetTextAlignment(TextAlignment.JUSTIFIED)
                                        .Add(new Paragraph(UserInformation.GetVaccinationCenter(appointment.IdCenter).CenterAddress)
                                        .SetBorder(Border.NO_BORDER)));


                table.AddCell(new Cell().SetTextAlignment(TextAlignment.JUSTIFIED)
                                        .Add(new Paragraph("Dosis")
                                        .SetBorder(Border.NO_BORDER)));

                table.AddCell(new Cell().SetTextAlignment(TextAlignment.JUSTIFIED)
                                        .Add(new Paragraph(UserInformation.GetDoseType(appointment.ShotType).ShotType)
                                        .SetBorder(Border.NO_BORDER)));
                document.Add(table);
                document.Close();


            }
            

        } 
    }
}
