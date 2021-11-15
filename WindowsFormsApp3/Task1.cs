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
using WindowsFormsApp3.ClassesLab8;

namespace WindowsFormsApp3
{
	public partial class Task1 : Form
	{
		public Task1()
		{
			InitializeComponent();
		}

		List<Hot> hots = new List<Hot>();
		List<Drinks> drinks = new List<Drinks>();
		List<Salad> salads = new List<Salad>();
		List<Soups> soups = new List<Soups>();
		List<Dessert> desserts = new List<Dessert>();

		float TotalPrice = 0, TotalSize = 0;

		List<Food> Total = new List<Food>();

		private void Task1_Load(object sender, EventArgs e)
		{
			hots.Add(new Hot("Pizza", 300000, 2000, 25f));
			hots.Add(new Hot("Plov", 600000, 1200, 15.7f));
			hots.Add(new Hot("Musshrom", 6000, 1000, 5.67f));
			hots.Add(new Hot("Spice", 5000, 1200, 5f));
			hots.Add(new Hot("Frogfoots", 180000, 7000, 10f));
			hots.Add(new Hot("Omega-4", 300000, 1000, 50.5f));
			hots.Add(new Hot("Turrian Steak", 900000, 2500, 15.7f));

			foreach (Hot hot in hots)
			{
				listBox1.Items.Add(hot.Name);
			}

			drinks.Add(new Drinks("Cola 1.5", 0, 500, 1.5f));
			drinks.Add(new Drinks("Fanta", 0, 400, 1.5f));
			drinks.Add(new Drinks("Beer", 0, 2000, 1f));
			drinks.Add(new Drinks("Sprite", 0, 500, 1.5f));
			drinks.Add(new Drinks("Skooma", 0, 6000, 0.75f));
			drinks.Add(new Drinks("Cola 2.0", 0, 700, 2f));

			foreach (Drinks drink in drinks)
			{
				listBox2.Items.Add(drink.Name);
			}

			salads.Add(new Salad("Olivie", 240000, 800, 2.5f));
			salads.Add(new Salad("Ciesar", 0, 1200, 2.5f));
			salads.Add(new Salad("Kraby", 0, 1000, 2.5f));
			salads.Add(new Salad("Greece", 0, 500, 2.5f));

			foreach (Salad sal in salads)
			{
				listBox3.Items.Add(sal.Name);
			}

			soups.Add(new Soups("Rassol", 0, 1200, 10f));
			soups.Add(new Soups("Vegetebel", 0, 900, 10f));
			soups.Add(new Soups("Pea soup", 0, 1000, 10f));
			soups.Add(new Soups("Borsch", 0, 1100, 10f));

			foreach (Soups sup in soups)
			{
				listBox4.Items.Add(sup.Name);
			}

			desserts.Add(new Dessert("Ice cream", 0, 200, 3f));
			desserts.Add(new Dessert("Moon sugar", 0, 200, 3f));
			desserts.Add(new Dessert("Bravil jam", 0, 200, 3f));

			foreach (Dessert des in desserts)
			{
				listBox5.Items.Add(des.Name);
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != null)
			{
				Total.Add(hots[listBox1.SelectedIndex]);
				TotalPrice += hots[listBox1.SelectedIndex].Price;
				TotalSize += hots[listBox1.SelectedIndex].Size;
			}
			label6.Text = "Цена: " + TotalPrice + "\n" + "Размер: " + TotalSize;
			UpdateTotalList();

		}


		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != null)
			{
				label1.Text = "Цена: " + hots[listBox1.SelectedIndex].Price;
			}
			else
			{
				label1.Text = "";
			}
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox2.SelectedIndex != null)
			{
				label2.Text = "Цена: " + hots[listBox2.SelectedIndex].Price;
			}
			else
			{
				label2.Text = "";
			}
		}

		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox3.SelectedIndex != null)
			{
				label3.Text = "Цена: " + hots[listBox3.SelectedIndex].Price;
			}
			else
			{
				label3.Text = "";
			}
		}

		private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox4.SelectedIndex != null)
			{
				label4.Text = "Цена: " + hots[listBox4.SelectedIndex].Price;
			}
			else
			{
				label4.Text = "";
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			if (listBox2.SelectedIndex != null)
			{
				Total.Add(drinks[listBox2.SelectedIndex]);
				TotalPrice += drinks[listBox2.SelectedIndex].Price;
				TotalSize += drinks[listBox2.SelectedIndex].Size;
			}
			label6.Text = "Цена: " + TotalPrice + "\n" + "Размер: " + TotalSize;
			UpdateTotalList();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (listBox3.SelectedIndex != null)
			{
				Total.Add(salads[listBox3.SelectedIndex]);
				TotalPrice += salads[listBox3.SelectedIndex].Price;
				TotalSize += salads[listBox3.SelectedIndex].Size;
			}
			label6.Text = "Цена: " + TotalPrice + "\n" + "Размер: " + TotalSize;
			UpdateTotalList();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (listBox4.SelectedIndex != null)
			{
				Total.Add(soups[listBox4.SelectedIndex]);
				TotalPrice += soups[listBox4.SelectedIndex].Price;
				TotalSize += soups[listBox4.SelectedIndex].Size;
			}
			label6.Text = "Цена: " + TotalPrice + "\n" + "Размер: " + TotalSize;
			UpdateTotalList();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (listBox5.SelectedIndex != null)
			{
				Total.Add(desserts[listBox5.SelectedIndex]);
				TotalPrice += desserts[listBox5.SelectedIndex].Price;
				TotalSize += desserts[listBox5.SelectedIndex].Size;
			}
			label6.Text = "Цена: " + TotalPrice + "\n" + "Размер: " + TotalSize;
			UpdateTotalList();
		}

		private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox5.SelectedIndex != null)
			{
				label5.Text = "Цена: " + hots[listBox5.SelectedIndex].Price;
			}
			else
			{
				label5.Text = "";
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			FileManager fm = new FileManager();
			fm.Write(Total);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Total.Clear();
			listBox6.Items.Clear();
		}

		private void UpdateTotalList()
		{
			listBox6.Items.Clear();
			foreach (Food food in Total)
			{
				listBox6.Items.Add(food.Name);
			}

		}

	}
}
