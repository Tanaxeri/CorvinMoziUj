using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CorvinMoziUj
{
    internal class Terem
    {

        readonly string nev;
        readonly int sorok;
        readonly int szekek;
        private readonly Image nevadokep;
        char[,] ulesek;

        public string Nev => nev;

        public Image Nevadokep => nevadokep;

        public int Sorok => sorok;

        public int Szekek => szekek;

        public char[,] Ulesek { get => ulesek; set => ulesek = value; }

        public Terem(string nev, int sorok, int szekek, char[,] ulesek)
        {
            this.nev = nev;
            this.sorok = sorok;
            this.szekek = szekek;
            this.Ulesek = ulesek;
            this.nevadokep = Image.FromFile(@"kepek\" + nev + ".jpg");

        }

        public void UjSzek(int sorok, int szekek)
        {
            ulesek[sorok, szekek] = ((char)((ulesek[sorok, szekek] == 3) ? 0 : ++ulesek[sorok, szekek]));
        }

    }
}
