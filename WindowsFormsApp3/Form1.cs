using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		bool Free_evening = false;
		bool Invite_friend = false;
		bool Pickup_shoes = false;
		bool Makeup = false;
		bool Prepare_Suit = false;
		bool Buy_Tickets = false;
		bool Left = false;
		bool Right = false;

		private void button1_Click(object sender, EventArgs e)
		{
			
			    
			    if (comboBox1.Text == "Левый")
			    {
				  Left = true;
				  listBox2.Items.Add("Запуск левого двигателя");
			    }
				else
			    {
				  listBox2.Items.Add("Запуск правого двигателя");
				  Right = true;
			    }
				if (listBox1.SelectedIndices.IndexOf(0) == 0)
				{
					listBox2.Items.Add("Включить питание");//Идти на концерт
					Invite_friend = true;
					listBox2.Items.Add("Запустить генераторы");//Пригласить подругу
				}
				if (listBox1.SelectedIndices.IndexOf(3) == 3)
				{
					listBox2.Items.Add("Запустить ВСУ");//Приготовить костюм
					Pickup_shoes = true;
					Console.WriteLine("Открыть кран двигателя");//Подобрать туфли
				}
				if (listBox1.SelectedIndices.IndexOf(2) == 2)
				{
					listBox2.Items.Add("Запустить насосы");//Купить билеты
					Free_evening = true;
					listBox2.Items.Add("Открыть кран ВСУ");//Освободить вечер
				}
				//----------Разделитель---------------
				if (listBox1.SelectedIndices.IndexOf(0) == 0 && Free_evening)
				{
					Prepare_Suit = true;
					listBox2.Items.Add("Запустить ВСУ");//Приготовить костюм
				}
				if (listBox1.SelectedIndices.IndexOf(0) == 0 && Invite_friend)
				{
					Buy_Tickets = true;
					listBox2.Items.Add("Запустить насосы");//Купить билеты
				}

				//---------Проверка ЭРД-------
				if (listBox1.SelectedIndices.IndexOf(0) == 0 && Free_evening && Left)
				{
					listBox2.Items.Add("Включить левый ЭРД");
				}
			    else if(listBox1.SelectedIndices.IndexOf(0) == 0 && Free_evening && Right)
				{
				    listBox2.Items.Add("Включить правый ЭРД");
				}


				// --------- Проверка на левый или правый двигатель -----------
				if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndices.IndexOf(4) == 4 && listBox1.SelectedIndices.IndexOf(5) != 5)
				{
					
					listBox2.Items.Add("Выбрать левый двигатель");
				}
		    	else if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndices.IndexOf(5) == 5 && listBox1.SelectedIndices.IndexOf(4) != 4)
				{
					
					listBox2.Items.Add("Выбрать правый двигатель");
				}
				if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndices.IndexOf(6) == 6 && listBox1.SelectedIndices.IndexOf(7) != 7)
				{
					Left = true;
					listBox2.Items.Add("Открыть кран левого двигатель");
				}
		    	else if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndices.IndexOf(7) == 7 && listBox1.SelectedIndices.IndexOf(6) != 6)
				{
					Right = true;
					listBox2.Items.Add("Открыть кран правого двигатель");
				}

				if (listBox1.SelectedIndices.IndexOf(0) == 0 && Invite_friend && Prepare_Suit)
				{
					listBox2.Items.Add("Отпутстить тормоз винтов");
				}

				if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndices.IndexOf(9) == 9 && listBox1.SelectedIndices.IndexOf(10) != 10)
				{
					listBox2.Items.Add("Выбрать левый редуктор");
				}
		    	else if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndices.IndexOf(10) == 10 && listBox1.SelectedIndices.IndexOf(9) != 9)
				{
					listBox2.Items.Add("Выбрать правый редуктор");
				}
				
				if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 6 && Pickup_shoes)
				{
					Makeup = true;
					listBox2.Items.Add("Запустить двигатель");//Сделать макияж
				}
				if (Makeup && Left)
				{
					listBox2.Items.Add("Вывести РУД левого двигателя");
				}
		    	else if (Makeup && Right)
				{
					listBox2.Items.Add("Вывести РУД правого двигателя");
				}
				if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 6 && Pickup_shoes && Makeup)
				{
					listBox2.Items.Add("Отключить ВСУ");
				}
				
				
				foreach (string _line in listBox1.SelectedItems)
				{
					listBox2.Items.Add(_line);
					Console.WriteLine(_line);
				}
			

			// ------------------------ Проверка ---------------------------
			if (Invite_friend && Makeup && Pickup_shoes && Invite_friend && Buy_Tickets && Prepare_Suit && (Left || Right))
			{
				label1.Text = "Двигатель запущен";//Отличное настроение
			}
			else
			{
				MessageBox.Show("Двигатель не получилось запустить. Перезапуск..", "Двигатель не получилось запустить. Перезапуск...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void задние2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Task2 task = new Task2();
			task.Show();
		}

		private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Task1 task = new Task1();
			task.Show();
		}

		private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Task3 task = new Task3();
			task.Show();
		}
	}
}
