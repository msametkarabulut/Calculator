using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 9;
        }

        private void bTopla_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt16(tSonuc.Text.Length);
            if (uzunluk >0 && tSonuc.Text[uzunluk-1].ToString() != "+")
            {
                if (tSonuc.Text[uzunluk-1].ToString() == "-")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "+";
                }
                else if (tSonuc.Text[uzunluk-1].ToString() == "/")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "+";
                }
                else if (tSonuc.Text[uzunluk-1].ToString() == "x")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "+";
                }
                else
                {
                    tSonuc.Text += "+";
                }
            }
            
        }

        private void bCikar_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt16(tSonuc.Text.Length);
            if (uzunluk > 0 && tSonuc.Text[uzunluk - 1].ToString() != "-")
            {
                if (tSonuc.Text[uzunluk - 1].ToString() == "+")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "-";
                }
                else if (tSonuc.Text[uzunluk - 1].ToString() == "/")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "-";
                }
                else if (tSonuc.Text[uzunluk - 1].ToString() == "x")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "-";
                }
                else
                {
                    tSonuc.Text += "-";
                }
            }
        }

        private void bCarp_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt16(tSonuc.Text.Length);
            if (uzunluk > 0 && tSonuc.Text[uzunluk - 1].ToString() != "x")
            {
                if (tSonuc.Text[uzunluk - 1].ToString() == "+")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "x";
                }
                else if (tSonuc.Text[uzunluk - 1].ToString() == "/")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "x";
                }
                else if (tSonuc.Text[uzunluk - 1].ToString() == "-")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "x";
                }
                else
                {
                    tSonuc.Text += "x";
                }
            }
        }

        private void bBol_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt16(tSonuc.Text.Length);
            if (uzunluk > 0 && tSonuc.Text[uzunluk - 1].ToString() != "/")
            {
                if (tSonuc.Text[uzunluk - 1].ToString() == "+")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "/";
                }
                else if (tSonuc.Text[uzunluk - 1].ToString() == "-")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "/";
                }
                else if (tSonuc.Text[uzunluk - 1].ToString() == "x")
                {
                    tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
                    tSonuc.Text += "/";
                }
                else
                {
                    tSonuc.Text += "/";
                }
            }
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            if(tSonuc.Text != "")
            {
                int uzunluk = Convert.ToInt16(tSonuc.Text.Length);
                tSonuc.Text = tSonuc.Text.Remove(uzunluk - 1);
            }
        }

        private void bEsittir_Click(object sender, EventArgs e)
        {
            string ifade = tSonuc.Text; 
            
            
            if (string.IsNullOrWhiteSpace(ifade) || "+-x/".Contains(ifade.Last()))
                return;
            
            ifade = ifade.Replace("x", "*");
            if (System.Text.RegularExpressions.Regex.IsMatch(ifade, "[a-zA-Z]"))
            {
                tSonuc.Text = "Hata!";
                return;
            }

            var sonuc = new DataTable().Compute(ifade, null);
            double sayi = Convert.ToDouble(sonuc);
            
            tSonuc.Text = Math.Round(sayi,2).ToString();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            tSonuc.Text += 0;
        }

        private void bTumu_Click(object sender, EventArgs e)
        {
            tSonuc.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tSonuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
