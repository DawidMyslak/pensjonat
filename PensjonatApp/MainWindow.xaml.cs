﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PensjonatApp.DS;
using PensjonatApp.Tools;
using System.Data;
using PensjonatApp.Helpers;


namespace PensjonatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
            zwinRezerwacje();
            gridRezerwacjeDeafult.Height = 580;
            zwinPobyty();
            gridPobytyDeafult.Height = 580;
            zwinKlienci();
            gridKlienciDeafult.Height = 580;

        }

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void zwinRezerwacje()
        {
            gridRezerwacjeDeafult.Height = 0;
            gridRezerwacjeAdd.Height = 0;
            gridRezerwacjeAdd2.Height = 0;
            gridRezerwacjeDel.Height = 0;
            gridRezerwacjeCheck.Height = 0;
        }

        private void zwinPobyty()
        {
            gridPobytyDeafult.Height = 0;
            gridPobytyServices.Height = 0;
            gridPobytySum.Height = 0;
            gridPobytyDetails.Height = 0;
        }

        private void zwinKlienci()
        {
            gridKlienciDeafult.Height = 0;
            gridKlienciAdd.Height = 0;
            gridKlienciEdit.Height = 0;
        }


        private void buttonRezerwacjeAdd_Click(object sender, RoutedEventArgs e)
        {
            zwinRezerwacje();
            gridRezerwacjeAdd.Height = 580;
        }


        private void buttonRezerwacjeZaliczka_Click(object sender, RoutedEventArgs e)
        {
            zwinRezerwacje();
			gridRezerwacjeCheck.Height = 580;
        }

        private void buttonRezerwacjeDel_Click(object sender, RoutedEventArgs e)
        {
            zwinRezerwacje();
            gridRezerwacjeDel.Height = 580;
        }

        private void tabRezerwacje_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tabRezerwacje.IsFocused)
            {
                zwinRezerwacje();
                gridRezerwacjeDeafult.Height = 580;
            }
        }

        private void textBoxRezerwacjeAddIloscOsob_TextChanged(object sender, TextChangedEventArgs e)
        {
         //   labelPozostaloOsob.Content = textBoxRezerwacjeAddIlOsob.Text;
        }

        private void buttonRezerwacjeAddDalej_Click(object sender, RoutedEventArgs e)
        {
            zwinRezerwacje();
			gridRezerwacjeAdd2.Height = 580;
        }

        private void dataGrid9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonPobytyServices_Click(object sender, RoutedEventArgs e)
        {
            zwinPobyty();
            gridPobytyServices.Height = 580;
        }

        private void tabPobyty_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tabPobyty.IsFocused)
            {
                zwinPobyty();
                gridPobytyDeafult.Height = 580;
            }
        }

        private void comboBoxPobytyUslugi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBoxPobytyPracownicy.IsEnabled = true;
        }

        private void tabControl1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonPobytySum_Click(object sender, RoutedEventArgs e)
        {
            zwinPobyty();
            gridPobytySum.Height = 580;
        }

        private void buttonPobytyDetails_Click(object sender, RoutedEventArgs e)
        {
            zwinPobyty();
            gridPobytyDetails.Height = 580;
        }

        private void buttonKlienciAdd_Click(object sender, RoutedEventArgs e)
        {
            zwinKlienci();
            gridKlienciAdd.Height = 580;
			buttonKlienciAddDodaj.IsEnabled = false;
        }

        private void buttonKlienciEdit_Click(object sender, RoutedEventArgs e)
        {
            zwinKlienci();
            gridKlienciEdit.Height = 580;
        }

        private void tabKlienci_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tabKlienci.IsFocused)
            {
                zwinKlienci();
                gridKlienciDeafult.Height = 580;
            }
        }

		private void Window_Loaded_1(object sender, RoutedEventArgs e)
		{
		}

		private void gridRezerwacjeDeafult_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			
			if ((bool)(e.NewValue )== true)
			{//pojawienie sie pola
				dataGrid1.ItemsSource = TablesManager.Manager.KlienciTableAdapter.GetKlienciMiejscowosci();

			}
		}

		private void buttonRezerwacjeSearch_Click(object sender, RoutedEventArgs e)
		{
		}

        private void buttonNewsletterNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Czy jesteś pewny?", "Nowy newsletter", MessageBoxButton.YesNo, MessageBoxImage.Question);
            // MessageBoxResult result = Microsoft.Windows.Controls.MessageBox.Show("Czy jesteś pewny?", "Nowy newsletter", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
                richTextBoxNewsletter.Text = @"{\rtf1\ansi\ansicpg1252\uc1\htmautsp\deff2{\fonttbl{\f0\fcharset0 Times New Roman;}{\f2\fcharset0 Segoe UI;}}{\colortbl\red0\green0\blue0;\red255\green255\blue255;}\loch\hich\dbch\pard\plain\ltrpar\itap0{\lang1033\fs18\f2\cf0 \cf0\ql{\f2 {\ltrch }\li0\ri0\sa0\sb0\fi0\ql\par}}}";
        }

		private void buttonKlienciAddDodaj_Click(object sender, RoutedEventArgs e)
		{
			//dodawanie klienta
			if (KlienciHelper.addKlient(
				textBoxKlienciAddMail.Text,
				textBoxKlienciAddImie.Text,
				textBoxKlienciAddNazwisko.Text,
				textBoxKlienciAddMiejscowosc.Text,
				textBoxKlienciAddAdres.Text,
				textBoxKlienciAddNIP.Text,
				textBoxKlienciAddPESEL.Text,
				textBoxKlienciAddTelefon.Text,
				textBoxKlienciAddKodPocztowy.Text) == true)
			{
				MessageBox.Show("Pomyślnie dodano klienta do bazy", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
			}
			else
				MessageBox.Show("Błąd: " + KlienciHelper.lastMsg, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);

		}
		/// <summary>
		/// Sprawdzanie na bieżąco czy 
		/// </summary>
		private void textBoxKlienciAdd_TextChanged(object sender, TextChangedEventArgs e)
		{
			int nip;
			int tel;
			bool sprawdzic=true;

			buttonKlienciAddDodaj.IsEnabled = false;
			this.labelKlienciAddStatus.Content = "";

			if (!int.TryParse(textBoxKlienciAddNIP.Text, out nip))
			{
				if (textBoxKlienciAddNIP.Text != "")
				{
					this.labelKlienciAddStatus.Content = "W polu NIP może być tylko liczba";
					sprawdzic = false;
				}
			}
			if (!int.TryParse(textBoxKlienciAddTelefon.Text, out tel))
			{
				if (textBoxKlienciAddTelefon.Text != "")
				{
					this.labelKlienciAddStatus.Content = "W polu telefon może być tylko liczba";
					sprawdzic = false;
				}
			}
			if (sprawdzic == true)
			{
				buttonKlienciAddDodaj.IsEnabled = true;
			}
			
		}

    }

}
