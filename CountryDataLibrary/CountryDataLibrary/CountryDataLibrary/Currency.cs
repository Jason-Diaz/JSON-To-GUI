//******************************************************
// File: Currency.cs
//
// Purpose: the Currency class with definitions. This class
//          is used for the country data application.
//
// Written By: Jason Diaz 
//
// Compiler: Visual Studio 2017
//
//******************************************************

using System.Runtime.Serialization;

namespace CountryDataLibrary
{
    [DataContract]
    public class Currency
    {
        #region Currency private member variables
        [DataMember(Name = "code")]
        private string code;
        [DataMember(Name = "name")]
        private string name;
        [DataMember(Name = "symbol")]
        private string symbol;
        #endregion

        #region Currency methods
        //****************************************************
        // Method: Currency
        //
        // Purpose: Default constructor for currency. 
        //          Sets all variables to default.
        //****************************************************
        public Currency()
        {
            code = null;
            name = null;
            symbol = null;
        }

        #region Currency properties
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

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

        public string Symbol
        {
            get
            {
                return symbol;
            }
            set
            {
                symbol = value;
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
            return "Code: " + code + ", Name: " + name + ", Symbol: " + symbol;
        }
        #endregion
    }
}