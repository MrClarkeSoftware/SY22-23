using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Game
{
    public class Sprite
    {
        public PictureBox m_picture;
        public Point m_location;
        public int m_speed = 5;
        public Canvas m_parent;
        public Sprite(PictureBox picture)
        {
            m_picture = picture;
            m_location = picture.Location;
            
        }
        public void setParent(Canvas parent)
        {
            m_parent = parent;
        }
        public Form1 GetForm1() { return m_parent.m_parent; }
        public virtual void tick()
        {
            movedown();
        }
        virtual public bool collision(PictureBox other)
        {
            Debug.Print(m_picture.Name + " collided with " + other.Name);
            return false;//  don't go through stuff
        }
        public void move(int X, int Y)
        {
            if (!m_parent.moveTo(m_picture, m_speed * X, m_speed * Y))
               return;
            m_location = new Point(m_location.X + m_speed * X, m_location.Y + m_speed * Y);
            m_picture.Location = m_location;

        }
        public void moveleft()
        {
            move(-1, 0);
        }
        public void moveright()
        {
            move(1, 0);
        }
        public void moveup()
        {
            move(0, -1);
        }
        public void movedown()
        {
            move(0, 1);
        }
    }

}
