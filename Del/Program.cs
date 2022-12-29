using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{

	class Program
	{
		delegate void PrintConsole(string s);//* -> place in Heap


		static void Main(string[] args)
		{
			Retailer pub = new Retailer();
			View view = new View();

			PrintConsole printConsole;
            
			List<INotifyable> listOfCustomers = new List<INotifyable>();
			listOfCustomers.Add(new Customer("Tommy", view));
			listOfCustomers.Add(new ForeignCustomer("Jim", view));

			foreach (var cust in listOfCustomers)
			{
				pub.OnIphoneAppers += cust.Notify;
			}

			pub.Raise();
		}

	}

	public interface IPrintable
    {
		void Print(string s);
    }

    class View : IPrintable
    {
        public void Print(string name)
        {
			Console.WriteLine($"Text to {name} if IPhone appers");
		}
    }
    class Retailer
	{
		public event Action OnIphoneAppers;

		public void Raise()
		{
			var day = DateTime.Now;
			while (true)
			{
				Console.WriteLine($"Today is {day}");
				if (day.Day == 29)
				{
					OnIphoneAppers();
				}

				day = day.AddDays(1);

				Thread.Sleep(500);
			}
		}
	}

	interface INotifyable
	{
		void Notify();
	}

	class Customer : INotifyable 
	{
		public string name;
		IPrintable view;
		public Customer(string name, IPrintable v)
		{
			this.name = name;
			view = v;
			
		}

		public void Notify()
		{
			view.Print(name);
		}

    }

	class ForeignCustomer : INotifyable
	{
		public string name;
		IPrintable view;
		public ForeignCustomer(string name, IPrintable v)
		{
			this.name = name;
			view = v;
		}

		public void Notify()
		{
			view.Print(name);
		}
	}
}
