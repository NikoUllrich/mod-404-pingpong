namespace mod_404_Ping_Pong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.namePunkte = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.vsbSchlägerRechts = new System.Windows.Forms.VScrollBar();
            this.picSchlägerRechts = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoch = new System.Windows.Forms.Button();
            this.btnUnten = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picSchlägerRechts)).BeginInit();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picBall.Location = new System.Drawing.Point(12, 12);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(453, 213);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 312);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 120;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Location = new System.Drawing.Point(237, 113);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(18, 17);
            this.pnlSpiel.TabIndex = 3;
            // 
            // namePunkte
            // 
            this.namePunkte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.namePunkte.Location = new System.Drawing.Point(12, 249);
            this.namePunkte.Name = "namePunkte";
            this.namePunkte.Size = new System.Drawing.Size(63, 27);
            this.namePunkte.TabIndex = 4;
            this.namePunkte.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPunkte.Location = new System.Drawing.Point(80, 249);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(100, 26);
            this.txtPunkte.TabIndex = 5;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsbSchlägerRechts
            // 
            this.vsbSchlägerRechts.Location = new System.Drawing.Point(468, 12);
            this.vsbSchlägerRechts.Name = "vsbSchlägerRechts";
            this.vsbSchlägerRechts.Size = new System.Drawing.Size(17, 213);
            this.vsbSchlägerRechts.TabIndex = 6;
            this.vsbSchlägerRechts.Value = 50;
            this.vsbSchlägerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSchlägerRechts_Scroll);
            // 
            // picSchlägerRechts
            // 
            this.picSchlägerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlägerRechts.Location = new System.Drawing.Point(437, 35);
            this.picSchlägerRechts.Name = "picSchlägerRechts";
            this.picSchlägerRechts.Size = new System.Drawing.Size(3, 40);
            this.picSchlägerRechts.TabIndex = 7;
            this.picSchlägerRechts.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(119, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "W. oben, S. unten";
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.White;
            this.btnHoch.Location = new System.Drawing.Point(386, 252);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(75, 23);
            this.btnHoch.TabIndex = 9;
            this.btnHoch.Tag = "ho";
            this.btnHoch.Text = "\"\"";
            this.btnHoch.UseVisualStyleBackColor = false;
            // 
            // btnUnten
            // 
            this.btnUnten.BackColor = System.Drawing.Color.White;
            this.btnUnten.Location = new System.Drawing.Point(388, 281);
            this.btnUnten.Name = "btnUnten";
            this.btnUnten.Size = new System.Drawing.Size(73, 22);
            this.btnUnten.TabIndex = 10;
            this.btnUnten.Tag = "un";
            this.btnUnten.Text = "\"\"";
            this.btnUnten.UseVisualStyleBackColor = false;
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.White;
            this.btnLinks.Location = new System.Drawing.Point(307, 282);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(75, 23);
            this.btnLinks.TabIndex = 11;
            this.btnLinks.Tag = "li";
            this.btnLinks.Text = "\"\"";
            this.btnLinks.UseVisualStyleBackColor = false;
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.White;
            this.btnRechts.Location = new System.Drawing.Point(467, 282);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(75, 23);
            this.btnRechts.TabIndex = 12;
            this.btnRechts.Tag = "re";
            this.btnRechts.Text = "\"\"";
            this.btnRechts.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 375);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnUnten);
            this.Controls.Add(this.btnHoch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSchlägerRechts);
            this.Controls.Add(this.vsbSchlägerRechts);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.namePunkte);
            this.Controls.Add(this.pnlSpiel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picBall);
            this.Name = "Form1";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.frmPingPong_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picSchlägerRechts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.PictureBox picSchlägerRechts;
        private System.Windows.Forms.VScrollBar vsbSchlägerRechts;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Label namePunkte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoch;
        private System.Windows.Forms.Button btnUnten;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnRechts;
    }
}