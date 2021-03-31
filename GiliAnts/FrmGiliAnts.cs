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
            Graphics g = e.Graphics;

            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            if(TmrMain.Enabled == false) //setup
            {

                hive = new Hive(w / 2, h / 2, antLimit);
                TmrMain.Enabled = true;
                
            }

            PrintDiagnostics(g);

            int antSize = 3;
            Pen pen;

            for (int i = 0; i < antLimit; i++)
            {
                pen = new Pen(hive.Ants[i].Color);
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
