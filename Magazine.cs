using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	internal class Magazine : Book
	{
		enum PublicationPeriod { Daily, Weekly, Monthly, Yearly }

		public Magazine() : base () { }

		public Magazine(int Isbn, string Name, string Publisher, double Price) : base (Isbn, Name, Publisher, Price) { }

		public override void Read()
		{
			Console.Write("Reading a Magazine...");
		}

		public override string ToString()
		{
			return $"Magazine [ISBN: {Isbn} Name: {Name} Publisher: {Publisher} Price: {Price}]";
		}

	}
}