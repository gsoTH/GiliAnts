using System;
using System.Drawing;

namespace GiliAnts
{
    class Hive
    {
        private Point position;
        private Ant[] ants;

        public Hive(int x, int y, int antLimit)
        {
            position = new Point(x, y);
            ants = new Ant[antLimit];

            Random rnd = new Random();
            Random direction = new Random();
            for (int i = 0; i < antLimit; i++)
            {
                Color color = Color.FromArgb(rnd.Next(0, 256),
                                                rnd.Next(0, 256),
                                                rnd.Next(0, 256));

                //TODO: Die Ants sollten nicht alle gleichzeitig  erzeugt werden, sondern nacheinander, wenn z.B. genügend Platz/Futter vorhanden ist.
                ants[i] = new Ant(position.X, position.Y, color, direction.Next(0, 5));
            }
        }


        public Ant[] Ants
        {
            get => ants;
        }
        public Point Position
        {
            get => position;
            private set => position = value;
        }
    }
}
