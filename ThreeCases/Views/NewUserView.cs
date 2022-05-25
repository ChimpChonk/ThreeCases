using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases
{
    internal class NewUserView
    {
        public ClassLibrary.LoginLogic _loginLogic;
        public ClassLibrary.PasswordCheckLogic _passwordCheckLogic;
        public ClassLibrary.WriteToFile _writeToFile;

        string username, password;
        bool verified = false;

        public NewUserView()
        {
            _loginLogic = new LoginLogic();
            _passwordCheckLogic = new PasswordCheckLogic();
            _writeToFile = new WriteToFile();

            while (!verified)
            {
                Console.Write("New Username: ");
                username = Console.ReadLine().ToLower();

                Console.Write("New Password: ");
                password = Console.ReadLine();

                var isNewPassVerified = _passwordCheckLogic.PasswordChecked(password);

                if (isNewPassVerified)
                {
                    var wrote = ClassLibrary.WriteToFile.ChangeLogIn(username, password);
                    Console.WriteLine("New user has been created.");
                    Console.ReadKey();
                    var obj1 = new LoginMenuView();

                    verified = true;
                }

                else
                {
                    Console.WriteLine("Make sure your password has more then 12 characters with capital letters, symbols, number and no spaces");
                }
            }
        }

    }
}
