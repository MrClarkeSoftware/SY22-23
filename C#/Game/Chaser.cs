using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    class Chaser : Sprite
    {
        public Chaser(PictureBox picture, Form1 parent) : base(picture, parent)
        {

        }
        public override void tick()
        {
            int xdir = 0;
            int ydir = 0;

            foreach (var item in m_parent.objects)
            {
                if (typeof(Sprite) == item.GetType() && this != item)
                {
                    Sprite other = (Sprite)item;
                    if (other.m_picture.Name == "player")
                    {
                        if (other.m_location.X < this.m_location.X)
                            xdir = -5;
                        else
                            xdir = 5;
                        if (other.m_location.Y < this.m_location.Y)
                            ydir = -5;
                        else
                            ydir = 5;
                    }
                }
            }
            move(xdir, ydir);

        }
    }
}
