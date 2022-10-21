using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    public class CountryController
    {
        public List<Country> CountryDB { get; set; } = new List<Country>()
        {
            new Country("Ireland",Country.Continent.Europe,"Green White Orange"),
            new Country("United kingdom ",Country.Continent.Europe,"Red Blue White"),
            new Country("Romania",Country.Continent.Europe,"Blue Yellow Red"),
            new Country("USA",Country.Continent.North_America,"Red Blue White"),
            new Country("Canada",Country.Continent.North_America,"Red White"),
            new Country("Egypt",Country.Continent.Africa,"Gold Black White Red"),
            new Country("Morroco",Country.Continent.Africa,"Red Green Blue"),
            new Country("Japan",Country.Continent.Asia,"Red White"),
            new Country("Iraq",Country.Continent.Asia,"Red Black Green WHite"),
        };

        public void CountryAction(Country c)
        {
            CounrtyView a = new CounrtyView(c);

            a.Display();

        }

        public void WelcomeAction()
        {
            bool goOn = true;
            while (goOn)
            {
                CountryListView cat = new CountryListView(CountryDB);
                Console.WriteLine("Select a number matching the country.");
                cat.Display();
                int input = int.Parse(Console.ReadLine());

                CountryAction(CountryDB[input]);

                Console.WriteLine("Would you like to learn about another country? Y/N?");
                string input2 = Console.ReadLine();
                if (input2 == "Y")
                {
                    goOn = true;
                }
                else
                {
                    goOn = false;
                }
            }

        }
    }
}
