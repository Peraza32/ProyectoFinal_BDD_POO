using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationSystemManager.Controller
{
    public abstract class ValidationHandler : IValidator
    {
        private ValidationHandler? next = null;
        public ValidationHandler(ValidationHandler? next)
        {
            SetNext(next);
        }
        public virtual bool Validate()
        {
            //if its the last handler on the chain just returns true
            if(next is null)
            {
                return true;
            }
            //otherwise it checks the validation in the next handler
            else
            {
                return next.Validate();
            }
        }
        public void SetNext(ValidationHandler next)
        {
            //if there is no next handler sets it to the argument received
            if(this.next is null)
            {
                this.next = next;
            }
            //if there is then it appends to the chain
            else
            {
                next.SetNext(next);
            }
        }
    }
}
