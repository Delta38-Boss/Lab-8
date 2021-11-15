using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.ClassesLab8
{
	class Dessert : Food
	{
		private float time;
		public float TimeToReady { get { return time; } }

		public Dessert() { }

		public Dessert(string _name)
		{
			name = _name;
			price = 0;
			size = 0;
		}

		public Dessert(string _name, float _time)
		{
			name = _name;
			time = _time;
			price = 0;
			size = 0;
		}

		public Dessert(string _name, float _price, float _size)
		{
			name = _name;
			price = _price;
			time = 0;
			size = _size;
		}

		public Dessert(string _name, float _time, float _price, float _size)
		{
			name = _name;
			price = _price;
			time = _time;
			size = _size;
		}
	}
}
