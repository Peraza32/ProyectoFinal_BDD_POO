using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationSystemManager.Controller
{
    interface IValidator
    {
        public bool Validate();
        public void SetNext(ValidationHandler next);
    }
}
