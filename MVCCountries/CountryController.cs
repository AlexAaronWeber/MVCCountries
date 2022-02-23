using System;
namespace MVCCountries
{
	public class CountryController
	{
		//properties
		public List<Country> CountryDb { get; set; }

		//constructor
		public CountryController()
		{

			CountryDb = new List<Country>()
			{
				new Country ("USA", "NorthAmerica", new List<string>(){"Red", "White" ,"Blue"}),
				new Country ("Japan", "Asia", new List<string>(){"Red", "White"}),
				new Country ("Germany", "Europe", new List<string>(){"Black", "Red", "Yellow"}),
				new Country ("Italy", "Europe", new List<string>(){"Red", "White", "Green"}),
				new Country ("Ghana", "Africa", new List<string>(){"Red", "Yellow", "Green", "Black"}),
			};
		}

		//methods
		public void CountryAction(Country c)
		{
			CountryView view = new CountryView(c);
			view.Display();
		}

		public void WelcomeAction()
		{
			CountryListView view = new CountryListView(CountryDb);
			bool looping = true;
			while (looping)
			{
				Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
				view.Display();
				int indexSelect = int.Parse(Console.ReadLine()) -1;
                Console.WriteLine();
				CountryAction(CountryDb[indexSelect]);

				Console.WriteLine("Learn about another country: y/n?");
				string continues = Console.ReadLine().Trim().ToLower();

				if (continues == "y" || continues == "yes")
				{
					looping = true;
				}
				else if (continues == "n" || continues == "no")
				{
					looping = false; 
				}
				else
				{
					Console.WriteLine("Invalid");
				}
				Console.Clear();
			}
		}



	}
}


