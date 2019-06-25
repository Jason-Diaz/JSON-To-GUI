//******************************************************
// File: Language.cs
//
// Purpose: the Language class with definitions. This class
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
    public class Language
    {
        #region Language private member variables
        [DataMember(Name = "name")]
        private string name;
        [DataMember(Name = "nativeName")]
        private string nativeName;
        [DataMember(Name = "iso639_1")]
        private string iso639_1;
        [DataMember(Name = "iso639_2")]
        private string iso639_2;
        #endregion

        #region Language methods
        //****************************************************
        // Method: Language
        //
        // Purpose: Default constructor for Language. 
        //          Sets all variables to default.
        //****************************************************
        public Language()
        {
            name = null;
            nativeName = null;
            iso639_1 = null;
            iso639_2 = null;
        }

        #region Language properties
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

        public string NativeName
        {
            get
            {
                return nativeName;
            }
            set
            {
                nativeName = value;
            }
        }

        public string Iso639_1
        {
            get
            {
                return iso639_1;
            }
            set
            {
                iso639_1 = value;
            }
        }

        public string Iso639_2
        {
            get
            {
                return iso639_2;
            }
            set
            {
                iso639_2 = value;
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
            return "Name: " + name + ", NativeName: " + nativeName + ", iso639_1: " + iso639_1 + ", iso639_2: " + iso639_2;
        }
        #endregion
    }
}