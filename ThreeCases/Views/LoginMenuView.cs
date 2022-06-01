using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeCases.Views;

namespace ThreeCases
{
    internal class LoginMenuView
    {
        public LoginMenuView()
        {
            //Console menu UI
            Console.WriteLine("1. Press 1 to login.");
            Console.WriteLine("2. Press 2 to change password.");
            Console.WriteLine("3. Press 3 to create new login.");

            //User valg
            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                //Refrence til Login View
                case "1":
                    var obj2 = new LoginView();
                    break;

                //Refrence til Password chage view
                case "2":
                    var obj3 = new PasswordChangeView();
                    break;

                //Refrence til ny user
                case "3":
                    var obj4 = new NewUserView();
                    break;
            }
        }
    }
}