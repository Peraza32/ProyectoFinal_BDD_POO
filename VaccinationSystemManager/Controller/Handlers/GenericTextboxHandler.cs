using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationSystemManager.Controller;

namespace VaccinationSystemManager.Controller
{
    //generic handler to use with non specific and simple tasks in textboxes 
    //like querying the db
    class GenericTextboxHandler : TextboxHandler
    {
        //delegate used as a callback
        Func<bool> callback;
        private string errorMessage;
        public GenericTextboxHandler(ValidationHandler? next, TextBox target, Func<bool> validation, string onErrorMessage) : base(next, target)
        {
            callback = validation;
            errorMessage = onErrorMessage;
        }

        public override bool Validate()
        {
            //if the callback return true the validation is correct and then it follows the chain
            if (callback())
            {
                return base.Validate();
            }
            else
            {
                throw new FormInputException(errorMessage, fieldToHandle);
            }
        }
    }
}
