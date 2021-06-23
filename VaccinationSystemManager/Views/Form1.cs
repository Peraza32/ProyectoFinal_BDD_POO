using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationSystemManager.Model;
using VaccinationSystemManager.Controller;

namespace VaccinationSystemManager
{
    public partial class Form1 : Form
    {
        G4ProyectoDBContext db = new G4ProyectoDBContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cboCabin.DataSource = db.Cabins.Select( c =>  c.CabinAddress ).ToList();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //handlers for username and password
                GenericTextboxHandler passwordValidation = new GenericTextboxHandler(null,
                                                                     txtPassword,
                                                                     () => db.Employees.Where(e => e.EmployeeUser == txtUsername.Text && e.EmployeePassword == txtPassword.Text).ToList().Count == 1,
                                                                     "La contraseña no coincide con el usuario ingresado");

                GenericTextboxHandler usernameValidation = new GenericTextboxHandler(passwordValidation,
                                                           txtUsername,
                                                           () => db.Employees.Where(e => e.EmployeeUser == txtUsername.Text).ToList().Count() == 1,
                                                           "El nombre de usuario no se encuentra en la base de datos");


                //creates the proxy to do the login
                LoginProxy login = new LoginProxy(txtUsername.Text, txtPassword.Text, usernameValidation, db, db.Cabins.Where(c => c.CabinAddress == cboCabin.Text).FirstOrDefault());
                //once the validators have passed it proceeds to sign in
                if (login.SignIn())
                {
                    Views.Dashboard dashboard = new Views.Dashboard(db.Employees.Where(e => e.EmployeeUser == txtUsername.Text).FirstOrDefault());
                    Hide();
                    dashboard.ShowDialog();
                }
            }
            catch(FormInputException frmEx)
            {
                epLogin.SetError(frmEx.errorTarget, frmEx.Message);
            }

        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            epLogin.Clear();
        }
    }
}
