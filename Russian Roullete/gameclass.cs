using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
    // creating child class
    class gameclass
    {
        public int loadchamber;
        public int Missed = 2;
        public int Fire = 6;
        public int Loaded = 1;


        public int spin(int s)
        {
            if (s == 6)
            {
                s = 1;

            }
            else
            {
                s++;
            }

            return s;
        }
       public int Fired()
        {
            // function of shooting or game
            int score = 0;
            if (Fire > 0 && Loaded == loadchamber)
            {
                score = 1;
            }
            else if (Fire > 0 && loadchamber != Loaded)
            {
                score = 2;
                Fire = Fire - 1;
                loadchamber = spin(loadchamber);
            }
            return score;
        }
    }
}

