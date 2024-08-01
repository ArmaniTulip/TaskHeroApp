using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskHeroApp.Model
{
    internal class User
    {
        public string userName { get; set; }

        protected string _password = Guid.NewGuid().ToString();
        public string password
        {
            set
            {

            }
        }

    }
}
