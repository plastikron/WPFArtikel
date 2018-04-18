using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplicationArtikel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Artikel> lart;
        public MainWindow()
        {
            InitializeComponent();
            lart = new List<Artikel>();
            fuellecombobox();

        }

        private void fuellecombobox()
        {
            listefuellen();
            comboBox_Art.DataContext = lart;
            comboBox_Art.ItemsSource = lart;
        }

        private void listefuellen()
        {
            Artikel m = new Artikel { ArtNr = "12345", ArtBez = "Stuhl", Bestand = 10, Bestellbestand = 5, Bestellmenge= 4, EPreis = 19.99m, VPreis = 29.99m };
            lart.Add(m);
            Artikel n = new Artikel { ArtNr = "23456", ArtBez = "Tisch", Bestand = 20, Bestellbestand = 10, Bestellmenge= 13, EPreis = 25.60m, VPreis = 42.30m };
            lart.Add(n);
            Artikel o = new Artikel { ArtNr = "34567", ArtBez = "Hocker", Bestand = 15, Bestellbestand = 5, Bestellmenge = 8, EPreis = 24.80m, VPreis = 35.20m };
            lart.Add(o);
            Artikel p = new Artikel { ArtNr = "45678", ArtBez = "Lampe", Bestand = 50, Bestellbestand = 30, Bestellmenge = 25, EPreis = 10.00m, VPreis = 20.00m };
            lart.Add(p);
            Artikel q = new Artikel { ArtNr = "56789", ArtBez = "Backfisch", Bestand = 100, Bestellbestand = 50, Bestellmenge = 20, EPreis = 1.00m, VPreis = 2.50m };
            lart.Add(q);
        }

        private void button_kaufen_Click(object sender, RoutedEventArgs e)
        {
            Artikel a = (Artikel)comboBox_Art.SelectedItem;
            int m = Convert.ToInt32(textBox_Menge.Text);
            if (m <= a.Bestand)
            {
                a.verkaufen(m);
                textBox_Nachricht.Text = "Vielen Dank für den Einkauf von Artikel: " +a.ArtBez+ "    Menge: " +m;
            }
            else
            {
                a.nachbestellen();
                textBox_Nachricht.Text = "Artikel wird nachbestellt";
            }
        }
    }
}
