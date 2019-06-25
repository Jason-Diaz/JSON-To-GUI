//******************************************************
// File: CountryAppUnitTesting.cs
//
// Purpose: The CountryAppUnitTesting class with definitions. Used
//          for testing the country data application.
//
// Written By: Jason Diaz 
//
// Compiler: Visual Studio 2017
//
//******************************************************

using System;

namespace CountryDataLibrary
{
    public class CountryAppUnitTesting
    {
        #region CountryAppUnitTesting Methods

        // This method declares an instance of Currency inside of it
        // and performs unit testing on all the properties of that instance.
        public void UnitTestCurrency()
        {
            Currency c = new Currency();
            string testString = "Code1 Name Symbol!";
            string display = "***********************";

            // Test valid code
            c.Code = testString;
            // Test valid name
            c.Name = testString;
            // Test valid symbol
            c.Symbol = testString;

            Console.WriteLine("\n" + display + "\nUnit Testing: Currency\n" + display);

            if (c.Code.Equals(testString))
            {
                Console.WriteLine("Currency Code Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Code Property: FAIL!");
            }

            if (c.Name.Equals(testString))
            {
                Console.WriteLine("Currency Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Name Property: FAIL!");
            }

            if (c.Symbol.Equals(testString))
            {
                Console.WriteLine("Currency Symbol Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Symbol Property: FAIL!");
            }
            Console.WriteLine();
        }

        // This method declares an instance of Language inside of it
        // and perform unit testing on all the properties of that instance.
        public void UnitTestLanguage()
        {
            string testString = "FName LName 123";
            Language l = new Language();
            string display = "***********************";

            // Test valid name
            l.Name = testString;
            // Test valid nativeName
            l.NativeName = testString;
            // Test valid Iso639_1
            l.Iso639_1 = testString;
            // Test valid Iso639_2
            l.Iso639_2 = testString;

            Console.WriteLine("\n" + display + "\nUnit Testing: Language\n" + display);

            if (l.Name.Equals(testString))
            {
                Console.WriteLine("Language Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Language Name Property: FAIL!");
            }

            if (l.NativeName.Equals(testString))
            {
                Console.WriteLine("Language NativeName Property: Pass");
            }
            else
            {
                Console.WriteLine("Language NativeName Property: FAIL!");
            }

            if (l.Iso639_1.Equals(testString))
            {
                Console.WriteLine("Language ISO639_1 Property: Pass");
            }
            else
            {
                Console.WriteLine("Language ISO639_1 Property: FAIL!");
            }

            if (l.Iso639_2.Equals(testString))
            {
                Console.WriteLine("Language ISO639_2 Property: Pass");
            }
            else
            {
                Console.WriteLine("Language ISO639_2 Property: FAIL!");
            }
            Console.WriteLine();
        }

        // This method declares an instance of Country inside of it
        // and perform unit testing on all the properties of that instance.
        public void UnitTestCountry()
        {
            string testString = "Name Capital Region Subregion";
            int testInt = 100;
            Country c = new Country();
            string display = "***********************";

            // Test valid name
            c.Name = testString;
            // Test valid Capital
            c.Capital = testString;
            // Test valid Region
            c.Region = testString;
            // Test valid Subregion
            c.Subregion = testString;
            // Test valid Population
            c.Population = testInt;

            Console.WriteLine("\n" + display + "\nUnit Testing: Country\n" + display);

            if (c.Name.Equals(testString))
            {
                Console.WriteLine("Country Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Country Name Property: FAIL!");
            }

            if (c.Capital.Equals(testString))
            {
                Console.WriteLine("Country Capital Property: Pass");
            }
            else
            {
                Console.WriteLine("Country Name Property: FAIL!");
            }

            if (c.Region.Equals(testString))
            {
                Console.WriteLine("Country Region Property: Pass");
            }
            else
            {
                Console.WriteLine("Country Region Property: FAIL!");
            }

            if (c.Subregion.Equals(testString))
            {
                Console.WriteLine("Country Subregion Property: Pass");
            }
            else
            {
                Console.WriteLine("Country Subregion Property: FAIL!");
            }

            if (c.Population == testInt)
            {
                Console.WriteLine("Country Population Property: Pass");
            }
            else
            {
                Console.WriteLine("Country Population Property: FAIL!");
            }

            Console.WriteLine();
        }
        #endregion
    }
}