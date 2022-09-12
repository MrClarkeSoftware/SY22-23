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
        Sprite p1;
        Chaser p2;
        public ArrayList objects = new ArrayList();
        public Form1()
        {

            InitializeComponent();
            p1 = new Sprite(player, this);
            p2 = new Chaser(player2, this);
            objects.Add(p1);
            objects.Add(p2);
        }
        public bool isClear(PictureBox P, int X, int Y)
        {
            foreach (var item in Controls)
            {
                if (typeof(PictureBox) == item.GetType() && P != item)
                {
                    PictureBox other = (PictureBox)item;
                    Rectangle newRect = new Rectangle(P.Location.X + X, P.Location.Y + Y, P.Width, P.Height);
                    if (other.Bounds.IntersectsWith(newRect))
                    {
                        Sprite s = getSprite(P);
                        if (s != null)
                            s.collision(getSprite(other));

                        return false;
                    }
                }
            }
            return true;
        }
        public Sprite getSprite(PictureBox p)
        {
            foreach (Sprite s in objects)
            {
                if (s.m_picture == p)
                    return s;
            }
            return null;
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

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;
            foreach (Sprite item in objects)
            {
                item.tick();
            }

        }


    }

}
