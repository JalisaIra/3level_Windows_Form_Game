using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eraa_s_Fairy_Land
{
    public partial class GameWindows : Form
    {
        bool goUp, goDown, shot, gameOver;

        int collect = 0;
        int speed = 8;
        int Butterflyspeed = 10;
        //public int collect { get; set; }


        Random rand = new Random();

        int playerSpeed = 7;
        int index = 0;
        public GameWindows()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtCollect.Text = "Collect: " + collect;

            if (goUp == true && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }

            butterfly.Left -= Butterflyspeed;

            if (butterfly.Left + butterfly.Width < 0)
            {
                ChangeButterfly();
            }
            foreach(Control y in this.Controls)
            {
                if(y is PictureBox && (string)y.Tag=="GoodTree")
                {
                    y.Left -= speed;
                    if(y.Left < -200)
                    {
                        y.Left = 1200;
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Boundary")
                {
                    x.Left -= speed;


                    if (x.Left < -200)
                    {
                        x.Left = 1200;
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                         GameOver();
                       
                    }

                }

                if (x is PictureBox && (string)x.Tag == "spell")
                {
                    x.Left += 25;

                    if (x.Left > 1150)
                    {
                        RemoveSpell(((PictureBox)x));
                    }


                    if (butterfly.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveSpell(((PictureBox)x));
                        collect += 1;
                        ChangeButterfly();
                    }

                }
            }

        }

            private void KeyIsDown(object sender, KeyEventArgs e)
            {

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Space && shot == false)
            {
                MakeSpell();
                shot = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (shot == true)
            {
                shot = false;
            }

           /* if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                //RestartGame();
                EndBox end = new EndBox();
                end.Show();
                end.Era(collect);
                
            }*/

        }

        private void RestartGame()
        {
            goUp = false;
            goDown = false;
            shot = false;
            gameOver = false;
            collect = 0;
            speed = 8;
            Butterflyspeed = 10;

            txtCollect.Text = "Collect: " + collect;

            ChangeButterfly();

            player.Top = 169;

            HappyTree.Left = 446;
            Cloud.Left = 659;
            GoodTree1.Left = 3;
            GoodTree2.Left = 933;


            GameTimer.Start();


        }
        private void GameOver()
        {
            GameTimer.Stop();
        
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                EndBox end = new EndBox();
                end.Show();
                end.Era(collect);
            }
            else
            {
                RestartGame();
            }
            txtCollect.Text = "Collect: " + collect + " Game over, Press Enter";
            gameOver = true;
           

        }

        private void GoodTree2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveSpell(PictureBox spell)
        {
            this.Controls.Remove(spell);
            spell.Dispose();

        }
        private void MakeSpell()
        {
            PictureBox spell = new PictureBox();
            spell.BackColor = Color.GreenYellow;
            spell.Height = 10;
            spell.Width = 10;

            spell.Left = player.Left + player.Width;
            spell.Top = player.Top + player.Height / 2;

            spell.Tag = "spell";

            this.Controls.Add(spell);

        }
        private void ChangeButterfly()
        {

            if (index > 4)
            {
                index = 1;
            }
            else
            {
                index += 1;
            }


            switch (index)
            {
                case 1:
                    butterfly.Image = Properties.Resources._03;
                    break;
                case 2:
                    butterfly.Image = Properties.Resources._05;
                    break;
                case 3:
                    butterfly.Image = Properties.Resources._09;
                    break;
                case 4:
                    butterfly.Image=Properties.Resources._07; 
                    break;

            }

            butterfly.Left = 1200;

            butterfly.Top = rand.Next(10, this.ClientSize.Height - butterfly.Height);

        }

    }
 }

