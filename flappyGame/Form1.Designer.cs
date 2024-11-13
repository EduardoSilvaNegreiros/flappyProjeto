namespace flappyGame
{
    partial class score1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeDow = new System.Windows.Forms.PictureBox();
            this.pipeU = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = global::flappyGame.Properties.Resources.pngwing_com__1_;
            this.bird.Location = new System.Drawing.Point(94, 182);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(87, 68);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeDow
            // 
            this.pipeDow.Image = global::flappyGame.Properties.Resources.pngwing_com__2_;
            this.pipeDow.Location = new System.Drawing.Point(340, 243);
            this.pipeDow.Name = "pipeDow";
            this.pipeDow.Size = new System.Drawing.Size(100, 151);
            this.pipeDow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDow.TabIndex = 1;
            this.pipeDow.TabStop = false;
            this.pipeDow.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pipeU
            // 
            this.pipeU.Image = global::flappyGame.Properties.Resources.pngwing_com__2_;
            this.pipeU.Location = new System.Drawing.Point(561, -33);
            this.pipeU.Name = "pipeU";
            this.pipeU.Size = new System.Drawing.Size(100, 178);
            this.pipeU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeU.TabIndex = 2;
            this.pipeU.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::flappyGame.Properties.Resources.pngwing_com__4_;
            this.ground.Location = new System.Drawing.Point(-4, 368);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(803, 88);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(31, 31);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(63, 21);
            this.scoreLbl.TabIndex = 4;
            this.scoreLbl.Text = "Score:";
            this.scoreLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // score1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeU);
            this.Controls.Add(this.pipeDow);
            this.Controls.Add(this.bird);
            this.Name = "score1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            this.Move += new System.EventHandler(this.GameTimerEvent);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeDow;
        private System.Windows.Forms.PictureBox pipeU;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label scoreLbl;
    }
}

