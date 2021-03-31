using System;
using System.Drawing;

namespace GiliAnts
{
    public class Ant
    {
        static Random rnd = new Random();
        private Point position;
        private Color color;

        public Ant(int x, int y)
        {
            this.position = new Point(x, y);
        }

        public Ant(int x, int y, Color color):this(x, y)
        {
            this.Color = color;
        }

        public void Move()
        {
            int step = 3;
            int i = rnd.Next(0, 4);
            
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
        public Color Color
        { 
            get => color; 
            set => color = value; 
        }
    }
}
