using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //To do
            IRover myrover = new MyRover("HepsiBurada");

            /*myrover.setPosition(3, 3, Position.E);
              myrover.explore("MMRMMRMRRM");*/
            myrover.setPosition(1, 2, Position.N);
            myrover.explore("LMLMLMLMM");
            myrover.showPositionDetails();
            Console.ReadLine();

        }
    }
}
