using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controllo_caratteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string parola = txt_n1.Text;
            bool lettereIdentiche = false;
            int lunghezza = parola.Length, vocali = 0;
           
            // controllo delle vocali
            for (int i = 0; i < lunghezza; i++)
            {
                if (parola[i] == 'a' || parola[i] == 'e' || parola[i] == 'i' || parola[i] == 'o' || parola[i] == 'u')
                {
                    vocali ++;
                }
                // controllo delle lettere identiche
                for (int j = i + 1; j < lunghezza; j++)
                {
                    if (parola[i] == parola[j])
                    {
                        lettereIdentiche = true;
                    }

                }
                

            }
            lbl_n1.Text = "Vocali trovate: " + vocali;

            if (lettereIdentiche==true)
            {
                lbl_n2.Text = "Ci sono lettere identiche";
            }
            else
            {
                lbl_n2.Text = "Non ci sono lettere identiche";
            }
        }
    }
}
