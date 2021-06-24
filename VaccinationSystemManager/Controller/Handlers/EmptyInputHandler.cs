using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Controller;
using System.Windows.Forms;

namespace VaccinationSystemManager.Controller
{
    class EmptyInputHandler : TextboxHandler
    {
        public EmptyInputHandler(ValidationHandler next, TextBox text) : base(next, text)
        {

        }

        public override bool Validate()
        {
            //checks for empty textboxes on any validator
            if (fieldToHandle.Text == string.Empty)
            {
                throw new FormInputException("El campo se encuentra vacío", fieldToHandle);
            }
            return base.Validate();
        }
    }
}
