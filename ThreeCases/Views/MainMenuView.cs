using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeCases.Views;

namespace ThreeCases
{
    internal class MainMenuView
    {
        public MainMenuView()
        {
            //Choices 
            Console.WriteLine("Press 1 for FootBall.");
            Console.WriteLine("Press 2 for Dance Compitation.");
            Console.WriteLine("Press 3 for Opret eller ændre password.");

            string userChoice = Console.ReadLine();

            Console.Clear();

            switch (userChoice)
            {
                case "1":
                    var obj5 = new FootBallView(); //Football view
                    break;

                case "2":
                    var obj6 = new DanceView(); //Dance view
                    break;

            }


            Console.ReadKey();
        }
    }
}
