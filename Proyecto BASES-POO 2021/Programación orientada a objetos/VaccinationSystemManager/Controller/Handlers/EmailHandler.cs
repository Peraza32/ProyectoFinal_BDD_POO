using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationSystemManager.Controller;
using System.Text.RegularExpressions;

namespace VaccinationSystemManager.Controller
{
    class EmailHandler : ValidationHandler
    {
        TextBox? handlingTextbox;
        public EmailHandler(ValidationHandler next, TextBox text) : base(next)
        {
            if(text.Text.Trim() != string.Empty)
            {
                handlingTextbox = text;
            }
            else
            {
                handlingTextbox = null;
            }
        }

        public override bool Validate()
        {
            //given that the email is optinal if its null then it continues with the validation chain
            //otherwise it checks that the format is correct
            if(handlingTextbox is null || Regex.IsMatch(handlingTextbox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return base.Validate();
            }
            else
            {
                throw new FormInputException("El correo electrónico no se encuentra en formato correcto", handlingTextbox);
            }
        }
    }
}
