using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsLab
{
    class Triangle : Figure
    {
        public override void Delete()
        {
           
        }

        public override PictureBox Draw(SolidBrush brush,Bitmap bmp,PictureBox picture, float startX, float startY)
        {
            
            PointF point1 = new PointF(startX, startY);
            PointF point2 = new PointF(startX, startY+80);
            PointF point3 = new PointF(startX+80, startY+80);
            PointF[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
             };
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawPolygon(pen,curvePoints);
            graph.FillPolygon(brush, curvePoints);
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
