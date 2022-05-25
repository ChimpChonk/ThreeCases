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
        public FootBallView()
        {
            RunFootBall();
        }

        internal void RunFootBall()
        {
            Console.WriteLine("Is there a goal:");

            var goal = Console.ReadLine();

            Console.WriteLine("How many passes: ");
            bool success = Int32.TryParse(Console.ReadLine(), out int passes);

            if (!success)
            {
                Console.WriteLine("Ouch something went wrong F");
                return;
            }


            var football = new FootBallLogic();

            FootBallLogic football2 = football;

            var result = football2.CheerGoalOrPass(goal, passes);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
