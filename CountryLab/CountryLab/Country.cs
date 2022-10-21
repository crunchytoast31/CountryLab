using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    public class Country
    {
        public string Name { get; set; }

        public Continent Contient { get; set; }


        public enum Continent
        {
            North_America,
            South_America,
            Australia,
            Antartica,
            Asia,
            Europe,
            Africa
        }


        public string Colors { get; set; }




        public Country(string Name, Continent Contient, string Colors)
        {
            this.Name = Name;
            this.Contient = Contient;
            this.Colors = Colors;
        }
    }
}
