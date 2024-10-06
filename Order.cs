using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Order<T>
    {
		private static int orderCounter = 0; // To track unique order IDs
		private int id;
		private T item;
		private int quantity;
		private DateTime orderDate;
		private string subscriptionPeriod;

		// Properties
		public int Id
		{
			get { return id; }
			private set { id = value; }
		}

		public T Item
		{
			get { return item; }
			set { item = value; }
		}

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value > 0 ? value : throw new ArgumentException("Quantity must be greater than 0"); }
		}

		public DateTime OrderDate
		{
			get { return orderDate; }
			set { orderDate = value; }
		}

		public string SubscriptionPeriod
		{
			get { return subscriptionPeriod; }
			set { subscriptionPeriod = value; }
		}

		// Constructor
		public Order(T item, int quantity, string subscriptionPeriod = null)
		{
			Id = ++orderCounter;
			Item = item;
			Quantity = quantity;
			OrderDate = DateTime.Now;
			SubscriptionPeriod = subscriptionPeriod; // Only used for magazines
		}

		// Method to return a tuple for a book order
		public Tuple<int, int, double> OrderBook(Book book)
		{
			double totalPrice = Quantity * book.Price;
			return Tuple.Create(book.Isbn, Quantity, totalPrice);
		}

		// Method to trigger an order confirmation event
		public void ConfirmOrder()
		{
			Console.WriteLine($"Order ID {Id} confirmed for {Quantity} items.");
		}
	}
}
