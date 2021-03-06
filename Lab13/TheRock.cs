﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class TheRock : Player
    {
        public TheRock() : base("The Rock")
        {
        }

        public override Roshambo GenerateRoshambo(Roshambo playerThrow, Roshambo playerLastThrow)
        {
            return Roshambo.Rock;
        }

        public override string Taunt()
        {
            return "Do you smell what The Rock is cooking?";
        }
    }
}
