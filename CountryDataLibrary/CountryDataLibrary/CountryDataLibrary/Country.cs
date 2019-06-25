//******************************************************
// File: Country.cs
//
// Purpose: the Country class with definitions. This class
//          is used for the country data application.
//
// Written By: Jason Diaz 
//
// Compiler: Visual Studio 2017
//
//******************************************************

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CountryDataLibrary
{
    [DataContract]
    public class Country
    {
        #region Country private member variables
        [DataMember(Name = "name")]
        private string name;
        [DataMember(Name = "capital")]
        private string capital;
        [DataMember(Name = "region")]
        private string region;
        [DataMember(Name = "subregion")]
        private string subregion;
        [DataMember(Name = "population")]
        private int population;
        [DataMember(Name = "currencies")]
        private List<Currency> currencies;
        [DataMember(Name = "languages")]
        private List<Language> languages;
        #endregion

        #region Country methods
        //****************************************************
        // Method: Country
        //
        // Purpose: Default constructor for currency. 
        //          Sets all variables to default.
        //****************************************************
        public Country()
        {
            name = null;
            capital = null;
            region = null;
            subregion = null;
            population = 0;
            currencies = new List<Currency>();
            languages = new List<Language>();
        }

        #region Country properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Capital
        {
            get
            {
                return capital;
            }
            set
            {
                capital = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }

        public string Subregion
        {
            get
            {
                return subregion;
            }
            set
            {
                subregion = value;
            }
        }

        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }

        public List<Currency> Currencies
        {
            get
            {
                return currencies;
            }
            set
            {
                currencies = value;
            }
        }

        public List<Language> Languages
        {
            get
            {
                return languages;
            }
            set
            {
                languages = value;
            }
        }
        #endregion

        //****************************************************
        // Method: ToString
        //
        // Purpose: Displays the contents of the class variables
        //****************************************************
        override public string ToString()
        {
            //Strings to contain the collection of currencies and languages
            string currenciesSTR = "";
            string languagesSTR = "";

            if (currencies != null)
            {
                foreach (Currency currency in currencies)
                {
                    currenciesSTR += currency.ToString() + "\n";
                }
            }

            if (languages != null)
            {
                foreach (Language language in languages)
                {
                    languagesSTR += language.ToString() + "\n";
                }
            }

            return "Name      : " + name + "\nCapital   : " + capital + "\nRegion    : " + region + "\nSubregion : " + subregion + "\nPopulation: " + population + "\n \n" + name + " Languages \n" + languagesSTR + "\n" + name + " Currencies \n" + currenciesSTR + "\n";
        }
        #endregion
    }
}
