using System;
namespace MVCCountries
{
	public class CountryView
	{
		//properties
		public Country DisplayCountry { get; set; }

		//Constructor
		public CountryView(Country displayCountry)
        {
			DisplayCountry = displayCountry;
        }

		//methods
		public void Display()
        {
            Console.WriteLine($"Country: {DisplayCountry.Name}");
			Console.WriteLine($"Continent: {DisplayCountry.Continent}");

			foreach (string color in DisplayCountry.Colors)
            {
				if (color == "Red")
                {
					Console.ForegroundColor = ConsoleColor.Red;
                }
				else if (color == "White")
				{
					Console.ForegroundColor = ConsoleColor.White;
				}
				else if (color == "Blue")
				{
					Console.ForegroundColor = ConsoleColor.DarkBlue;
				}
				else if (color == "Black")
				{
					Console.ForegroundColor = ConsoleColor.Black;
					Console.BackgroundColor = ConsoleColor.Gray;

				}
				else if (color == "Yellow")
				{
					Console.ForegroundColor = ConsoleColor.Yellow;

				}
				else if (color == "Green")
				{
					Console.ForegroundColor = ConsoleColor.DarkGreen;
				}
				Console.WriteLine(color);
				Console.ResetColor();
				
            }
		}

	}
}

