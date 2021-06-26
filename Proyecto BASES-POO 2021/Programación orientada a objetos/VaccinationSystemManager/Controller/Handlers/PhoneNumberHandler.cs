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
    class PhoneNumberHandler : TextboxHandler
    {
        public PhoneNumberHandler(ValidationHandler next, TextBox text) : base(next, text)
        {

        }

        public override bool Validate()
        {
            //checks for empty textboxes on any validator
            if (fieldToHandle.Text == string.Empty)
            {
                throw new FormInputException("El campo se encuentra vacío", fieldToHandle);
            }
            if (Regex.IsMatch(fieldToHandle.Text, "^\\d{8}"))
            {
                return base.Validate();
            }
            else
            {
                throw new FormInputException("El número de teléfono tiene un formato incorrecto", fieldToHandle);
            }
        }
    }
}
