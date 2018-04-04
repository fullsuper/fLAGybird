namespace FlappyBirdTeam
{
    partial class Info
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGameplay = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBGForest = new System.Windows.Forms.Button();
            this.btnBGCity = new System.Windows.Forms.Button();
            this.btnBGSky = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnOwl = new System.Windows.Forms.Button();
            this.btnBird = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlGameplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameplayToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameplayToolStripMenuItem
            // 
            this.gameplayToolStripMenuItem.Name = "gameplayToolStripMenuItem";
            this.gameplayToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.gameplayToolStripMenuItem.Text = "Gameplay";
            this.gameplayToolStripMenuItem.Click += new System.EventHandler(this.gameplayToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // pnlGameplay
            // 
            this.pnlGameplay.Controls.Add(this.pictureBox1);
            this.pnlGameplay.Controls.Add(this.btnBGForest);
            this.pnlGameplay.Controls.Add(this.btnBGCity);
            this.pnlGameplay.Controls.Add(this.btnBGSky);
            this.pnlGameplay.Controls.Add(this.btnDog);
            this.pnlGameplay.Controls.Add(this.btnOwl);
            this.pnlGameplay.Controls.Add(this.btnBird);
            this.pnlGameplay.Location = new System.Drawing.Point(6, 35);
            this.pnlGameplay.Name = "pnlGameplay";
            this.pnlGameplay.Size = new System.Drawing.Size(406, 379);
            this.pnlGameplay.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FlappyBirdTeam.Properties.Resources.playbutton;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(120, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 87);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBGForest
            // 
            this.btnBGForest.BackgroundImage = global::FlappyBirdTeam.Properties.Resources.forest;
            this.btnBGForest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBGForest.Location = new System.Drawing.Point(275, 215);
            this.btnBGForest.Name = "btnBGForest";
            this.btnBGForest.Size = new System.Drawing.Size(110, 150);
            this.btnBGForest.TabIndex = 10;
            this.btnBGForest.UseVisualStyleBackColor = true;
            this.btnBGForest.Click += new System.EventHandler(this.btnBGForest_Click);
            // 
            // btnBGCity
            // 
            this.btnBGCity.BackgroundImage = global::FlappyBirdTeam.Properties.Resources.city;
            this.btnBGCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBGCity.Location = new System.Drawing.Point(154, 215);
            this.btnBGCity.Name = "btnBGCity";
            this.btnBGCity.Size = new System.Drawing.Size(110, 150);
            this.btnBGCity.TabIndex = 11;
            this.btnBGCity.UseVisualStyleBackColor = true;
            this.btnBGCity.Click += new System.EventHandler(this.btnBGCity_Click);
            // 
            // btnBGSky
            // 
            this.btnBGSky.BackgroundImage = global::FlappyBirdTeam.Properties.Resources.bg1;
            this.btnBGSky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBGSky.Location = new System.Drawing.Point(28, 215);
            this.btnBGSky.Name = "btnBGSky";
            this.btnBGSky.Size = new System.Drawing.Size(110, 150);
            this.btnBGSky.TabIndex = 12;
            this.btnBGSky.UseVisualStyleBackColor = true;
            this.btnBGSky.Click += new System.EventHandler(this.btnBGSky_Click);
            // 
            // btnDog
            // 
            this.btnDog.BackColor = System.Drawing.Color.Transparent;
            this.btnDog.BackgroundImage = global::FlappyBirdTeam.Properties.Resources.dogup;
            this.btnDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDog.FlatAppearance.BorderSize = 0;
            this.btnDog.Location = new System.Drawing.Point(285, 13);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(100, 80);
            this.btnDog.TabIndex = 7;
            this.btnDog.UseVisualStyleBackColor = false;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnOwl
            // 
            this.btnOwl.BackColor = System.Drawing.Color.Transparent;
            this.btnOwl.BackgroundImage = global::FlappyBirdTeam.Properties.Resources.owlup;
            this.btnOwl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOwl.FlatAppearance.BorderSize = 0;
            this.btnOwl.Location = new System.Drawing.Point(157, 13);
            this.btnOwl.Name = "btnOwl";
            this.btnOwl.Size = new System.Drawing.Size(100, 80);
            this.btnOwl.TabIndex = 8;
            this.btnOwl.UseVisualStyleBackColor = false;
            this.btnOwl.Click += new System.EventHandler(this.btnOwl_Click);
            // 
            // btnBird
            // 
            this.btnBird.BackColor = System.Drawing.Color.Transparent;
            this.btnBird.BackgroundImage = global::FlappyBirdTeam.Properties.Resources.bird;
            this.btnBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBird.FlatAppearance.BorderSize = 0;
            this.btnBird.Location = new System.Drawing.Point(28, 13);
            this.btnBird.Name = "btnBird";
            this.btnBird.Size = new System.Drawing.Size(100, 80);
            this.btnBird.TabIndex = 9;
            this.btnBird.UseVisualStyleBackColor = false;
            this.btnBird.Click += new System.EventHandler(this.btnBird_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(418, 418);
            this.Controls.Add(this.pnlGameplay);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGameplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button btnBird;
        private System.Windows.Forms.Button btnOwl;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnBGSky;
        private System.Windows.Forms.Button btnBGCity;
        private System.Windows.Forms.Button btnBGForest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlGameplay;
    }
}