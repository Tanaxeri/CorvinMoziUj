using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CorvinMoziUj
{
    public partial class CorvinMozi : Form
    {
        Mozi mozi = new Mozi(@"CorvinMozi.csv");
        readonly int mer = 25; //méret 
        int Mozipar = 0; //Aktuális mozi indexe
        Image[] kepek = new Image[] { Image.FromFile(@"kepek\ures.png"), Image.FromFile(@"kepek\gyerek.png"), Image.FromFile(@"kepek\felnott.png") };
        public CorvinMozi()
        {
            InitializeComponent();
        }

        private void CorvinMozi_Load(object sender, EventArgs e)
        {

            PanelFriss();

        }

        void PanelFriss()
        {

            this.Text = mozi.Termek[Mozipar].Nev + " terem";
            if (Mozipar == 0)
            {

                Balgomb.Enabled = false;
                Balgomb.Hide();

            }
            else if (Mozipar == mozi.Termek.Count - 1)
            {

                Jobbgomb.Enabled = false;
                Jobbgomb.Hide();

            }
            else
            {

                Balgomb.Enabled = true;
                Balgomb.Show();
                Jobbgomb.Enabled = true;
                Jobbgomb.Show();

            }
            mozikep.BackgroundImage = mozi.Termek[Mozipar].Nevadokep;
            mozikep.BackgroundImageLayout = ImageLayout.Stretch;
            MoziPanel.Controls.Clear();
            for (int i = 0; i < mozi.Termek[Mozipar].Sorok; i++)
            {

                for (int j = 0; j < mozi.Termek[Mozipar].Szekek; j++)
                {

                    PictureBox g = new PictureBox();
                    g.SetBounds(j * mer, i * mer, mer, mer);
                    g.Padding = new Padding(3);
                    switch (mozi.Termek[Mozipar].Ulesek[i, j])
                    {
                        case 'F':
                            g.Image = kepek[2];
                            break;
                        case 'D':
                            g.Image = kepek[1];
                            break;
                        default:
                            g.Image = kepek[0];
                            break;
                    }
                    g.SizeMode = PictureBoxSizeMode.StretchImage;
                    int sor = i;
                    int szek = j;
                    g.Click += (e, o) =>
                    {

                        switch (mozi.Termek[Mozipar].Ulesek[sor, szek])
                        {
                            case 'F':
                                mozi.Termek[Mozipar].Ulesek[sor, szek] = '0';
                                break;
                            case 'D':
                                mozi.Termek[Mozipar].Ulesek[sor, szek] = 'F';
                                break;
                            default:
                                mozi.Termek[Mozipar].Ulesek[sor, szek] = 'D';
                                break;
                        }
                        PanelFriss();

                    };
                    MoziPanel.Controls.Add(g);

                }

            }            

        }

        private void Balgomb_Click(object sender, EventArgs e)
        {

            Mozipar--;
            PanelFriss();

        }

        private void Jobbgomb_Click(object sender, EventArgs e)
        {

            Mozipar++;
            PanelFriss();

        }

        private void MentesGomb_Click(object sender, EventArgs e)
        {

            mozi.Mentes();

        }

        private void Statiszgomb_Click(object sender, EventArgs e)
        {

            string fajlnev = "statisztika_" + DateTime.Today.ToString("yyyyMMdd") + ".txt";
            double sum = 0;
            string Sor;
            using (StreamWriter sw = new StreamWriter(fajlnev))
            {
                //-- Bevételek kiiratása --------------------
                sw.WriteLine(vonal());
                sw.WriteLine("Az egyes termek bevétele a jegyárusításból:\n");
                sw.WriteLine(vonal());
                foreach (Terem item in mozi.Termek)
                {
                    double Bevetel = item.Bevetel();
                    sum += Bevetel;
                    Sor = $"{item.Nev,25} terem: {Bevetel.ToString("#,##0"),8} Ft";
                    sw.WriteLine(Sor);
                }
                sw.WriteLine(vonal());
                sw.WriteLine($"{"összesen".PadLeft(31)}: {sum.ToString("#,##0"),8} Ft");

                //-- Kihasználtság kiiratása
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine(vonal());
                sw.WriteLine("Az üres helyek és az összes helyek aránya:");
                sw.WriteLine(vonal());
                foreach (Terem item in mozi.Termek)
                {
                    sw.WriteLine($"{item.Nev,25} = {(item.Kihasznaltsag() * 100).ToString("0.00"),6}%");
                }

                sw.WriteLine("\n\n" + vonal());
                bool van = false;
                string TeremNev = null;
                int SzekSor = 0;
                int Szek1 = 0;
                int Szek2 = 0;
                foreach (Terem item in mozi.Termek)
                {
                    if (item.KetUres(out TeremNev, out SzekSor, out Szek1, out Szek2))
                    {
                        van = true;
                        break;
                    }
                }
                if (van)
                {
                    sw.WriteLine($"A {TeremNev} terem {SzekSor + 1}. széksorában szabad egymás mellett a {Szek1 + 1}. és {Szek2 + 1}. szék!");
                }
                else
                {
                    sw.WriteLine("Egyik teremben sem található egymás melletti két üres szék!");
                }
                sw.WriteLine(vonal());
            }
            Statisztika Statisztika = new Statisztika(fajlnev);
            Statisztika.ShowDialog();
        }

        string vonal()
        {
            return new string('-', 45);
        }

    }
}
