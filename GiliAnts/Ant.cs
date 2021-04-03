using System;
using System.Collections.Generic;
using System.Drawing;

namespace GiliAnts
{
    public class Ant
    {
        static Random rnd = new Random();
        static List<Pheromone> pheromones = new List<Pheromone>();
        private Point position;
        private Color color;
        private int generalDirection;

        private int stepLimit;
        private int steps;

        public Ant(int x, int y)
        {
            Position = new Point(x, y);
            stepLimit = rnd.Next(12, 62);
            steps = 0;
        }

        public Ant(int x, int y, Color color):this(x, y)
        {
            Color = color;
        }

        public Ant(int x, int y, Color color, int generalDirection) : this(x, y, color)
        {
            GeneralDirection = generalDirection;
        }

        public void Move()
        {
            Pheromones.Add(new Pheromone(this.position, 5, this.color));
            
            for (int i = 0; i < Pheromones.Count; i++)
            {
                Pheromones[i].Degrade();
            }
            //TODO: Pheromone sollten im Lauf der Zeit schwächer werden.
            //TODO: Pheromone sollten stärker werden, je häufiger eine Ant darüber läuft.
            //TODO: Pheromone sollten Einfluss auf die Navigation der Ant haben.

            if (steps < stepLimit)
            {
                steps++;
            }
            else
            {
                steps = 0;
                GeneralDirection = rnd.Next(0,5);
            }

            //TODO: Diese Variable sollte an zentraler Stelle stehen.
            int step = 3;

            int direction = rnd.Next(0,5);
            
            if(direction != generalDirection - 4)
            {
                if(direction == GeneralDirection)
                {
                    step = step * 2;
                }

                switch (direction)
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
        }

        public Point Position
        {
            get => position;
            private set => position = value;
        }
        public Color Color
        { 
            get => color; 
            set => color = value; 
        }
        int GeneralDirection { get => generalDirection; set => generalDirection = value; }
        public static List<Pheromone> Pheromones { get => pheromones; set => pheromones = value; }
    }
}
