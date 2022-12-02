using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string sifre = txtSifre.Text;

            if (ad.Equals("admin") && sifre.Equals("123"))
            {
                MessageBox.Show(text:"giriş başarılı");
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalıdır!Tekrar deneyiniz.");
            }
        }
    }
}
