using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometaTests
{
    public class AccountData   //Данные пользователя
    {
        private string username;
        private string password;

        public AccountData(string username, string password)  // конструктор
        {
            this.username = username;
            this.password = password;
        }

        public string Username  // свойство
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

    }
}