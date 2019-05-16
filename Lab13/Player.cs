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

        public abstract Roshambo GenerateRoshambo();
        public abstract string Taunt();
    }
}



// Players:
// The Rock
// Ricky Random
// Chester Cheater
// Tricky Terrance