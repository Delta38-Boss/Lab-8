using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Crypt;
using MessagingToolkit.QRCode.Codec.Data;

namespace WindowsFormsApp3
{
	public partial class Task2 : Form
	{
		public Task2()
		{
			InitializeComponent();
		}

		private void Task2_Load(object sender, EventArgs e)
		{ 
			 
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string qrtext = textBox1.Text; 
			QRCodeEncoder encoder = new QRCodeEncoder(); 
			Bitmap qrcode = encoder.Encode(qrtext); 
			pictureBox1.Image = qrcode as Image;
		}

		private void Task2_Click(object sender, EventArgs e)
		{
			
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "PNG|*.png|JPEG|*.jpg";
			if (save.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image.Save(save.FileName);
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog load = new OpenFileDialog();
			load.Filter = "PNG|*.png|JPEG|*.jpg";
			if (load.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.ImageLocation = load.FileName;
				QRCodeDecoder decoder = new QRCodeDecoder();
				try
				{
					textBox1.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ошибка считывания! \n" + ex, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
