using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DanceLogic
    {
        public string Name { get; }
        public int Score { get; }


        public DanceLogic(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public DanceLogic()
        {
        }

        public static DanceLogic operator +(DanceLogic dancer1, DanceLogic dancer2)
        {
            var fællesNavn = dancer1.Name + " & " + dancer2.Name;
            var fællesPoints = dancer1.Score + dancer2.Score;
            return new DanceLogic(fællesNavn, fællesPoints);
        }
    }
}
