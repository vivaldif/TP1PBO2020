using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    class login
    {
        public int username { get; set; }
        public string pass { get; set; }
        public login(int username, string pass)
        {
            this.username = username;
            this.pass = pass;
        }

        public login()
        {
        }
    }
}