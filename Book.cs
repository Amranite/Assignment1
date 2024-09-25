using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	internal class Book
	{
		public int Isbn { get; set; }
		public string Name { get; set; }
		public string Publisher { get; set; }
		public double Price { get; set; }

		public Book() { }

		public Book(int isbn, string name, string publisher, double price)
		{
			Isbn = isbn;
			Name = name;
			Publisher = publisher;
			Price = price;
		}

		public void BasicInputMethod()
		{
            Console.Write("Write Something:");
			string input = Console.ReadLine();
		}

		public override string ToString()
		{
			return	$"ISBN: {Isbn}\n" +
					$"Name: {Name}\n" +
					$"Publisher: {Publisher}\n" +
					$"Price: {Price}";
		}
	}
}
