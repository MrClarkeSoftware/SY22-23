using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
            // We collided, so let's figure out which way we should "bounce"
            // Clear
            GetForm1().Controls["Label1"].Text = m_picture.Name + " collided with " + other.Name;
            if (m_xdir != 0)
                m_xdir *= -1; 
            else
                m_ydir *= -1;
            
            return false; // bounce
        }
        public override void tick()
        {
            //move one direction at a time to figure out our direction for the bounce
            int tmpX = m_xdir;
            m_xdir = 0;
            move(0, m_ydir);
            m_xdir = tmpX;
        
            int tmpY = m_ydir;
            m_ydir = 0;
            move(m_xdir,0);
            m_ydir = tmpY;
        }
    }
}
