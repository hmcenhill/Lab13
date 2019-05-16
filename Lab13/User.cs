using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class User : Player
    {
        public User(string name) : base(name)
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            Console.Write($"1 - Rock, 2 - Paper, 3 - Scissors:  ");
            int input = Validator.GetInt(1, 3);
            return (Roshambo)input-1;
        }

        public override string Taunt()
        {
            return "How did you get here?";
        }
    }
}
