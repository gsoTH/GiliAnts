using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiliAnts
{
    public partial class FrmGiliAnts : Form
    {
        int antLimit = 2;
        Hive hive;


        public FrmGiliAnts()
        {
            InitializeComponent();


        }

        private void FrmGiliAnts_Load(object sender, EventArgs e)
        {

        }

        private void FrmGiliAnts_Paint(object sender, PaintEventArgs e)
        {

            int antSize = 3;
            int hiveSize = 75;


            Graphics g = e.Graphics;

            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            if (TmrMain.Enabled == false) //setup
            {
                //TODO: Futterquelle einbauen, damit die Ants ein Ziel haben.
                hive = new Hive(w / 2, h / 2, antLimit);
                TmrMain.Enabled = true;

            }

            PrintDiagnostics(g);
            DrawAnts(antSize, g);
            DrawPheromones(g);
            DrawHive(hiveSize, g);
            
        }

        private static void DrawPheromones(Graphics g)
        {
            foreach (Pheromone p in Ant.Pheromones)
            {
                g.DrawEllipse(new Pen(p.Color), p.Rectangle);                
            }
        }

        private void DrawHive(int hiveSize, Graphics g)
        {
            
            g.FillEllipse(Brushes.SaddleBrown, hive.Position.X - hiveSize / 2, hive.Position.Y - hiveSize / 2, hiveSize, hiveSize);
        }

        private void DrawAnts(int antSize, Graphics g)
        {
            

            for (int i = 0; i < antLimit; i++)
            {
                Pen pen = new Pen(hive.Ants[i].Color);
                g.DrawRectangle(pen, new Rectangle(hive.Ants[i].Position, new Size(antSize, antSize)));
            }
        }
        private void PrintDiagnostics(Graphics g)
        {
            g.DrawString("Ants: " + hive.Ants.Length, this.Font, Brushes.Black, 0, 0);
        }

        private void TmrMain_Tick(object sender, EventArgs e)
        {
            foreach(Ant a in hive.Ants)
            {
                a.Move();
            }

            for (int i = 0; i < Ant.Pheromones.Count; i++)
            {
                Ant.Pheromones[i].Degrade();
            }

            Refresh();
        }

        private void FrmGiliAnts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                TmrMain.Enabled = !TmrMain.Enabled;
            }
        }
    }
}
