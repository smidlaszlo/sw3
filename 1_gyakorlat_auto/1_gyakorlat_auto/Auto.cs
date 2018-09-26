using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autonevter
{
    class Auto
    {
        private string gyarto;
        private string tipus;
        //futasi ideju konstans
        private readonly int evjarat;
        //forditasi ideju konstans
        //private const int konstans = 1 ;
        private string motortipus;
        private string uzemanyag;
        private double atlagfogyasztas;

        public double Atlagfogyasztas
        {
            get { return atlagfogyasztas; }
            set { atlagfogyasztas = value; }
        }


        public string Uzemanyag
        {
            get { return uzemanyag; }
            set { uzemanyag = value; }
        }


        public string Motortipus
        {
            get { return motortipus; }
            set { motortipus = value; }
        }


        public string Tipus
        {
            get { return tipus; }
            //set { tipus = value; }
        }


        public string Gyarto
        {
            get { return gyarto; }
            //set { gyarto = value; }
        }

        public Auto(string gyarto, string tipus, int evjarat,
            string motortipus, string uzemanyag, double atlagfogyasztas)
        {
            this.gyarto = gyarto;
            this.tipus = tipus;
            this.evjarat = evjarat;
            this.motortipus = motortipus;
            this.uzemanyag = uzemanyag;
            this.atlagfogyasztas = atlagfogyasztas;
        }

        public Auto(string gyarto, string tipus, int evjarat,
            string motortipus)
        {
            this.gyarto = gyarto;
            this.tipus = tipus;
            this.evjarat = evjarat;
            this.motortipus = motortipus;
            this.uzemanyag = "benzin";

            switch (motortipus)
            {
                case "1.4":
                    this.atlagfogyasztas = 6.5;
                    break;

                case "1.8":
                    this.atlagfogyasztas = 7.5;
                    break;

                case "2.0":
                    this.atlagfogyasztas = 8;
                    break;

                default:
                    break;
            }

        }

        public void Motorcsere(string motortipus, string uzemanyag, double atlagfogyasztas)
        {
            this.motortipus = motortipus;
            this.uzemanyag = uzemanyag;
            this.atlagfogyasztas = atlagfogyasztas;
        }

        /// <summary>
        /// uzemanyag fogyasztas szamitasa
        /// </summary>
        /// <param name="uzemanyag">uzemanyag literben</param>
        /// <param name="tavolsag">tavolsag km-ben</param>
        /// <returns>fogyasztas</returns>
        public double Fogyasztas(double uzemanyag, int tavolsag)
        {
            return uzemanyag / tavolsag * 100;
        }

        public bool AtlagfogyasztasOsszehasonlit(double uzemanyag, int tavolsag)
        {
            return Fogyasztas(uzemanyag, tavolsag) <= atlagfogyasztas;
        }

        /// <summary>
        /// uzemanyag kotlsegenek szamitasa
        /// </summary>
        /// <param name="tavolsag">tavolsag km-ben</param>
        /// <param name="uzemanyagAra">uzemanyag literenkenti ara Ft-ban</param>
        /// <returns>uzemanyag osszkoltseg</returns>
        public int UzemanyagKoltsegSzamitas(int tavolsag, int uzemanyagAra)
        {
            return (int)(atlagfogyasztas * tavolsag * uzemanyagAra / 100);
        }

        public override string ToString()
        {
            return "Auto: " 
                + Gyarto + ", " 
                + Tipus + ", " 
                + evjarat + ", " 
                + Motortipus + ", " 
                + Uzemanyag + ", " 
                + Atlagfogyasztas;
        }
    }
}
