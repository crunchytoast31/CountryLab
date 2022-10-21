using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    public class CounrtyView
    {
        public Country DisplayCountry { get; set; }


        public CounrtyView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        public void Display()
        {

            Console.WriteLine($"Name: {DisplayCountry.Name} Continent: {DisplayCountry.Contient} Colors : {DisplayCountry.Colors}");
        }
    }
}
