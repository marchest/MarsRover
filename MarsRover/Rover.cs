
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    abstract class Rover : IRover
    {
        protected string name { get; set; }
        protected int x_axis { get; set; }
        protected int y_axis { get; set; }
        protected Position currentPos { get; set; }
      

        public void setPosition(int x, int y, Position pos)
        {
            this.x_axis = x;
            this.y_axis = y;
            this.currentPos = pos;
        }

     

        public abstract void move();

        public abstract void turnLeft();

        public abstract void turnRight();

        public abstract void explore(string roadMap);
     
        public Rover(string name)
        {
            this.name = name;
           
        }

        public int posToInt(Position p)
        {
            return (int)p;
        }

        public void showPositionDetails()
        {
            Console.WriteLine(this.x_axis + " " + this.y_axis + " " + this.currentPos);
        }
    }
}
