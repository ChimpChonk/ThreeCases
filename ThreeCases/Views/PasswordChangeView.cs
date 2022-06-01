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
        //Refrence til logik 
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

            //loop til user har tast rigtig username og password
            while (!verified)
            {

                Console.Write("Username: ");
                username = Console.ReadLine().ToLower();

                Console.Write("Password: ");
                password = Console.ReadLine();

                //refrence til login logic. Det checke hvis password og username er valid eller nej og return en bool
                bool verifying = _loginLogic.VerifyLogin(username, password);

                if (verifying)
                {
                    Console.WriteLine("Username and password is vailed.");
                    verified = true;
                }

                else
                {
                    //not valid
                    Console.WriteLine("Your username or password is not correct try again");
                }
            }

            //loop til user has tast en stærk password
            while (!newPassVerified)
            {
                Console.Write("New Password: ");
                password = Console.ReadLine();

                //check om kravene er opfyldt
                var isNewPassVerified = _passwordCheckLogic.PasswordChecked(password);

                if (isNewPassVerified)
                {
                    //Skrive til fil
                    var wrote = _writeToFile.ChangeLogIn(username, password);
                    Console.WriteLine("Password has been changed");
                    Console.ReadKey();

                    //refrence til login view
                    var obj1 = new LoginMenuView();

                    //bool out of loop
                    newPassVerified = true;
                }
                else
                {
                    //error 
                    Console.WriteLine("Make sure your new password is not your old password and has more then 12 characters with capital letters, symbols, number and no spaces");
                }

            }
        }
    }
}







