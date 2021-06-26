using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccinationSystemManager.Controller
{
    class BirthdateAdultHandler : ValidationHandler
    {
        DateTimePicker validationPicker;
        public BirthdateAdultHandler(ValidationHandler next, DateTimePicker picker) : base(next)
        {
            validationPicker = picker;
        }

        public override bool Validate()
        {
            int age = (DateTime.Now - validationPicker.Value).Days / 365;
            if(age >= 18)
            {
                return base.Validate();
            }
            else
            {
                throw new FormInputException("Las citas para personas menores de 18 años aún no han sido habilitadas", validationPicker);
            }
        }
    }
}
