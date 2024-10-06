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
        private double price;

		public int Isbn { get; set; }
		public string Name { get; set; }
		public string Publisher { get; set; }

		public double Price
		{
			get { return price; }
			set
			{
				if (value < 5 || value > 50)
					throw new ArgumentException("Price must be between €5 and €50");
				price = value;
			}
		}

		public Book() { }

		public Book(int isbn, string name, string publisher, double price)
		{
			Isbn = isbn;
			Name = name;
			Publisher = publisher;
			Price = price; // Using the price setter
		}

		public virtual void Read()
		{
			Console.Write("Reading a book...");
		}

		public static Book CreateBook()
		{
			Console.Write("Enter ISBN: ");
			int isbn = int.Parse(Console.ReadLine());
			Console.Write("Enter name: ");
			string name = Console.ReadLine();
			Console.Write("Enter publisher: ");
			string publisher = Console.ReadLine();
			Console.Write("Enter price: ");
			double price = double.Parse(Console.ReadLine());

			return new Book(isbn, name, publisher, price);
		}

		public override string ToString()
		{
			return $"Book [ISBN: {Isbn} Name: {Name} Publisher: {Publisher} Price: {Price}]";
		}
	}
}
