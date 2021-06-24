using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Controller;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VaccinationSystemManager.Controller
{
    class DuiHandler : TextboxHandler
    {

        public DuiHandler(ValidationHandler next, TextBox text) : base(next, text)
        {

        }

        public override bool Validate()
        {
            //checks for empty textboxes on any validator
            if (fieldToHandle.Text == string.Empty)
            {
                throw new FormInputException("El campo se encuentra vacío", fieldToHandle);
            }
            //Validates if its a correct DUI (nine digits)
            if (Regex.IsMatch(fieldToHandle.Text, "^\\d{9}"))
            {
                return base.Validate();
            }
            else
            {
                throw new FormInputException("El DUI ingresado no tiene el formato correcto", fieldToHandle);
            }
        }
    }
}
