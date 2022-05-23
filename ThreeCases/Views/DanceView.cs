using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases.Views
{
    internal class DanceView
    {
        public ClassLibrary.DanceLogic _dance;
        public DanceView()
        {

            _dance = new DanceLogic();

            int score = 0;
            string name;
            bool isvalid = false;

            Console.Write("First contestant name: ");

            name = Console.ReadLine();

            while (!isvalid)
            {
                Console.Write("First contestant score:");

                string givenScore = Console.ReadLine();
                if (Int32.TryParse(givenScore, out score))
                {
                    isvalid = true;
                }

                else
                {
                    Console.WriteLine("ERROR: try againg, give a number.");
                }
            }

            DanceLogic dancer1 = new DanceLogic(name, score);

            isvalid = false;

            Console.Write("\nSecond contestant name: ");

            name = Console.ReadLine();

            while (!isvalid)
            {
                Console.Write("Second Contestant score:");

                string givenScore = Console.ReadLine();
                if (Int32.TryParse(givenScore, out score))
                {
                    isvalid = true;
                }

                else
                {
                    Console.WriteLine("ERROR: try againg, give a number.");
                }
            }

            DanceLogic dancer2 = new DanceLogic(name, score);


            DanceLogic dancer3 = dancer1 + dancer2;

            Console.WriteLine(dancer3.Name + ": " + dancer3.Score);

        }
    }
}
