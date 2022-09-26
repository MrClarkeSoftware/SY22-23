using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Game
{
    public partial class Form1 : Form
    {
        public Canvas c = null;
        Sprite p1;
        Chaser p2;
        Ball b1;

        public Form1()
        {

            InitializeComponent();
            c = new Canvas(this);
            p1 = new Sprite(player);
            p2 = new Chaser(player2);
            b1 = new Ball(Ballpicture, 5, 5);
            c.Add(p1);
           // c.Add(p2);
            c.Add(b1);
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Shift && progressBar1.Value > 2)
            {
                p1.m_speed = 10;
                progressBar1.Value--;
            }


            if (e.KeyCode == Keys.Left)
            {
                p1.moveleft();
            }
            if (e.KeyCode == Keys.Right)
            {
                p1.moveright();
            }
            if (e.KeyCode == Keys.Up)
            {
                p1.moveup();
            }
            if (e.KeyCode == Keys.Down)
            {
                p1.movedown();
            }
            if (e.KeyCode == Keys.A)
            {
                p2.moveleft();
            }
            if (e.KeyCode == Keys.D)
            {
                p2.moveright();
            }
            if (e.KeyCode == Keys.W)
            {
                p2.moveup();
            }
            if (e.KeyCode == Keys.S)
            {
                p2.movedown();
            }
            if (e.KeyCode == Keys.Space)
            {
                PictureBox p = new PictureBox();
                p.Location = player.Location;
                p.Width = Ballpicture.Width;
                p.Size = Ballpicture.Size;
                p.BackColor = Ballpicture.BackColor;
                p.Top = player.Location.X;
                p.Left = player.Location.Y;
                p.Width = Ballpicture.Width;
                p.Height = Ballpicture.Height;
                p.BackColor = Ballpicture.BackColor;
                p.SizeMode = Ballpicture.SizeMode;
                if (Ballpicture.Image != null)
                    p.Image = Ballpicture.Image;
                p.Name = Ballpicture.Name;
                p.Visible = true;
                Controls.Add(p);
                c.Add(new Sprite(p));
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;
            // let the canvas do all the work
            c.tick();
        }


    }

}
