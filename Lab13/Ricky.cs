using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Ricky : Player
    {
        public Ricky() : base("Ricky Random")
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            Random rand = new Random();
            return (Roshambo)rand.Next(0, 3);
        }

        public override string Taunt()
        {
            return "What will I choose? No one knows!";
        }
    }
}
