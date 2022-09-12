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
        public void tick()
        {
            movedown();
        }
        public void collision(Sprite other)
        {

        }
        public void moveleft()
        {
            if (!m_parent.isClear(m_picture, -m_speed, 0))
                return;
            m_location = new Point(m_location.X - m_speed, m_location.Y);
            m_picture.Location = m_location;
        }
        public void moveright()
        {
            if (!m_parent.isClear(m_picture, +m_speed, 0))
                return;
            m_location = new Point(m_location.X + m_speed, m_location.Y);
            m_picture.Location = m_location;
        }
        public void moveup()
        {
            if (!m_parent.isClear(m_picture, 0, -m_speed))
                return;
            m_location = new Point(m_location.X, m_location.Y - m_speed);
            m_picture.Location = m_location;
        }
        public void movedown()
        {
            if (!m_parent.isClear(m_picture, 0, +m_speed))
                return;
            m_location = new Point(m_location.X, m_location.Y + m_speed);
            m_picture.Location = m_location;
        }
    }

}
