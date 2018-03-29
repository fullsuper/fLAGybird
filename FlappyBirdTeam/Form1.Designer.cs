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
            this.FlyingBird = new System.Windows.Forms.PictureBox();
            this.pipedown1 = new System.Windows.Forms.PictureBox();
            this.pipeup2 = new System.Windows.Forms.PictureBox();
            this.pipedown2 = new System.Windows.Forms.PictureBox();
            this.pipeup1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlyingBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlyingBird
            // 
            this.FlyingBird.BackColor = System.Drawing.Color.Transparent;
            this.FlyingBird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlyingBird.BackgroundImage")));
            this.FlyingBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlyingBird.Location = new System.Drawing.Point(40, 200);
            this.FlyingBird.Name = "FlyingBird";
            this.FlyingBird.Size = new System.Drawing.Size(50, 40);
            this.FlyingBird.TabIndex = 0;
            this.FlyingBird.TabStop = false;
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
            // pipeup2
            // 
            this.pipeup2.BackColor = System.Drawing.Color.Transparent;
            this.pipeup2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeup2.BackgroundImage")));
            this.pipeup2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeup2.Location = new System.Drawing.Point(800, -300);
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
            this.pipedown2.Location = new System.Drawing.Point(800, 350);
            this.pipedown2.Name = "pipedown2";
            this.pipedown2.Size = new System.Drawing.Size(50, 500);
            this.pipedown2.TabIndex = 1;
            this.pipedown2.TabStop = false;
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(214, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 63);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pipeup1);
            this.Controls.Add(this.pipeup2);
            this.Controls.Add(this.pipedown2);
            this.Controls.Add(this.pipedown1);
            this.Controls.Add(this.FlyingBird);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.FlyingBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FlyingBird;
        private System.Windows.Forms.PictureBox pipedown1;
        private System.Windows.Forms.PictureBox pipeup2;
        private System.Windows.Forms.PictureBox pipedown2;
        private System.Windows.Forms.PictureBox pipeup1;
        private System.Windows.Forms.Button btnStart;
    }
}

