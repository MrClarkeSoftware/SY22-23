using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace Game
{
    public class Canvas
    {
        public Form1 m_parent;
        public ArrayList objects = new ArrayList();

        public Canvas(Form1 parent)
        {
            m_parent = parent;
        }
        public void Add(Sprite s)
        {
            objects.Add(s);
            s.setParent(this);

        }
        public bool isClear(PictureBox P, int X, int Y)
        {
            if (!P.Visible)
                return true;

            foreach (var item in m_parent.Controls)
            {
                if (typeof(PictureBox) == item.GetType() && P != item && P.Visible)
                {
                    PictureBox other = (PictureBox)item;
                    Rectangle newRect = new Rectangle(P.Location.X + X, P.Location.Y + Y, P.Width, P.Height);
                    if (other.Bounds.IntersectsWith(newRect))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool moveTo(PictureBox P, int X, int Y)
        {
            bool retVal = true;
            if (!P.Visible)
                return true;

            foreach (var item in m_parent.Controls)
            {
                if (typeof(PictureBox) == item.GetType() && P != item && P.Visible)
                {
                    PictureBox other = (PictureBox)item;
                    Rectangle newRect = new Rectangle(P.Location.X + X, P.Location.Y + Y, P.Width, P.Height);
                    if (other.Bounds.IntersectsWith(newRect))
                    {
                        Sprite s = getSpriteByPictureBox(P);
                        if (s != null)
                            retVal = s.collision(other);
                        s = getSpriteByPictureBox(other);
                        if (s != null)
                            s.collision(P);
                        if (!retVal)
                            return retVal;
                    }
                }
            }
            return retVal;
        }
        public Sprite getSpriteByPictureBox(PictureBox p)
        {
            foreach (Sprite s in objects)
            {
                if (s.m_picture == p)
                    return s;
            }
            return null;
        }
        public Sprite getSpriteByName(String name)
        {
            foreach (Sprite s in objects)
            {
                if (s.m_picture.Name.ToUpper() == name.ToUpper())
                    return s;
            }
            return null;
        }
        public void tick()
        {
            foreach (Sprite item in objects)
            {
                item.tick();
            }
        }
    }
}
