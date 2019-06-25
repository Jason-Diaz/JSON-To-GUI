//******************************************************
// File: MainWindow.xaml.cs
//
// Purpose: This application will use a Windows Presentation
//          Foundation (WPF) GUI to display country data.
//          The main window for the application contains
//          a member variable for a list of Country. The
//          member variable gets loaded with data when
//          the Open button is pressed. The Find Country
//          by Name button when pressed will display
//          information on the country based on the inputed
//          country name.
//
// Written By: Jason Diaz 
//
// Compiler: Visual Studio 2017
//
//******************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;
using CountryDataLibrary;
using Microsoft.Win32;
using System.Runtime.Serialization.Json;

namespace jasonDiaz_Assign4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Country> countries = new List<Country>();
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

            this.Title = "Country GUI - v1 - Jason Diaz";
        }

        #region Button methods
        //****************************************************
        // Method: buttonOpen_Click
        //
        // Purpose:	Display an open file dialog and let the user
        //          select the file to open.
        //****************************************************
        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            openFileDialog.Title = "Open Countries From JSON";

            if (openFileDialog.ShowDialog() == true)
            {
                textboxFilename.Text = openFileDialog.FileName;
                FileStream reader = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(reader, Encoding.UTF8);
                string streamString = streamReader.ReadToEnd();

                byte[] byteArray = Encoding.UTF8.GetBytes(streamString);
                MemoryStream stream = new MemoryStream(byteArray);


                DataContractJsonSerializer inputSerializer;
                inputSerializer = new DataContractJsonSerializer(typeof(List<Country>));
                countries = (List<Country>)inputSerializer.ReadObject(stream);

                stream.Close();
            }
            ClearCountryText();
        }

        //****************************************************
        // Method: Button_Click
        //
        // Purpose:	Search the countries list window member
        //          variable for the country name the user
        //          typed in. 
        //****************************************************
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string countryname = textboxCountryName.Text;
            Country selectedCountry = new Country();
            ClearCountryText();

            if (countries.Find(x => x.Name == countryname) != null)
            {
                selectedCountry = countries.Find(x => x.Name == countryname);
                textboxName.Text = selectedCountry.Name;
                textboxCapital.Text = selectedCountry.Capital;
                textboxRegion.Text = selectedCountry.Region;
                textboxSubregion.Text = selectedCountry.Subregion;
                textboxPopulation.Text = selectedCountry.Population.ToString();
                listviewCurrencies.ItemsSource = selectedCountry.Currencies;
                listviewLanguages.ItemsSource = selectedCountry.Languages;
            }
        }
        #endregion

        #region ClearCountryText method
        //****************************************************
        // Method: ClearCountryText
        //
        // Purpose:	Clear the country data TextBoxes and ListViews
        //****************************************************
        private void ClearCountryText()
        {
            textboxName.Text = String.Empty;
            textboxCapital.Text = String.Empty;
            textboxRegion.Text = String.Empty;
            textboxSubregion.Text = String.Empty;
            textboxPopulation.Text = String.Empty;

            listviewCurrencies.ItemsSource = null;
            listviewCurrencies.Items.Clear();

            listviewLanguages.ItemsSource = null;
            listviewLanguages.Items.Clear();
        }
        #endregion
    }
}
