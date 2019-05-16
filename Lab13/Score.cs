using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Score
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public Roshambo Lastplay { get; set; }

        public Score()
        {
            Wins = 0;
            Losses = 0;
            Draws = 0;
            Lastplay = 0;
        }
    }
}
