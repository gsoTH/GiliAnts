using System;
using System.Drawing;

namespace GiliAnts
{
    public struct Pheromone
    {
        private Point position;
        private int intensity;

        public Pheromone(Point position, int intensity)
        {
            Position = position;
            Intensity = intensity;
        }

        public Pheromone(Point position) : this(position, 1) { }

        public Point Position { get => position; set => position = value; }
        public int Intensity { get => intensity; set => intensity = value; }
    }
}
