using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LoginLogic
    {
        public string Username { get;}
        public string Password { get;}
        public bool Verified { get;}

        public LoginLogic(string username, string password, bool verified)
        {
            Username = username;
            Password = password;
            Verified = verified;
        }

        public LoginLogic()
        {
        }

        

        public static bool VerifyLogin(string username, string password)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sanpou\Desktop\ThreeCases\ClassLibrary\logins.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] field = lines[i].Split(' ');
                if (field[0].Equals(username) && field[1].Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
