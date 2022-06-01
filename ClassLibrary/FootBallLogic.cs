using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FootBallLogic
    {
        public const string _goal = "yes";
        public FootBallLogic()
        {
        }

        //check hvormang passes er der og return string
        public string ThePasses(int passes)
        {
            if (passes < 0)
                return "OOPS looks like you are playing backwards";
            else if (passes < 1)
                return "Shhh";
            else if (passes >= 10)
                return "High Five - Jubel!!!";
            else
            {
                var str = string.Empty;
                for (int i = 0; i < passes; i++) str += "Huh! ";

                return str.TrimEnd();
            }
        }

        //check er det mål 
        public string CheerGoalOrPass(string goal, int passes)
        {
            if (goal.ToLower() == _goal)
            {
                return CheerGoal(goal);

            }

            else
                return ThePasses(passes);

        }

        //string for mål 
        public string CheerGoal(string goal)
        {
            return "Olé olé olé";
        }
    }
}
