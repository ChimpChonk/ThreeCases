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
        public DanceView()
        {


            int score = 0;
            string name;
            bool isvalid = false;

            Console.Write("First contestant name: ");

            name = Console.ReadLine();

            //check hvis score er int
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
                    //error
                    Console.WriteLine("ERROR: try againg, give a number.");
                }
            }

            //refrence til dance logic
            DanceLogic dancer1 = new DanceLogic(name, score);

            isvalid = false;

            Console.Write("\nSecond contestant name: ");

            name = Console.ReadLine();

            //Check score er int 
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
                    //error
                    Console.WriteLine("ERROR: try againg, give a number.");
                }
            }

            //refrence dance logic 
            DanceLogic dancer2 = new DanceLogic(name, score);

            //append dancer 1 og 2 naven og score
            DanceLogic dancer3 = dancer1 + dancer2;

            Console.WriteLine(dancer3.Name + ": " + dancer3.Score);

        }
    }
}
