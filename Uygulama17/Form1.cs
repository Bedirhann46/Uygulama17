using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama17
{
    
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumara_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBoxNumara.Text, out int sonuc))
            {
                errorProvider.SetError(textBoxNumara, "");
            }
            else 
            { 
                e.Cancel = true;
                errorProvider.SetError(textBoxNumara, "hatalı numara girişi");
            }
        }

        private void textBoxAdSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxAdSoyad_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAdSoyad.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxAdSoyad, "ad soyad giriniz");
            }
        }

        private void textBoxDersNotu_Validating(object sender, CancelEventArgs e)
        {
     
            {
                int dersNotu;
                if (int.TryParse(textBoxDersNotu.Text, out dersNotu))
                {
                    if (dersNotu < 0 || dersNotu > 100)
                    {
                        e.Cancel = true;
                        errorProvider.SetError(textBoxDersNotu, "0 - 100 arasında değer giriniz.");
                    }
                    else
                    {
                        errorProvider.SetError(textBoxDersNotu, "");
                    }
                }
                else
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBoxDersNotu, "Sayısal değer giriniz.");
                }
            }
        }
    }
    
}
