using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccinationSystemManager.Controller
{
    abstract class TextboxHandler : ValidationHandler
    {
        protected TextBox fieldToHandle;

        public TextboxHandler(ValidationHandler? next, TextBox handlingTextbox) : base(next)
        {
            fieldToHandle = handlingTextbox;
        }

    }
}
