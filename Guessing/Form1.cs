using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing
{
    public partial class Form1 : Form
    {
        public bool CzyPoprawna = false;
        public int i = 0;
        public int IlePoprawnych = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void A_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 15;
            Random rand = new Random();
            while (i < 15)
            {


                int num = rand.Next(1, 3);
                switch (num)
                {
                    case 1:
                        CzyPoprawna = true;
                        IlePoprawnych++;
                        break;
                    case 2:
                        CzyPoprawna = false;
                        break;
                }
                break;
            }
            i++;
            progressBar1.Value = IlePoprawnych;
            if (i == 15)
            {
                double procent = (IlePoprawnych / 15.0) * 100;
                procent = Math.Round(procent, 2);
                MessageBox.Show("Liczba poprawnych odpowiedzi na 15 możliwych: " + IlePoprawnych + "\n" + "Procent poprawności: " + procent + "%");
                Reset();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 15;
            Random rand2 = new Random();
            while (i < 15)
            {


                int num = rand2.Next(1, 3);
                switch (num)
                {
                    case 1:
                        CzyPoprawna = true;
                        IlePoprawnych++;
                        break;
                    case 2:
                        CzyPoprawna = false;
                        break;
                }
                break;
            }
            i++;
            progressBar1.Value = IlePoprawnych;
            if (i == 15)
            {
                double procent = (IlePoprawnych / 15.0) * 100;
                procent = Math.Round(procent, 2);
                MessageBox.Show("Liczba poprawnych odpowiedzi na 15 możliwych: " + IlePoprawnych + "\n" + "Procent poprawności: " + procent + "%");
                Reset();
            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 15;
            Random rand3 = new Random();
            while (i < 15)
            {


                int num = rand3.Next(1, 3);
                switch (num)
                {
                    case 1:
                        CzyPoprawna = true;
                        IlePoprawnych++;
                        break;
                    case 2:
                        CzyPoprawna = false;
                        break;
                }
                break;
            }
            i++;
            progressBar1.Value = IlePoprawnych;
            if (i == 15)
            {
                double procent = (IlePoprawnych / 15.0) * 100;
                procent = Math.Round(procent,2);
                MessageBox.Show("Liczba poprawnych odpowiedzi na 15 możliwych: " + IlePoprawnych + "\n" + "Procent poprawności: " + procent + "%");
                Reset();
            }

        }

        private void D_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 15;
            Random rand4 = new Random();
            while (i < 15)
            {


                int num = rand4.Next(1, 3);
                switch (num)
                {
                    case 1:
                        CzyPoprawna = true;
                        IlePoprawnych++;
                        break;
                    case 2:
                        CzyPoprawna = false;
                        break;
                }
                break;
            }
            i++;
            progressBar1.Value = IlePoprawnych;
            if (i == 15)
            {
                double procent = (IlePoprawnych / 15.0) * 100;
                procent = Math.Round(procent, 2);
                MessageBox.Show("Liczba poprawnych odpowiedzi na 15 możliwych: " + IlePoprawnych + "\n" + "Procent poprawności: " + procent + "%");
                Reset();
            }
        }
        

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        public void Reset()
        {
            progressBar1.ResetText();
            i = 0;
            CzyPoprawna = false;
            IlePoprawnych = 0;
        }
    }
}
