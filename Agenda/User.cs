using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class User
    {
        public long ID;
        public string Login;
        private string Password;
        public string Name;
        public string BornDate;
        public Util.Sex Sex;
        public string RB;
        public string CPF;
        public string CNH;
        public String ProfileIMGAddress;
        public bool Active;

        public static List<User> GetUsers(Util.ActiveStatus status, string search = null)
        {
            return null;
        }

        public bool CheckPassword(string password)
        {
            return this.Password == password;
        }
    }
}
