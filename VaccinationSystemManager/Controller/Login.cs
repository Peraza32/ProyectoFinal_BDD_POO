using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccinationSystemManager.Controller
{
    //Class that logs in the program and makes a redirection to the dashboard and app
    class Login : ILogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public virtual bool SignIn()
        {
            //Constructs the dashboard with the logged employee
            return true;
        }

    }
}
