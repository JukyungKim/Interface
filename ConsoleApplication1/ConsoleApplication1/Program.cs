using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("out");
			Console.WriteLine("dijf");
			Console.WriteLine("dijf");
		}
		public void state()
		{
			int i;

		}
	}
	abstract public class Animal
	{
		int value;
		abstract public void Sound();
	}

	public class Cat : Animal
	{

		public override void Sound()
		{
			throw new NotImplementedException();
		}
	}

	interface IAnimal
	{
		void Sound();
	}
	interface IBird
	{
		void Size();
	}
	public class dog : IAnimal, IBird
	{
		public void Sound()
		{

		}
		public void Size()
		{

		}
 
	}
}
