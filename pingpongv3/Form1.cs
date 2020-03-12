using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace mod_404_Ping_Pong
{
    public partial class Form1 : Form
    {
        private int _directionX = 5;
        private int _directionY = 2;
        private int _points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Enabled = true;
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            pnlSpiel.Location = new Point(pnlSpiel.Location.X + _directionX, pnlSpiel.Location.Y + _directionY);
            
            // Ball trifft auf rechten Spielfeldrand
            if (pnlSpiel.Location.X >= picBall.Width - pnlSpiel.Width-picSchlägerRechts.Width
                && pnlSpiel.Location.Y + pnlSpiel.Height >= picSchlägerRechts.Location.Y
                && pnlSpiel.Location.Y <= picSchlägerRechts.Location.Y + picSchlägerRechts.Height)
            {
                _directionX = -_directionX;
                _points += 10; // Punktestand um 10 erhöhen
            }
            
            // Ball trifft auf linken Spielfeldrand
            if (pnlSpiel.Location.X <= 0)
            {
                _directionX = -_directionX;
            }
            
            // Ball trifft auf oberen Spielfeldrand
            if (pnlSpiel.Location.Y >= picBall.Height - pnlSpiel.Height)
            {
                _directionY = -_directionY;
            }
            
            // Ball trifft auf rechten Spielfeldrand
            if (pnlSpiel.Location.Y < 0)
            {
                _directionY = -_directionY;
            }
            
            // Punktestand anzeigen
            txtPunkte.Text = Convert.ToString(_points);
        }

        private void frmPingPong_Load(object sender, EventArgs e)
        {
            // Schläger ganz rechts ins Panel setzen
            picSchlägerRechts.Location = new Point(picBall.Width - picSchlägerRechts.Width, picBall.Height / 2);
            
            // Scrollbar rechts neben Panel setzen, Maximal und Minimalwert und aktuellen Wert einstellen
            vsbSchlägerRechts.Height = picBall.Height;
            vsbSchlägerRechts.Location = new Point(picBall.Location.X + picBall.Width, picBall.Location.Y);
            vsbSchlägerRechts.Minimum = 0;
            vsbSchlägerRechts.Maximum = picBall.Height - picSchlägerRechts.Height + picSchlägerRechts.Width;
            vsbSchlägerRechts.Value = picSchlägerRechts.Location.Y;
        }

        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlägerRechts.Location = new Point(picSchlägerRechts.Location.X, vsbSchlägerRechts.Value);
            vsbSchlägerRechts.Value = picSchlägerRechts.Location.Y;
        }
    }
}