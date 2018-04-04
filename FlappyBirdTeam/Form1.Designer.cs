namespace FlappyBirdTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pipeup1 = new System.Windows.Forms.PictureBox();
            this.pipeup2 = new System.Windows.Forms.PictureBox();
            this.pipedown2 = new System.Windows.Forms.PictureBox();
            this.pipedown1 = new System.Windows.Forms.PictureBox();
            this.FlyingBird = new System.Windows.Forms.PictureBox();
            this.lblHS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyingBird)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(183, 200);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 63);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(207, 40);
            this.lblScore.Margin = new System.Windows.Forms.Padding(0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(36, 37);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FlappyBirdTeam.Properties.Resources.pauseplay1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pipeup1
            // 
            this.pipeup1.BackColor = System.Drawing.Color.Transparent;
            this.pipeup1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeup1.BackgroundImage")));
            this.pipeup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeup1.Location = new System.Drawing.Point(325, -200);
            this.pipeup1.Name = "pipeup1";
            this.pipeup1.Size = new System.Drawing.Size(50, 500);
            this.pipeup1.TabIndex = 1;
            this.pipeup1.TabStop = false;
            // 
            // pipeup2
            // 
            this.pipeup2.BackColor = System.Drawing.Color.Transparent;
            this.pipeup2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeup2.BackgroundImage")));
            this.pipeup2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeup2.Location = new System.Drawing.Point(600, -300);
            this.pipeup2.Name = "pipeup2";
            this.pipeup2.Size = new System.Drawing.Size(50, 500);
            this.pipeup2.TabIndex = 1;
            this.pipeup2.TabStop = false;
            // 
            // pipedown2
            // 
            this.pipedown2.BackColor = System.Drawing.Color.Transparent;
            this.pipedown2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipedown2.BackgroundImage")));
            this.pipedown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipedown2.Location = new System.Drawing.Point(600, 50);
            this.pipedown2.Name = "pipedown2";
            this.pipedown2.Size = new System.Drawing.Size(50, 500);
            this.pipedown2.TabIndex = 1;
            this.pipedown2.TabStop = false;
            // 
            // pipedown1
            // 
            this.pipedown1.BackColor = System.Drawing.Color.Transparent;
            this.pipedown1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipedown1.BackgroundImage")));
            this.pipedown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipedown1.Location = new System.Drawing.Point(325, 450);
            this.pipedown1.Name = "pipedown1";
            this.pipedown1.Size = new System.Drawing.Size(50, 500);
            this.pipedown1.TabIndex = 1;
            this.pipedown1.TabStop = false;
            // 
            // FlyingBird
            // 
            this.FlyingBird.BackColor = System.Drawing.Color.Transparent;
            this.FlyingBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlyingBird.Location = new System.Drawing.Point(40, 200);
            this.FlyingBird.Name = "FlyingBird";
            this.FlyingBird.Size = new System.Drawing.Size(50, 40);
            this.FlyingBird.TabIndex = 0;
            this.FlyingBird.TabStop = false;
            // 
            // lblHS
            // 
            this.lblHS.BackColor = System.Drawing.Color.Transparent;
            this.lblHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHS.ForeColor = System.Drawing.Color.Red;
            this.lblHS.Location = new System.Drawing.Point(430, 462);
            this.lblHS.Margin = new System.Windows.Forms.Padding(0);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(45, 30);
            this.lblHS.TabIndex = 3;
            this.lblHS.Text = "0";
            this.lblHS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHS);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pipeup1);
            this.Controls.Add(this.pipeup2);
            this.Controls.Add(this.pipedown2);
            this.Controls.Add(this.pipedown1);
            this.Controls.Add(this.FlyingBird);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyingBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlyingBird;
        private System.Windows.Forms.PictureBox pipedown1;
        private System.Windows.Forms.PictureBox pipeup2;
        private System.Windows.Forms.PictureBox pipedown2;
        private System.Windows.Forms.PictureBox pipeup1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHS;
    }
}

