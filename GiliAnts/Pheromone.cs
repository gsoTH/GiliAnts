using System;
using System.Drawing;

namespace GiliAnts
{
    public class Pheromone
    {
        private Point position;
        private int intensity;
        private Color color;

        public Pheromone(Point position, int intensity, Color color):this(position, intensity)
        {
            this.Color = color;
        }

        public Pheromone(Point position, int intensity)
        {
            this.position = position;
            this.intensity = intensity;
        }

        public Pheromone(Point position) : this(position, 1) { }

        public Point Position { get => position; set => position = value; }
        public int Intensity { get => intensity; set => intensity = value; }
        public Color Color { get => color; set => color = value; }

        public void Degrade()
        {
            Intensity--;


            if (intensity <= 0)
            {
                Ant.Pheromones.Remove(this);
            }
        }
    }
}
