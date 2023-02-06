using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CorvinMoziUj
{
    internal class Mozi
    {

        List<Terem> termek = new List<Terem>();

        internal List<Terem> Termek { get => termek; set => termek = value; }

        public bool Mentes()
        {
            bool siker = false;
            try
            {

                File.Copy("CorvinMozi.csv", "CorvinMozi_" + DateTime.Now.ToString("yyyyMMdd_hhmm") + ".csv");
                using (StreamWriter sw = new StreamWriter("CorvinMozi.csv"))
                {
                    foreach (Terem item in termek)
                    {
                        sw.WriteLine(item.Nev);
                        sw.WriteLine(string.Join(";", item.Sorok, item.Szekek));
                        for (int i = 0; i < item.Ulesek.GetLength(0); i++)
                        {
                            for (int j = 0; j < item.Ulesek.GetLength(1); j++)
                            {
                                sw.WriteLine(string.Join(";", i, j, item.Ulesek[i, j]));
                            }
                        }
                        sw.WriteLine();
                    }
                }
                siker = true;

            }
            catch (Exception ex)
            {

                return false;

            }
            return siker;

        }

        public Mozi(string forras)
        {

            try
            {

                using (StreamReader sr = new StreamReader(forras))
                {

                    while (!sr.EndOfStream)
                    {

                        string MoziNev = sr.ReadLine();
                        string[] sor = sr.ReadLine().Split(';');
                        int sorokszama = int.Parse(sor[0]);
                        int szekekszama = int.Parse(sor[1]);
                        char[,] Ulesek = new char[sorokszama, szekekszama];
                        string ujSor = string.Empty;
                        while ((ujSor = sr.ReadLine()) != "")
                        {

                            sor = ujSor.Split(';');
                            Ulesek[int.Parse(sor[0]) - 1, int.Parse(sor[1]) - 1] = char.Parse(sor[2]);

                        }
                        termek.Add(new Terem(MoziNev, sorokszama, szekekszama, Ulesek));

                    }

                }

            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);

            }

        }

    }
}
