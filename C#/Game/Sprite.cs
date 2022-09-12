using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Game
{
    public class Sprite
    {
        public PictureBox m_picture;
        public Point m_location;
        public int m_speed = 5;
        public Form1 m_parent;
        public Sprite(PictureBox picture, Form1 parent)
        {
            m_picture = picture;
            m_location = picture.Location;
            m_parent = parent;
        }
        public virtual void tick()
        {
            movedown();
        }
        public void collision(Sprite other)
        {

        }
        public void move(int X, int Y)
        {
            if (!m_parent.isClear(m_picture, m_speed * X, m_speed * Y))
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
