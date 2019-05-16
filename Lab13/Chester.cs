using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Chester : Player
    {
        public Chester() : base("Chester Cheater")
        {
        }

        public override Roshambo GenerateRoshambo(Roshambo playerThrow, Roshambo playerLastThrow)
        {
            if (playerThrow == Roshambo.Rock) return Roshambo.Paper;
            if (playerThrow == Roshambo.Paper) return Roshambo.Scissors;
            return Roshambo.Rock;
        }

        public override string Taunt()
        {
            return "You can never win!";
        }
    }
}
