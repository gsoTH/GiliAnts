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
        int antLimit = 1000;
        Ant[] ants;


        public FrmGiliAnts()
        {
            InitializeComponent();

            ants = new Ant[antLimit];
        }

        private void FrmGiliAnts_Load(object sender, EventArgs e)
        {

        }

        private void FrmGiliAnts_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            if(TmrMain.Enabled == false) //setup
            {
                Random rnd = new Random();
                for (int i = 0; i < antLimit; i++)
                {
                    Color color = Color.FromArgb(   rnd.Next(0, 256),
                                                rnd.Next(0, 256),
                                                rnd.Next(0, 256));
                    ants[i] = new Ant(w / 2, h / 2, color);
                }

                TmrMain.Enabled = true;
                
            }

            

            int antSize = 3;
            Pen pen;
            for (int i = 0; i < antLimit; i++)
            {
                pen = new Pen(ants[i].Color);
                g.DrawRectangle(pen, new Rectangle(ants[i].Position, new Size(antSize, antSize)));
            }
        }

        private void TmrMain_Tick(object sender, EventArgs e)
        {
            foreach(Ant a in ants)
            {
                a.Move();
            }

            Refresh();
        }
    }
}
