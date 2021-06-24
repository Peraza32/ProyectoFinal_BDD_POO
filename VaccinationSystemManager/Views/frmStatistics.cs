using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace VaccinationSystemManager.Views
{
    public partial class frmStatistics : Form
    {
        txtCabin dashboard;

        public frmStatistics(txtCabin dash)
        {
            InitializeComponent();

            dashboard = dash;
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            //Pie chart for Tab1 == "Personas vacunadas en total, solo con una dosis y con ambas dosis"
            CreateStaticPieTab1();

            //Pie chart for Tab2 == "Efectos secundarios presentados"
            CreateStaticPieTab2();

            //Rectangle Bar Serie for Tab3 == "Eficiencia del proceso de vacunación"
            CreateStaticPieTab3();
        }

        //Functions to create Charts
        public void CreateStaticPieTab1()
        {
            var modelP1 = new PlotModel { Title = "Personas vacunadas en total" };

            dynamic seriesP1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            seriesP1.Slices.Add(new PieSlice("Primera dosis", Controller.Statistics.CountVaccinationProcess(1)) { IsExploded = true, Fill = OxyColor.FromRgb(243, 156, 18) });
            seriesP1.Slices.Add(new PieSlice("Segunda dosis", Controller.Statistics.CountVaccinationProcess(2)) { IsExploded = true, Fill = OxyColor.FromRgb(39, 174, 96) });

            modelP1.Series.Add(seriesP1);
            plotView1.Model = modelP1;
        }

        public void CreateStaticPieTab2()
        {
            var modelP2 = new PlotModel { Title = "Efectos secundarios presentados" };

            dynamic seriesP2 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            foreach (Model.SideEffect data in Controller.Statistics.RetrieveSideEffectName())
            {
                seriesP2.Slices.Add(new PieSlice(data.Effect, Controller.Statistics.CountPresentedSideEffect(data.Id)) { IsExploded = true });
            }

            modelP2.Series.Add(seriesP2);
            plotView2.Model = modelP2;
        }

        public void CreateStaticPieTab3()
        {
            var modelP3 = new PlotModel { Title = "Eficiencia del proceso de vacunación" };

            var barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>(new[]
                {
                    new BarItem{ Value = Controller.Statistics.CountEfficiency(1) },
                    new BarItem{ Value = Controller.Statistics.CountEfficiency(2) },
                    new BarItem{ Value = Controller.Statistics.CountEfficiency(3) },
                }),

                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0} Pacientes"
            };

            modelP3.Series.Add(barSeries);

            modelP3.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CakeAxis",
                ItemsSource = new[]
                {
                    "Entre 30 minutos y 45 minutos",
                    "Entre 45 minutos y una Hora",
                    "Un Hora en adelante"
                }
            });

            plotView3.Model = modelP3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Returns to Dashboard
            dashboard.Show();
            this.Close();
        }
    }
}
