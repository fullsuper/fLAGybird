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
    public partial class Form1 : Form
    {

        #region  

        Timer tmRunPipe,tmDropBird;

        Random rd;
        int score = 0;
        int stepDrop = 0;

        string imgflyingbird;
        string imgdroppingbird;
        bool isPause = false;
        int highscore = 0;
        #endregion


        public Form1(string background, string bird, string drop)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display the form as a modal dialog box.
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackgroundImage = Image.FromFile(background);
            imgflyingbird = bird;
            imgdroppingbird = drop;
            FlyingBird.BackgroundImage = Image.FromFile(bird);
        }

        private void loadNewGame()
        {
            pipeup1.Left = pipedown1.Left = 300;
            pipeup2.Left = pipedown2.Left = 600;

            pipeup1.Top = -200;
            pipedown1.Top = pipeup1.Bottom + 100;
            pipeup2.Top = -300;
            pipedown2.Top = pipeup2.Bottom + 100;

            FlyingBird.Top = 200;
            score = 0;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                stepDrop = 0;
                FlyingBird.Top -= 50;
                FlyingBird.BackgroundImage = Image.FromFile(imgflyingbird);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          //  btnStart.Hide();
            btnStart.Dispose();
            loadNewGame();
            tmRunPipe = new Timer();
            tmRunPipe.Start();
            lblScore.Text = "0";
            score = 0;

            
            tmRunPipe.Tick += TmRunPipe_Tick;
            tmRunPipe.Interval = 5;

            tmDropBird = new Timer();
            tmDropBird.Tick += TmDropBird_Tick;
            tmDropBird.Interval = 60;
            tmDropBird.Start();
            
        }

        private void TmDropBird_Tick(object sender, EventArgs e)
        {
            stepDrop++;
            FlyingBird.Top += 10;
        }

        private void TmRunPipe_Tick(object sender, EventArgs e)
        {

            pipeup1.Left-=4;
            pipeup2.Left -= 4;
            pipedown1.Left -= 4;
            pipedown2.Left -= 4;

            if(pipeup1.Right <= FlyingBird.Left || pipeup2.Right <= FlyingBird.Left)
            {
                score++;
                lblScore.Text = (score/11).ToString();
            }
            if (stepDrop == 3)
            {
                FlyingBird.BackgroundImage = Image.FromFile(imgdroppingbird);
            }
            Reload();
        }
        public void Reload()
        {
            if (isGameOver())
            {
                if (highscore < score)
                {
                    highscore = score;
                    lblHS.Text = lblScore.Text;
                    
                }
                tmRunPipe.Stop();
                tmDropBird.Stop();
                btnStart = new Button()
                {
                    Location = new Point(214, 209),
                    Width = 100,
                    Height = 60,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = Image.FromFile("E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\playbutton.png")
                };
                this.Controls.Add(btnStart);
                btnStart.Click += btnStart_Click;
                MessageBox.Show("Gem au vờ");
            }
            //random khe
            if (pipeup1.Right <= 0)
            {
                rd = new Random();
                int num = rd.Next(-380, -180);
                pipeup1.Left = pipeup2.Right+250;
                pipeup1.Top = num;
                pipedown1.Left = pipeup2.Right + 250;
                pipedown1.Top = num +600;
            }
            if (pipeup2.Right <= 0)
            {
                rd = new Random();
                int num = rd.Next(-380, -180);
                pipeup2.Left = pipeup1.Right + 250;
                pipeup2.Top = num;
                pipedown2.Left = pipeup1.Right + 250;
                pipedown2.Top = num + 600;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!isPause)
            {
                tmDropBird.Stop();
                tmRunPipe.Stop();
            }
            else
            {
                tmDropBird.Start();
                tmRunPipe.Start();
            }
            isPause = !isPause;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.gameplay.Show();
        }

        public bool isGameOver()
        {
            
            if ((pipedown1.Left +4 < FlyingBird.Left && pipedown1.Right -4 > FlyingBird.Left)|| (pipedown1.Left +4 < FlyingBird.Right && pipedown1.Right -4 > FlyingBird.Right))
                if (FlyingBird.Top+5 < pipeup1.Bottom || FlyingBird.Bottom-5 > pipedown1.Top)
                    return true;
            if ((pipedown2.Left + 4 < FlyingBird.Left && pipedown2.Right -4 > FlyingBird.Left) || (pipedown2.Left +4< FlyingBird.Right && pipedown2.Right - 4 > FlyingBird.Right))
                if (FlyingBird.Top +5 < pipeup2.Bottom || FlyingBird.Bottom-5 > pipedown2.Top)
                    return true;
            if (FlyingBird.Top <= 0 || FlyingBird.Bottom >= 500)
                return true;
            return false;
        }

    }
}
