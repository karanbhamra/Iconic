using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.Red;
            label1.Text = "No file selected.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            DialogResult dr;
            dr = openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //Console.WriteLine("TEST");
                label1.Text = openFileDialog.FileName + " selected.";
                label1.ForeColor = Color.Green;
                Image image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = image;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
