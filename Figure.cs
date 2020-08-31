using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsLab
{
    abstract class Figure
    {
        public float startX { get; set; }
        public float startY { get; set; }
        public abstract PictureBox Draw(SolidBrush brush,Bitmap bmp, PictureBox picture, float startX, float startY);
        public abstract void Move();
        public abstract void Delete();
        public abstract void PickOut();
    }
}
