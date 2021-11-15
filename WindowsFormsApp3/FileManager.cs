using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApp3.ClassesLab8;

namespace WindowsFormsApp3
{
	class FileManager
	{
		List<string> Read(string file)
		{
			List<string> mass = new List<string>();
			string[] lines = File.ReadAllLines("file.txt");
			foreach (string line in lines)
			{
				mass.Add(line);
			}
			return mass;
		}

		public void Write(List<Food> food)
		{
			string[] names = new string[food.Count + 2];
			int i = 0;
			int price = 0;
			foreach (Food fd in food)
			{
				names[i] = food[i].Name + " " + food[i].Price;
				price += Convert.ToInt32(food[i].Price);
				Console.WriteLine(names[i]);
				i++;
				
			}
			names[i + 1] = "Total: " + price;

			try
			{
				File.WriteAllLines("file.txt", names);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
			

		}

	}
}
