using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar.Model
{
    class Validator
    {
        private string username;
        private string password;

        public Validator(string user, string pass)
        {
            this.username = user;
            this.password = pass;
        }

        public Boolean isValid()
        {
            bool result;
            if (username == "admin" && password == "admin")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
