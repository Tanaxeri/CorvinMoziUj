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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CorvinMoziUj
{
    public partial class Statisztika : Form
    {
        string stat = null;
        public Statisztika(string fajlnev)
        {
            InitializeComponent();
            stat = fajlnev;
        }

        private void Statisztika_Load(object sender, EventArgs e)
        {

            Statiszttext.Font = new Font(FontFamily.GenericMonospace, Statiszttext.Font.Size);
            if (File.Exists(stat))
            {

                Statiszttext.Text = string.Join("\r\n", File.ReadAllLines(stat));

            }
            else
            {

                MessageBox.Show(stat + " fájl nem található!");
                return;

            }
            Statiszttext.Select(0, 0);

        }
    }
}
