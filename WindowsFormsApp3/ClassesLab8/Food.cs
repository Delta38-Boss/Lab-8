using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.ClassesLab8
{
	abstract class Food
	{
		protected string name;
		protected float size;
		protected float price;

		public string Name { get { return name; } }
		public float Price { get { return price; } }
		public float Size { get { return size; } }

		public Food(){}

		public Food(string _name)
		{
			name = _name;
			price = 0;
			size = 0;
		}

		public Food(string _name, float _price)
		{
			name = _name;
			price = _price;
			size = 0;
		}
		public Food(string _name, float _price, float _size)
		{
			name = _name;
			price = _price;
			size = _size;
		}

		float GetPrice()
		{
			return price;
		}

	}
}
