using System;
using NextCar.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NextCar.Controller
{
    class LoginController
    {
        private Validator validation;

        public LoginController(string username, string password)
        {
            this.validation = new Validator(username, password);

            if (validation.isValid() == true)
            {
                
                MainWindow main = new MainWindow();
                main.Show();

                Login login = new Login();
                login.Close();
            }
            else
            {
                MessageBox.Show("Username atau password masih salah");
            }
        }
    }
}
