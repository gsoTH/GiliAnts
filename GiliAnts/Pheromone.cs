using System;
using System.Drawing;

namespace GiliAnts
{
    public class Pheromone
    {

        private const int default_intensity = 5;
        private Point position;
        private int intensity;
        private Color color;

        /// <summary>
        /// Creates a new pheromone.
        /// </summary>
        /// <param name="position">Where the pheromone is dropped.</param>
        /// <param name="intensity">Basically Diameter. Will be reduced at every tick. Pheremone ist removed once intensity < 0.</param>
        /// <param name="color">Add color of creating Ant, for warm fuzzy family feelings.</param>
        public Pheromone(Point position, int intensity, Color color):this(position, intensity)
        {
            this.Color = color;
        }

        /// <summary>
        /// Creates a new pheromone.
        /// </summary>
        /// <param name="position">Where the pheromone is dropped.</param>
        /// <param name="intensity">Basically Diameter. Will be reduced at every tick. Pheremone ist removed once intensity < 0.</param>
        public Pheromone(Point position, int intensity)
        {
            this.position = position;
            this.intensity = intensity;
        }

        public Pheromone(Point position, Color color) : this(position, default_intensity, color)
        {

        }

        /// <summary>
        /// Creates a new pheromone, normally used for test only.
        /// </summary>
        /// <param name="position">Where the pheromone is dropped.</param>
        public Pheromone(Point position) : this(position, default_intensity) { }

        public Point Position { get => position; set => position = value; }
        /// <summary>
        /// Basically Diameter. Will be reduced at every tick. Pheremone ist removed once intensity < 0.
        /// </summary>
        public int Intensity { get => intensity; set => intensity = value; }
        public Color Color { get => color; set => color = value; }

        /// <summary>
        /// A rectangle, positioned over the center of position.
        /// </summary>
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(Position.X - Intensity / 2, Position.Y - Intensity / 2, Intensity, intensity);
            }
        }
        /// <summary>
        /// Reduces Intensity of the pheromone. Pheromone will be reduced at every tick. Pheremone ist removed once intensity < 0.
        /// </summary>
        public void Degrade()
        {
            intensity--;


            if (intensity <= 0)
            {
                Ant.Pheromones.Remove(this);
            }
        }
    }
}
