using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Terrance : Player
    {
        public Terrance() : base("Tricky Terrance")
        {
        }

        public override Roshambo GenerateRoshambo(Roshambo playerThrow, Roshambo playerLastThrow)
        {
            if (playerLastThrow == Roshambo.Rock) return Roshambo.Paper;
            if (playerLastThrow == Roshambo.Paper) return Roshambo.Scissors;
            return Roshambo.Rock;
        }

        public override string Taunt()
        {
            return "I'm very good at this game!";
        }
    }
}
