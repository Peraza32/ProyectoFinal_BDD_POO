using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationSystemManager.Model;

namespace VaccinationSystemManager.Controller
{
    class LoginProxy: Login, ILogin
    {
        private Cabin loginPlace;
        private G4ProyectoDBContext database;
        private ValidationHandler loginHandler;
        Login loginManager;
        private void LogAccess()
        {
            //writes the info in the login register
            SessionControl newSession = new SessionControl{ 
                                                            SessionDate = System.DateTime.Now,
                                                            IdEmployee = database.Employees.Where(e => e.EmployeeUser == this.Username).Select(e => e.Id).FirstOrDefault(),
                                                            IdCabin = database.Cabins.Where(c=>c==loginPlace).Select(c=>c.Id).FirstOrDefault()
                                                          };
            database.SessionControls.Add(newSession);
            database.SaveChanges();
        }
        public LoginProxy(string username, string password, ValidationHandler handler, G4ProyectoDBContext db, Cabin cabin): base(username, password)
        {
            loginHandler = handler;
            database = db;
            loginPlace = cabin;
        }
        public override bool SignIn()
        {
            //calls the handler to check that everything is validated
            if (!loginHandler.Validate())
            {
                return false;
            }
            //saves the login info in the db
            LogAccess();
            //Signs in
            loginManager = new Login(Username, Password);
            return loginManager.SignIn();
        }
    }
}
