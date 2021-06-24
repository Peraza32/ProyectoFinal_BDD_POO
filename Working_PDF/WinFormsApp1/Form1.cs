using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();




            string message = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            string title = "Title";
            MessageBox.Show(message, title);



            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "/funciona.pdf", FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            String line = "Hello! Welcome to iTextPdf";
            document.Add(new Paragraph(line));
            document.Close();
            Console.WriteLine("Awesome PDF just got created.");
        }


    }
}
