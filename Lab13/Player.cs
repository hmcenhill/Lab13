using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Throw { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public abstract Roshambo GenerateRoshambo(Roshambo playerThrow, Roshambo playerLastThrow);
        public abstract string Taunt();
    }
}

