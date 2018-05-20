using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class MyRover : Rover
    {
        public MyRover(string name) : base(name)
        {
        }

        public override void explore(string roadMap)
        {
            for (int i = 0; i < roadMap.Length; i++)
            {
                if (roadMap[i].Equals('L'))
                {
                    turnLeft();
                }
                else if (roadMap[i].Equals('R'))
                {
                    turnRight();
                }
                else if (roadMap[i].Equals('M'))
                {
                    move();
                }
                else
                {
                    throw new ArgumentException("Not found command--> " + roadMap[i]);
                }
            }
        }

        public override void move()
        {
            if (currentPos==Position.N)
            {
                this.y_axis++;
            }
           else if (currentPos==Position.W)
            {
                this.x_axis--;

            }
            else if (currentPos==Position.S)
            {
                this.y_axis--;
            }
            else if(currentPos==Position.E)
            {
                this.x_axis++;
            }
        }
     
        public override void turnLeft()
        {
            // currentPos =(Position)( (posToInt(currentPos)-1) < posToInt(Position.N) ? posToInt(Position.W) : (posToInt(currentPos) - 1));
            switch (currentPos)
            {
                case Position.N:
                    this.currentPos = Position.W;
                    break;

                case Position.W:
                    this.currentPos = Position.S;
                    break;

                case Position.S:
                    this.currentPos = Position.E;
                    break;

                case Position.E:
                    this.currentPos = Position.N;
                    break;
            }
        }

        public override void turnRight()
        {
            //  currentPos = (Position)((posToInt(currentPos)+1) > posToInt(Position.W) ? posToInt(Position.N) : (posToInt(currentPos) + 1));
            switch (currentPos)
            {
                case Position.N:
                    this.currentPos = Position.E;
                    break;

                case Position.E:
                    this.currentPos = Position.S;
                    break;

                case Position.S:
                    this.currentPos = Position.W;
                    break;

                case Position.W:
                    this.currentPos = Position.N;
                    break;
            }
        }
    }
}
