using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWar2
{
    public partial class Form1 : Form
    {
        int EnemySpeed = 3;
        int movesides = 5;
        int bulletspeed = 5;
        int CountCoins = 0;
        bool GoRight, GoLeft;
        bool bulletActivation = false;
        bool bulletlevelup = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimer(object sender, EventArgs e)
        {
            if (bulletlevelup == false)
                bulletLevel1.Visible = false;
            enemy(EnemySpeed);
            movement(movesides);
            bullet(bulletspeed);
            coins();
            gameover();
        }
        private void enemy(int y)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "ball")
                    {
                        int one = random.Next(0, 780);
                        x.Top += y;
                        if (x.Top > this.Height - x.Height)
                        {
                            x.Location = new Point(one, 0);
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Jet.Left > 0)
                    GoLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Jet.Left < this.Width - Jet.Width)
                    GoRight = true;
            }
            if (e.KeyCode == Keys.Space) bulletActivation = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) GoLeft = false;
            if (e.KeyCode == Keys.Right) GoRight = false;
            if (e.KeyCode == Keys.Space) bulletActivation = false;

        }

        private void movement(int x)
        {
            if (GoLeft) Jet.Left += -x;
            if (GoRight) Jet.Left += x;
        }
        private void bullet(int speed)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "bullet")
                    {
                        x.Top += -speed;
                        if (bulletActivation)
                        {
                            bullet1.Location = new Point(Jet.Left, Jet.Top);
                            bullet2.Location = new Point(Jet.Left + Jet.Width - 20, Jet.Top);
                            if (bulletlevelup)
                            {
                                bulletLevel1.Location = new Point(Jet.Left + 30, Jet.Top - 20);
                                bulletLevel1.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void SecondTimer(object sender, EventArgs e)
        {
            gift(EnemySpeed);
        }
        private void gift(int x)
        {
            int one = random.Next(0, 780);
            giftBox.Top += x;
            if (giftBox.Top > this.Height - giftBox.Height) giftBox.Location = new Point(one, 0);
            if (giftBox.Bounds.IntersectsWith(Jet.Bounds))
            {
                giftBox.Visible = false;
                bulletlevelup = true;
            }
        }
        private void coins()
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                {
                    if ((string)item.Tag == "ball")
                    {
                        foreach (Control y in this.Controls)
                        {
                            if (y is PictureBox)
                            {
                                if ((string)y.Tag == "bullet")
                                {
                                    if (item.Bounds.IntersectsWith(y.Bounds))
                                    {
                                        int one = random.Next(0, 780);
                                        item.Location = new Point(one, 0);
                                        bulletActivation = false;
                                        CountCoins += 1;
                                        label1.Text = ("Coin: " + CountCoins);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restartgame();

        }

        private void gameover()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "ball")
                    {
                        if (x.Bounds.IntersectsWith(Jet.Bounds))
                        {
                            timer1.Enabled = false;
                            timer2.Enabled = false;
                            groupBox1.Visible = true;
                        }
                    }
                }
            }
        }
        private void restartgame()
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            groupBox1.Visible = false;
            CountCoins = 0;
            Jet.Location = new Point(331, 413);
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "ball")
                    {
                        int one = random.Next(0, 780);
                        x.Location = new Point(one, 0);
                    }
                }
            }
        }
    }
}
