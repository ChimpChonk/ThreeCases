using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases.Views
{
    internal class FootBallView
    {
        //køre RunFootBall method
        public FootBallView()
        {
            RunFootBall();
        }

        //Run football method
        internal void RunFootBall()
        {
            Console.WriteLine("Is there a goal:");

            var goal = Console.ReadLine();

            Console.WriteLine("How many passes: ");

            //give error hvis input er negitive tale eller decimale tal
            bool success = Int32.TryParse(Console.ReadLine(), out int passes);

            if (!success)
            {
                //error
                Console.WriteLine("Ouch something went wrong F");
                return;
            }

            //Refrence til football logic 
            var football = new FootBallLogic();

            var result = football.CheerGoalOrPass(goal, passes);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
