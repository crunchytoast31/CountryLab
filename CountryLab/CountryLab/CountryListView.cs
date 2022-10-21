using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    public class CountryListView
    {
        public List<Country> CountryList { get; set; }

        public CountryListView(List<Country> countries)
        {
            CountryList = countries;
        }

        public void Display()
        {
            int i = 1;
            foreach (Country country in CountryList)
            {
                Console.WriteLine($" [{i}] | {country.Name}");
                i++;
            }
        }
    }
}
