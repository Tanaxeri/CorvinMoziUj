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

        string nev;
        int sorok;
        int szekek;
        Image nevadokep;
        char[,] ulesek;

        public string Nev { get => nev; set => nev = value; }
        public int Sorok { get => sorok; set => sorok = value; }
        public int Szekek { get => szekek; set => szekek = value; }
        public char[,] Ulesek { get => ulesek; set => ulesek = value; }
        public Image Nevadokep { get => nevadokep; set => nevadokep = value; }

        public Terem(string nev, int sorok, int szekek, char[,] ulesek, Image nevadokep)
        {
            this.nev = nev;
            this.sorok = sorok;
            this.szekek = szekek;
            this.Ulesek = ulesek;
            this.nevadokep = nevadokep;

        }
        public int Bevetel()
        {
            int sum = 0;
            for (int i = 0; i < ulesek.GetLength(0); i++)
            {
                for (int j = 0; j < ulesek.GetLength(1); j++)
                {
                    switch (ulesek[i, j])
                    {
                        case 'F':
                            sum += 1700;
                            break;
                        case 'D':
                            sum += 1200;
                            break;
                        default:
                            break;
                    }
                }
            }
            return sum;
        }
        public double Kihasznaltsag()
        {
            double Ures = 0;
            for (int i = 0; i < ulesek.GetLength(0); i++)
            {
                for (int j = 0; j < ulesek.GetLength(1); j++)
                {
                    if (ulesek[i, j] == '\0')
                    {
                        Ures++;
                    }
                }
            }
            return Ures / (ulesek.GetLength(0) * ulesek.GetLength(1));
        }

        public bool KetUres(out string TeremNev, out int Sor, out int Szek1, out int Szek2)
        {
            bool van = false;
            TeremNev = null;
            Sor = 0;
            Szek1 = 0;
            Szek2 = 0;
            for (int i = 0; i < ulesek.GetLength(0); i++)
            {
                for (int j = 0; j < ulesek.GetLength(1) - 1; j++)
                {
                    if (ulesek[i, j] == '\0' && ulesek[i, j + 1] == '\0')
                    {
                        van = true;
                        TeremNev = nev;
                        Sor = i;
                        Szek1 = j;
                        Szek2 = j + 1;
                    }
                }
            }
            return van;
        }

    }
}
