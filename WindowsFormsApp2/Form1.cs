using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndinle_Click(object sender, EventArgs e)
        {
            string adi, soyadi;
            string okul;
            int a = 10;
            int b = 20;
            double c = 30;
            decimal d=40;
            bool durum = true;
            int toplam = a + b;
            float kesirli = 35;
            string meslek = "Yazılımcı";
            int sayi, sayi2, sayi3;
            MessageBox.Show("Mesajımızı", "Başlık", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
