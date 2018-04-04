using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdTeam
{
    

    public partial class Info : Form
    {
        private String strSrcBackground = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\city.png";
        private String strSrcBird = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\dropbird2.png";
        private String strSrcDropBird = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\flybird2.png";
        infoctrl ctrl;
        public Info()
        {
            ctrl = new infoctrl();
            this.Controls.Add(ctrl);
            ctrl.Hide();
            InitializeComponent();
        }

        private void btnBird_Click(object sender, EventArgs e)
        {
            strSrcBird = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\dropbird2.png";
            strSrcDropBird = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\flybird2.png";

        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            strSrcBird = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\dogup.png";
            strSrcDropBird = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\dogdown.png";
        }

        private void btnOwl_Click(object sender, EventArgs e)
        {
            strSrcBird = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\owlup.png";
            strSrcDropBird = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\owldown1.png";
        }

        private void btnBGSky_Click(object sender, EventArgs e)
        {
            strSrcBackground = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\bg1.jpg";
        }

        private void btnBGCity_Click(object sender, EventArgs e)
        {
            strSrcBackground = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\city.png";
        }

        private void btnBGForest_Click(object sender, EventArgs e)
        {
            strSrcBackground = "E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\forest.png";
        }
        private void gameplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGameplay.Show();
            ctrl.Hide();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGameplay.Hide();
            ctrl.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Form1(strSrcBackground, strSrcBird, strSrcDropBird)).ShowDialog();
        }
    }
}
