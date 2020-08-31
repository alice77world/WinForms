using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsLab
{
    class Rectangle : Figure
    {
        public override void Delete()
        {
           
        }

        public override PictureBox Draw(SolidBrush brush,Bitmap bmp,PictureBox picture, float startX, float startY)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawRectangle(pen, startX, startY, 70, 50);
            graph.FillRectangle(brush, startX, startY, 70, 50);
            picture.Image = bmp;
            return picture;
        }

        public override void Move()
        {
            
        }

        public override void PickOut()
        {
           
        }
    }
}
