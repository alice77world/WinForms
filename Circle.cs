using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab
{
    class Circle : Figure
    {
        public override void Delete()
        {
          
        }

        public override PictureBox Draw(SolidBrush brush,Bitmap bmp,PictureBox picture, float startX, float startY)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, startX, startY, 50, 50);
            graph.FillEllipse(brush, startX, startY, 50, 50);
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
