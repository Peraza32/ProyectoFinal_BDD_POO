using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VaccinationSystemManager.Controller
{
    //user defined exception to handle bad form inputs
    public class FormInputException : Exception
    {
        public Control errorTarget;
        //Constructors for exception throwing
        //either having an specific message or not
        public FormInputException()
        { }
        public FormInputException(string message) : base(message)
        { }
        //constructor for returning a form control and handle it 
        //outside the exception class
        public FormInputException(string message, Control errorControl) : base(message)
        {
            this.errorTarget = errorControl;
        }
        //Constructor for nested exception throwing
        public FormInputException(string message, Exception innerException) : base(message,innerException)
        { }
    }
}
