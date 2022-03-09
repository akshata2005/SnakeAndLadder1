using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class StartPosition
    {
        //Instance Variables.
        int position = 0;
        //Method
        public void RunGame()
        {
            Console.WriteLine("Player position is: " + position);
        }
    }
}
