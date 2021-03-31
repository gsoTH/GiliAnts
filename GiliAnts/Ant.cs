using System;
using System.Drawing;

namespace GiliAnts
{
    public class Ant
    {
        static Random rnd = new Random();
        private Point position;

        public Ant(int x, int y)
        {
            this.position = new Point(x, y);
        }

        public void Move()
        {
            int step = 1;
            int i = rnd.Next(0, 3);
            
            switch (i)
            {
                case 0: //move north
                    this.position.Y -= step;
                    break;
                case 1: //move east
                    this.position.X += step;
                    break;
                case 2: //move south
                    this.position.Y += step;
                    break;
                case 3: //move west
                    this.position.X -= step;
                    break;
                default:
                    break;
            }
        }

        public Point Position
        {
            get => position;
        }
    }
}
