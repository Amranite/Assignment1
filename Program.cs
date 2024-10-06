using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a book and a magazine
			Book book1 = new Book(1234, "Book 1", "Publisher 1", 12.34);
			Book book2 = new Book(1234, "Book 2", "Publisher 2", 12.34);
			Magazine magazine1 = new Magazine(4321, "Magazine 1", "Publisher 3", 43.21);
			Magazine magazine2 = new Magazine(4321, "Magazine 2", "Publisher 4", 43.21);

			// Create orders for the book and the magazine
			Order<Book> bookOrder = new Order<Book>(book1, 2);
			Order<Magazine> magazineOrder = new Order<Magazine>(magazine1, 1, "Monthly");

			// Trigger order confirmation event for the book
			bookOrder.ConfirmOrder();

			// Get the order tuple for the book
			var orderDetails = bookOrder.OrderBook(book1);
			Console.WriteLine($"Order for Book ISBN: {orderDetails.Item1}, Copies: {orderDetails.Item2}, Total Price: {orderDetails.Item3}");
		}
	}
}