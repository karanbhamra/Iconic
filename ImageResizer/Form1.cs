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
            this.BackColor = Color.White;
            label1.ForeColor = Color.Red;
            label1.Text = "No file selected.";
            button1.Enabled = false;
            label1.AutoEllipsis = true;
            label1.MaximumSize = new Size(550, 0);
            //button1.ForeColor = Color.Green;
            //button1.BackColor = Color.Orange;
            button2.BackColor = Color.LightSeaGreen;

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
                label1.Text = "File: " + openFileDialog.FileName + " is selected.";
                label1.ForeColor = Color.Green;
                Image image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = image;
                button1.Enabled = true;
                button1.BackColor = Color.Orange;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
