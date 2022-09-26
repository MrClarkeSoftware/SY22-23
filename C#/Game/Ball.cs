using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal class Ball : Sprite
    {
        int m_xdir = 0;
        int m_ydir = 0;
        public Ball(PictureBox picture, int xdir, int ydir) : base(picture)
        {
            m_xdir = xdir;
            m_ydir = ydir;
        }
        public override bool collision(PictureBox other)
        {
            Debug.Print(m_picture.Name + " collided with " + other.Name);
            // We collided, so if x isn't clear change x direction
            if (!m_parent.isClear(m_picture,m_picture.Location.X + m_xdir, m_picture.Location.Y))
                m_xdir *= -1;
            else  // otherwise change y direction
                m_ydir *= -1;
            return false; // don't go through items
        }
        public override void tick()
        {
            move(m_xdir, m_ydir);
        }
    }
}
