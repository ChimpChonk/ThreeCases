using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases.Views
{
    public class PasswordChangeView
    {
        public ClassLibrary.LoginLogic _loginLogic;
        public ClassLibrary.PasswordCheckLogic _passwordCheckLogic;
        public ClassLibrary.WriteToFile _writeToFile;


        string username, password;
        bool verified = false;
        bool newPassVerified = false;
        public PasswordChangeView()
        {
            _loginLogic = new LoginLogic();
            _passwordCheckLogic = new PasswordCheckLogic();

            while (!verified)
            {

                Console.Write("Username: ");
                username = Console.ReadLine().ToLower();

                Console.Write("Password: ");
                password = Console.ReadLine();

                var verifying = ClassLibrary.LoginLogic.VerifyLogin(username, password);

                if (verifying)
                {
                    Console.WriteLine("Username and password is vailed.");
                    verified = true;
                }

                else
                {
                    Console.WriteLine("Your username or password is not correct try again");
                }
            }
            while (!newPassVerified)
            {
                Console.Write("New Password: ");
                password = Console.ReadLine();

                var isNewPassVerified = _passwordCheckLogic.PasswordChecked(password);

                if (isNewPassVerified)
                {
                    var wrote = ClassLibrary.WriteToFile.ChangeLogIn(username, password);
                    Console.WriteLine("Password has been changed");
                    Console.ReadKey();
                    var obj1 = new LoginMenuView();

                    newPassVerified = true;
                }
                else
                {
                    Console.WriteLine("Make sure your new password is not your old password and has more then 12 characters with capital letters, symbols, number and no spaces");
                }

            }
        }
    }
}







