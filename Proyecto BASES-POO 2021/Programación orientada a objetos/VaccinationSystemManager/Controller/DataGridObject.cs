using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationSystemManager.Controller
{
    //Struct used to populate the DatagridView
    public class DataGridObject
    {
        public string Dui { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public string Dose { get; set; }

        
        
    }
}
