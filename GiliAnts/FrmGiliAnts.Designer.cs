namespace GiliAnts
{
    partial class FrmGiliAnts
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TmrMain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TmrMain
            // 
            this.TmrMain.Tick += new System.EventHandler(this.TmrMain_Tick);
            // 
            // FrmGiliAnts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmGiliAnts";
            this.Text = "Gili Ants";
            this.Load += new System.EventHandler(this.FrmGiliAnts_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmGiliAnts_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmrMain;
    }
}

