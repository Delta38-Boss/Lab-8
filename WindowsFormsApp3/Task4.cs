using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApp3
{
	public partial class Task4 : Form
	{

		private string key;

		public Task4()
		{
			InitializeComponent();
		}

		private void Task4_Load(object sender, EventArgs e)
		{

		}

		private void EncryptFile(string source, string destination, string key)
		{
			FileStream fsInput = new FileStream(source, FileMode.Open, FileAccess.Read);
			FileStream fsEncrypted = new FileStream(destination, FileMode.Create, FileAccess.Write);
			DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
			try
			{
				DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
				DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
				ICryptoTransform desencrypt = DES.CreateEncryptor();
				CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
				byte[] bytearrayinput = new byte[fsInput.Length - 0];
				fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
				cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
				cryptostream.Close();
			}

			catch (Exception e)
			{
				MessageBox.Show("Exeption: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			fsInput.Close();
			fsEncrypted.Close();
		}

        private void DecryptFile(string source, string destination, string key)
		{
			FileStream fsInput = new FileStream(source, FileMode.Open, FileAccess.Read);
			FileStream fsEncrypted = new FileStream(destination, FileMode.Create, FileAccess.Write);
			DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
			try
			{
				DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
				DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
				ICryptoTransform desencrypt = DES.CreateDecryptor();
				CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
				byte[] bytearrayinput = new byte[fsInput.Length - 0];
				fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
				cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
				cryptostream.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show("Exeption: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			fsInput.Close();
			fsEncrypted.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			SaveFileDialog saveFile = new SaveFileDialog();
			key = textBox1.Text;
			saveFile.Filter = "text file |*.txt ";
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllLines(saveFile.FileName, textBox2.Lines);
				string fileName = saveFile.FileName;
				saveFile.Filter = "des files |*.des ";
				if (saveFile.ShowDialog() == DialogResult.OK)
				{
					EncryptFile(fileName, saveFile.FileName, key);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			SaveFileDialog saveFile = new SaveFileDialog();
			key = textBox1.Text;
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				saveFile.Filter = "txt files |*.txt ";
				if (saveFile.ShowDialog() == DialogResult.OK)
				{
					DecryptFile(fileDialog.FileName, saveFile.FileName, key);
					textBox2.Lines = File.ReadAllLines(saveFile.FileName);
				}
			}
		}
	}
}
