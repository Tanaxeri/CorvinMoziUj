using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace CorvinMoziUj
{
    internal class Mozi
    {

        List<Terem> termek = new List<Terem>();

        internal List<Terem> Termek { get => termek; set => termek = value; }
      
        public Mozi(string forras)
        {

            try
            {

                using (StreamReader sr = new StreamReader(forras))
                {

                    while (!sr.EndOfStream)
                    {

                        string MoziNev = sr.ReadLine();
                        Image nevadokep = Image.FromFile(@"kepek\" + MoziNev.Split()[0] + ".jpg");
                        string[] sor = sr.ReadLine().Split(';');
                        int sorokszama = int.Parse(sor[0]);
                        int szekekszama = int.Parse(sor[1]);
                        char[,] Ulesek = new char[sorokszama, szekekszama];
                        string ujSor = string.Empty;
                        while ((ujSor = sr.ReadLine()) != "" && ujSor != null)
                        {

                            sor = ujSor.Split(';');
                            Ulesek[int.Parse(sor[0]) - 1, int.Parse(sor[1]) - 1] = sor[2][0];

                        }
                        termek.Add(new Terem(MoziNev, sorokszama, szekekszama, Ulesek, nevadokep));

                    }

                }

            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message + "\n\nA program leáll!");
                Environment.Exit(0);

            }

        }

        public void Mentes()
        {
            string original = "CorvinMozi.csv";
            string output = "Backup_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
            try
            {
                File.Copy(original, output, true);
                using (StreamWriter sw = new StreamWriter(original))
                {
                    foreach (Terem item in termek)
                    {
                        sw.WriteLine(item.Nev);
                        sw.WriteLine(string.Join(";", item.Sorok, item.Szekek));
                        for (int i = 0; i < item.Ulesek.GetLength(0); i++)
                        {
                            for (int j = 0; j < item.Ulesek.GetLength(1); j++)
                            {
                                if (item.Ulesek[i, j] != '\0')
                                {
                                    sw.WriteLine(string.Join(";", i + 1, j + 1, item.Ulesek[i, j]));
                                }
                            }
                        }
                        sw.WriteLine();
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\nA mentés sikertelen!");
                return;
            }
            MessageBox.Show("Az adatok mentése sikeres!");
        }

    }
}
