using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CorvinMoziUj
{
    public partial class CorvinMozi : Form
    {
        Mozi mozi = new Mozi(@"CorvinMozi.csv");
        readonly int Buttonmer = 50;
        int Mozipar = 0;
        List<Image> mozikepek = new List<Image>();
        Form Statisztika = new Statisztika();
        public CorvinMozi()
        {
            InitializeComponent();
        }

        private void CorvinMozi_Load(object sender, EventArgs e)
        {

            mozikepek.Add(Image.FromFile(@"kepek\ures.png")); // üres
            mozikepek.Add(Image.FromFile(@"kepek\gyerek.png")); // gyerek jegy
            mozikepek.Add(Image.FromFile(@"kepek\felnott.png")); // felnőtt jegy

            PanelFriss();

        }

        void PanelFriss()
        {

            this.Text = mozi.Termek[Mozipar].Nev + "terem";
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
            for (int i = 0; i < mozi.Termek[Mozipar].Ulesek.GetLength(1); i++)
            {

                for (int j = 0; j < mozi.Termek[Mozipar].Ulesek.GetLength(0); j++)
                {

                    //létrehozás
                    Button g = new Button();
                    g.BackgroundImage = mozikepek[mozi.Termek[Mozipar].Ulesek[j, i]];
                    g.BackgroundImageLayout = ImageLayout.Stretch;
                    g.SetBounds(i * Buttonmer, j * Buttonmer, Buttonmer, Buttonmer);
                    //esemény kezelés
                    int sor = j;
                    int szek = i;
                    g.Click += (o, e) =>
                    {

                        mozi.Termek[Mozipar].UjSzek(sor, szek);
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

            if (mozi.Mentes())
            {

                MessageBox.Show("Sikeres mentés!", "Sikeres mentés!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                MessageBox.Show("Adatok mentése sikertelen!", "Sikertelen mentés!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

            }

        }

        private void Statiszgomb_Click(object sender, EventArgs e)
        {



        }

    }
}
