using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases
{
    internal class LoginView
    {

        //Refrence til login loigc 
        public ClassLibrary.LoginLogic _loginLogic;

        public LoginView()
        {
            _loginLogic = new LoginLogic();


            bool verified = false;
            string username, password;

            //loop til user har tastet rigtig username og password
            do
            {
                //User username
                Console.Write("Username: ");
                username = Console.ReadLine().ToLower();

                //user password
                Console.Write("Password: ");
                password = Console.ReadLine();

                //refrence til login logic. Det checke hvis password og username er valid eller nej og return en bool
                bool verifying = _loginLogic.VerifyLogin(username, password);

                if (verifying)
                {
                    Console.WriteLine("Login In success");
                    Console.ReadKey();
                    Console.Clear();

                    //refrence til main menu
                    var obj4 = new MainMenuView();
                    verified = true;

                }

                else
                {
                    //error message
                    Console.WriteLine("Your username or password is not correct try again");
                    Console.ReadKey();

                }
            }

            while (!verified);
        }

    }
}