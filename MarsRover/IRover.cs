using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    interface IRover
    {
         void move();
         void turnLeft();
         void turnRight();
        void setPosition(int x, int y, Position pos);
        void explore(string roadMap);
        void showPositionDetails();
    }
}
