using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using VaccinationSystemManager.Controller;
using System.Windows.Forms;

namespace VaccinationSystemManager.Controller
{
    class NameHandler : TextboxHandler
    {

        public NameHandler(ValidationHandler next, TextBox text) : base(next, text)
        {

        }

        public override bool Validate()
        {
            //checks for empty textboxes on any validator
            if (fieldToHandle.Text == string.Empty)
            {
                throw new FormInputException("El campo se encuentra vacío", fieldToHandle);
            }
            if (fieldToHandle.Text.All(c => char.IsDigit(c)))
            {
                throw new FormInputException("Error de formato en el nombre", fieldToHandle);
            }
            else
            {
                return base.Validate();
            }
        }
    }
}
