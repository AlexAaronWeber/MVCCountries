using System;
namespace MVCCountries
{
	public class CountryListView
	{
		//Properties
		public List<Country> Countries { get; set; } = new List<Country>();

		//constructor
		public CountryListView(List<Country> countries)
        {
			Countries = countries;
        }

		public void Display()
        {
			for (int i = 0; i < Countries.Count; i++)
            {
				Console.WriteLine($"{i + 1} {Countries[i].Name}");
			}
		}
	}
}

