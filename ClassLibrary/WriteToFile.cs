using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class WriteToFile
    {

        //get value til at skrive til file
        public string Username { get;}
        public string Password { get;}

        public WriteToFile(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public WriteToFile()
        {
        }

        //Skriv til file
        public string ChangeLogIn(string username, string password)
        {
            string write = username + " " + password;

            File.WriteAllText(@"C:\Users\sanpou\Desktop\ThreeCases\ClassLibrary\logins.txt", write);

            return "Success";
        }
    }
}
