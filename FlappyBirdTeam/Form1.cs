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

        int x_first = 300;
        int x_second = 600;

        int y_first = -200;
        int y_second = -300;

        int x_bird = 40;
        int y_bird = 200;
        Timer tmRunPipe,tmDropBird;

        Random rd;
        bool isFlying = true;

        #endregion



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space || e.KeyCode == Keys.Space)
            {
                y_bird -= 50;
                FlyingBird.Location = new Point(x_bird, y_bird);
                FlyingBird.BackgroundImage = Image.FromFile("E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\dropbird2.png");
                isFlying = true;
            }
        }


        public Form1()
        {
            InitializeComponent();
            //this.DoubleBuffered = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          //  btnStart.Hide();
            btnStart.Dispose();

            tmRunPipe = new Timer();
            tmRunPipe.Start();
            
            tmRunPipe.Tick += TmRunPipe_Tick;
            tmRunPipe.Interval = 10;

            tmDropBird = new Timer();
            tmDropBird.Tick += TmDropBird_Tick;
            tmDropBird.Interval = 100;
            tmDropBird.Start();
        }

        private void TmDropBird_Tick(object sender, EventArgs e)
        {
            y_bird+=10;
            FlyingBird.Location = new Point(x_bird,y_bird);
        }

        private void TmRunPipe_Tick(object sender, EventArgs e)
        {
            x_first -= 2;
            x_second -= 2;
            pipeup1.Location = new Point(x_first, y_first);
            pipeup2.Location = new Point(x_second, y_second );
            pipedown1.Location = new Point(x_first,y_first +600);
            pipedown2.Location = new Point(x_second, y_second+600);
            if (isFlying)
            {
                FlyingBird.BackgroundImage = Image.FromFile("E:\\VS\\FlappyBirdTeam\\FlappyBirdTeam\\Image\\flybird2.png");
                isFlying = false;
            }
            Reload();
        }
        public void Reload()
        {
            if (isGameOver())
            {
                tmRunPipe.Stop();
                tmDropBird.Stop();
                MessageBox.Show("Gem au vờ");
            }
            //random khe
            if (x_first <= -50)
            {
                rd = new Random();
                y_first = -500 + rd.Next(150,350);
                x_first = 600;
                pipeup1.Location = new Point(600, y_first);
                pipedown1.Location = new Point(600, y_first + 600);
            }
            if (x_second <= -50)
            {
                rd = new Random();
                y_second = -500 + rd.Next(150,350);
                x_second = 600;
                pipeup2.Location = new Point(600, y_second);
                pipedown2.Location = new Point(600, y_second + 600);
                
            }
            

        }


        public bool isGameOver()
        {
            if (x_first > x_bird && x_first < x_bird + 50)
                if (y_bird < y_first + 500 || y_bird + 40 > y_first + 600)
                    return true;
            if (x_second > x_bird && x_second < x_bird + 50)
                if (y_bird < y_second + 500 || y_bird + 40 > y_second + 600)
                    return true;
            if (y_bird > 420 || y_bird < 0)
                return true;
            return false;
        }

    }
}
