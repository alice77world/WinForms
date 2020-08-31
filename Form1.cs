using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab
{
    public partial class Form1 : Form
    {
        public string shape = "triangle";
        SolidBrush brush = new SolidBrush(Color.Red);
        public Form1()
        {

            InitializeComponent();
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            picture.MouseDown += new MouseEventHandler(picture_MouseClick);
            comboBoxShape.Items.AddRange(new string[] { "circle", "square", "triangle" });
            comboBoxShape.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBoxColor.Items.AddRange(new string[] { "Red", "Green", "Blue","Yellow" });
            comboBoxColor.SelectedIndexChanged += comboBoxColor_SelectedIndexChanged;


            void picture_MouseClick(object sender, MouseEventArgs e)
            {
                float CursorX = Cursor.Position.X;
                float CursorY = Cursor.Position.Y;
                if (e.Button == MouseButtons.Left)
                {
                    
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if(shape == "triangle")
                    {
                        Triangle tr1 = new Triangle();
                        picture = tr1.Draw(brush,bmp, picture, CursorX, CursorY);
                        
                    }
                    else if (shape == "square")
                    {
                        Rectangle rect1 = new Rectangle();
                        picture = rect1.Draw(brush,bmp, picture, CursorX, CursorY);
                    }
                    else
                    {
                        Circle c1 = new Circle();
                        picture = c1.Draw(brush,bmp, picture, CursorX, CursorY);
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = comboBoxShape.SelectedItem.ToString();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBoxColor.SelectedItem.ToString();
            if(color=="Green")
            { brush = new SolidBrush(Color.Green); }
            else if (color == "Blue")
            { brush = new SolidBrush(Color.Blue); }
            else if (color == "Yellow")
            { brush = new SolidBrush(Color.Yellow); }
            else
            { brush = new SolidBrush(Color.Red); }
        }
    }
}
