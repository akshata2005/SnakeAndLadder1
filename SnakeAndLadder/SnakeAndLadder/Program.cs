using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Showing Welcome message on console
            Console.WriteLine("Welcome to Snake And Ladder Game Program\n");
            //Object creation of class. 
            StartPosition startPosition = new StartPosition();
            startPosition.RunGame();     //call method of class.
            Console.ReadLine();
        }
    }
}
