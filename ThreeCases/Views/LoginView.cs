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
        public ClassLibrary.LoginLogic _loginLogic;

        public LoginView()
        {
            _loginLogic = new LoginLogic();


            bool verified = false;
            string username, password;

            LoginLogic loginLogic1 = new LoginLogic();

            do
            {

                Console.Write("Username: ");
                username = Console.ReadLine().ToLower();

                Console.Write("Password: ");
                password = Console.ReadLine();

                var verifying = ClassLibrary.LoginLogic.VerifyLogin(username, password);

                if (verifying)
                {
                    Console.WriteLine("Login In success");
                    Console.ReadKey();
                    Console.Clear();
                    var obj4 = new MainMenuView();
                    verified = true;

                }

                else
                {
                    Console.WriteLine("Your username and password is not correct try again");
                    Console.ReadKey();

                }
            }

            while (!verified);
        }

    }
}