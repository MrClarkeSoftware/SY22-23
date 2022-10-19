using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private PictureBox CreatePicture(PictureBox pb, int row, int col)
        {
            PictureBox p = new PictureBox();
            p.Location = new Point(10 * row, 10 * col);
            p.Size = pictureBox1.Size;
            p.Size = pb.Size;
            p.BackColor = pb.BackColor;
            p.BorderStyle = pb.BorderStyle;
            p.Top = p.Location.Y;
            p.Left = p.Location.X;
            p.Width = pb.Width;
            p.Height = pb.Height;
            p.BackColor = pb.BackColor;
            p.SizeMode = pb.SizeMode;
            if (!(pb.Image == null))
                p.Image = pb.Image;
            p.Name = "Grid-" + row + "-" + col;
            Controls.Add(p);
            return p;
        }
        public PictureBox GetPicture(int row, int col)
        {
            if (row <= 40 && col <= 40)
                return (PictureBox) Controls["Grid-" + row + "-" + col];
            return pictureBox1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    CreatePicture(pictureBox1, i, j);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    GetPicture(i, j).BackColor = Color.Red;
                }
            }
        }
    }
}
