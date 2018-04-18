using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationArtikel
{
    class Artikel
    {
        private String artNr;
        private String artBez;
        private int bestand;
        private int bestellbestand;
        private decimal ePreis;
        private decimal vPreis;
        private int bestellmenge;

        public string ArtNr
        {
            get
            {
                return artNr;
            }

            set
            {
                artNr = value;
            }
        }

        public string ArtBez
        {
            get
            {
                return artBez;
            }

            set
            {
                artBez = value;
            }
        }

        public int Bestand
        {
            get
            {
                return bestand;
            }

            set
            {
                bestand = value;
            }
        }

        public int Bestellbestand
        {
            get
            {
                return bestellbestand;
            }

            set
            {
                bestellbestand = value;
            }
        }

        public decimal EPreis
        {
            get
            {
                return ePreis;
            }

            set
            {
                ePreis = value;
            }
        }

        public decimal VPreis
        {
            get
            {
                return vPreis;
            }

            set
            {
                vPreis = value;
            }
        }

        public int Bestellmenge
        {
            get
            {
                return bestellmenge;
            }

            set
            {
                bestellmenge = value;
            }
        }

        public void nachbestellen()
        {
            if(Bestand <= Bestellbestand)
            {
                // Nachbestellen
                Bestand += Bestellmenge;
            }
        }
        public void verkaufen(int m)
        {
            // verkaufen
            Bestand -= m;
        }

        public override string ToString()
        {
            return String.Format("{0}", ArtBez);
        }
    }
}
