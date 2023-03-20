using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Kirtasiye_Otomasyon_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrKayanYazi.Start();
            tmrSure.Start();
        }
        Random rnd = new Random();
        private void tmrKayanYazi_Tick(object sender, EventArgs e)
        {
            string yazi = lblBaslik.Text;
            string ilkHarf = yazi.Substring(0, 1);
            yazi = yazi.Remove(0, 1);
            yazi += ilkHarf;
            lblBaslik.Text = yazi;
        }
        int step,progvalue = 0;
        int yuzde = 100;
        private void tmrSure_Tick(object sender, EventArgs e)
        {
            step = rnd.Next(5, 11);
            progvalue += step;
            if (progvalue > 100)
                progvalue = 100;
            if ((yuzde - progvalue) <=10)
            {
                tmrOpacity.Start();
            }
            lblKalan.Text = "% " + (yuzde - progvalue) + " KALDI";
            prbYukle.Value = progvalue;
        }
        frm_kirtasiye frmKirtasiye = new frm_kirtasiye();
        private void tmrOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 0) 
            {
                this.Opacity -= 0.05;
            }
            else
            {
                tmrOpacity.Stop();
                tmrSure.Stop();
                tmrKayanYazi.Stop();
                this.Hide();
                frmKirtasiye.Show();
            }
        }
    }
}
