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
    public partial class frm_kirtasiye : Form
    {
        public frm_kirtasiye()
        {
            InitializeComponent();
        }

        private void frm_kirtasiye_Load(object sender, EventArgs e)
        {
            tmrTitle.Start();
            txtSaat.Text = DateTime.Now.ToLongTimeString();
            tmrSaat.Start();
            cbTur.Text = "- Tür - ";
            cbCesit.Text = "- Çeşit -";
            cbCins.Text = "- Cins - ";
            cbCins.Enabled = false;
            cbCesit.Enabled = false;
            cbTur.Items.Add("Kırtasiye Ürünleri");
            cbTur.Items.Add("Ofis Ürünleri");
        }
        string yazi = "- Hoşgeldiniz -";
        int fiyat;
        private void tmrTitle_Tick(object sender, EventArgs e)
        {
            
            string ilkHarf = yazi.Substring(0, 1);
            yazi = yazi.Remove(0, 1);
            yazi += ilkHarf;
            this.Text = yazi;
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            txtSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void cbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTur.SelectedIndex >-1)
            {
                cbCesit.Enabled = true;
                cbCesit.Items.Clear(); // Çeşit comboboxı temizler.
                cbCesit.Text = "- Çeşit -";
                txtFiyat.Text = "0";
                txtTutar.Text = "0";
                nUdAdet.Value = 1;
                CbCesitContent();
                
            }
            
        }


        private void cbCesit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCesit.SelectedIndex > -1)
            {
                cbCins.Enabled = true;
                cbCins.Items.Clear();
                cbCins.Text = "- Cins -";
                txtFiyat.Text = "0";
                txtTutar.Text = "0";
                nUdAdet.Value = 1;
                CbCinsContent();
            }
        }


        private void nUdAdet_ValueChanged(object sender, EventArgs e)
        {
            txtTutar.Text = (fiyat * nUdAdet.Value).ToString();
        }

        private void cbCins_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbCinsFiyat();
            txtFiyat.Text = fiyat.ToString();
        }

        int toplamtutar;
        string secilenurun;
        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (cbTur.SelectedIndex == -1 || cbCesit.SelectedIndex == -1 || cbCins.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün Alanlarını Boş Bırakmayınız !");
            }
            else
            {
                MessageBox.Show("Satışınız Gerçekleştirildi...","Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                secilenurun = cbTur.SelectedItem + " - " + cbCesit.SelectedItem + " - " + cbCins.SelectedItem;
                lstUrun.Items.Add(secilenurun);
                lstAdet.Items.Add(nUdAdet.Value);
                lstTutar.Items.Add(txtTutar.Text);
                lstTarih.Items.Add(DateTime.Now);
                foreach (var item in lstTutar.Items)
                {
                    toplamtutar += Convert.ToInt32(item);
                }
                Temizle();
            }
        }



        #region Metotlar
        private void Temizle()
        {
            nUdAdet.Value = 1;
            cbCins.Enabled = false;
            cbCesit.Enabled = false;
            cbTur.Text = "- Tür - ";
            cbCesit.Items.Clear(); // Çeşit comboboxı temizler.
            cbCesit.Text = "- Çeşit -";
            cbCins.Items.Clear();
            cbCins.Text = "- Cins -";
            txtFiyat.Text = "0";
            txtTutar.Text = "0";
        }
        private void CbCesitContent()
        {


            if (cbTur.SelectedIndex == 0)// Kırtasiye Ürünleri 
            {
                cbCesit.Items.Add("Kalem");
                cbCesit.Items.Add("Silgi");
                cbCins.Items.Clear();// Cins comboboxı temizler
                cbCins.Text = "- Cins - ";

                if (cbCesit.SelectedIndex == 0) // Kırtasiye Ürünleri -> Kalem
                {
                    cbCins.Items.Add("Uçlu Kalem");
                    cbCins.Items.Add("Tükenmez Kalem");
                    cbCins.Items.Add("Pilot Kalem");
                }
                else // Kırtasiye Ürünleri -> Silgi
                {
                    cbCins.Items.Add("Resim Silgisi");
                    cbCins.Items.Add("Kokulu Silgi");
                    cbCins.Items.Add("Tahta Silgisi");
                }
            }
            else // Ofis Ürünleri
            {
                cbCesit.Items.Add("Kartuş");
                cbCesit.Items.Add("Mürekkep");
                cbCesit.Items.Add("Tahta Kalemi");
                cbCins.Items.Clear(); // Cins comboboxı temizler
                cbCins.Text = "- Cins - ";

                if (cbCesit.SelectedIndex == 0) // Ofis Ürünleri -> Kartuş
                {
                    cbCins.Items.Add("Renkli Kartuş");
                    cbCins.Items.Add("Siyah Beyaz Kartuş");

                }
                else if (cbCesit.SelectedIndex == 1) // Ofis Ürünleri -> Mürekkep
                {
                    cbCins.Items.Add("Dolma Kalem Mürekkebi");
                    cbCins.Items.Add("Çini Mürekkebi");
                }
                else // Ofis Ürünleri -> Tahta Kalemi
                {
                    cbCins.Items.Add("Edding Marka T.Kalemi");
                }
            }
        }
        private void CbCinsContent()
        {
            if (cbTur.SelectedIndex == 0)// Kırtasiye Ürünleri 
            {

                if (cbCesit.SelectedIndex == 0) // Kırtasiye Ürünleri -> Kalem
                {
                    cbCins.Items.Add("Uçlu Kalem");
                    cbCins.Items.Add("Tükenmez Kalem");
                    cbCins.Items.Add("Pilot Kalem");
                    switch (cbCins.SelectedIndex)
                    {
                        case 0: fiyat = 10; break;
                        case 1: fiyat = 15; break;
                        case 2: fiyat = 20; break;
                        default:
                            break;
                    }
                }
                else // Kırtasiye Ürünleri -> Silgi
                {
                    cbCins.Items.Add("Resim Silgisi");
                    cbCins.Items.Add("Kokulu Silgi");
                    cbCins.Items.Add("Tahta Silgisi");
                    switch (cbCins.SelectedIndex)
                    {
                        case 0: fiyat = 30; break;
                        case 1: fiyat = 35; break;
                        case 2: fiyat = 40; break;
                        default:
                            break;
                    }
                }
            }
            else // Ofis Ürünleri
            {

                if (cbCesit.SelectedIndex == 0) // Ofis Ürünleri -> Kartuş
                {
                    cbCins.Items.Add("Renkli Kartuş");
                    cbCins.Items.Add("Siyah Beyaz Kartuş");
                    switch (cbCins.SelectedIndex)
                    {
                        case 0: fiyat = 50; break;
                        case 1: fiyat = 100; break;
                        default:
                            break;
                    }

                }
                else if (cbCesit.SelectedIndex == 1) // Ofis Ürünleri -> Mürekkep
                {
                    cbCins.Items.Add("Dolma Kalem Mürekkebi");
                    cbCins.Items.Add("Çini Mürekkebi");
                    switch (cbCins.SelectedIndex)
                    {
                        case 0: fiyat = 70; break;
                        case 1: fiyat = 110; break;
                        default:
                            break;
                    }
                }
                else // Ofis Ürünleri -> Tahta Kalemi
                {
                    cbCins.Items.Add("Edding Marka T.Kalemi");
                    fiyat = 90;
                }
            }

        }
        private void CbCinsFiyat()
        {
            if (cbTur.SelectedIndex == 0)// Kırtasiye Ürünleri 
            {

                if (cbCesit.SelectedIndex == 0) // Kırtasiye Ürünleri -> Kalem
                {
                    switch (cbCins.SelectedIndex)
                    {
                        case 0: fiyat = 10; break;
                        case 1: fiyat = 15; break;
                        case 2: fiyat = 20; break;
                        default:
                            break;
                    }
                }
                else // Kırtasiye Ürünleri -> Silgi
                {
                    switch (cbCins.SelectedIndex)
                    {
                        case 0: fiyat = 30; break;
                        case 1: fiyat = 35; break;
                        case 2: fiyat = 40; break;
                        default:
                            break;
                    }
                }
            }
            else // Ofis Ürünleri
            {

                if (cbCesit.SelectedIndex == 0) // Ofis Ürünleri -> Kartuş
                {
                    switch (cbCins.SelectedIndex)
                    {
                        case 0: fiyat = 50; break;
                        case 1: fiyat = 100; break;
                        default:
                            break;
                    }

                }
                else if (cbCesit.SelectedIndex == 1) // Ofis Ürünleri -> Mürekkep
                {
                    switch (cbCins.SelectedIndex)
                    {
                        case 0: fiyat = 70; break;
                        case 1: fiyat = 110; break;
                        default:
                            break;
                    }
                }
                else // Ofis Ürünleri -> Tahta Kalemi
                {
                    fiyat = 90;
                }
            }
            txtTutar.Text = (fiyat * nUdAdet.Value).ToString();
        }
        #endregion
        private void btnHasilat_Click(object sender, EventArgs e)
        {
            
            txtHasilat.Text = toplamtutar.ToString();
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstUrun.Items.Count; i++)
            {
                if (lstUrun.GetSelected(i))
                {
                    lstAdet.SetSelected(i, true);
                    lstTutar.SetSelected(i, true);
                    lstTarih.SetSelected(i, true);
                }
                else
                {
                    lstAdet.SetSelected(i, false);
                    lstTutar.SetSelected(i, false);
                    lstTarih.SetSelected(i, false);
                }
            }
            
        }
        frm_Fis fisForm = new frm_Fis();
        public static int sayac = 0;
        string fisYazi;
        int fisToplam;
        public static int labelAdet;
        private void btnFis_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedIndex > -1)
            {
                this.Hide();
                sayac++;
                fisForm.lblTarih.Text = DateTime.Now.ToShortDateString();
                fisForm.lblSaat.Text = DateTime.Now.ToShortTimeString();
                fisForm.lblFisNo.Text = sayac.ToString();
                int i = 0;
                foreach (var item in lstUrun.SelectedItems)
                {
                    int index = lstUrun.Items.IndexOf(item);
                    fisToplam += Convert.ToInt32(lstTutar.Items[index]);
                    fisYazi += "\n\n" + item + "\n(" + lstAdet.Items[index] + " ADET)                                                                         *" + lstTutar.Items[index];
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Text = fisYazi;
                    lbl.Margin = new Padding(0);
                    lbl.Tag = i++;
                    labelAdet = i;

                    fisForm.panel2.Controls.Add(lbl);
                }
                fisForm.lblTopkdv.Text = (fisToplam * 0.18).ToString();
                fisForm.lblToplam.Text = fisToplam.ToString();
                fisForm.Show();
            }
            else
            {
                MessageBox.Show("Seçili Ürün Bulunamadı!");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedIndex > -1)
            {
                if (MessageBox.Show("Silmek / İptal Etmek İstediğinize Emin Misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                {
                    for (int i = 0; i < lstUrun.Items.Count; i++)
                    {
                        if (lstUrun.GetSelected(i))
                        {
                            lstUrun.Items.RemoveAt(i);
                            lstAdet.Items.RemoveAt(i);
                            lstTutar.Items.RemoveAt(i);
                            lstTarih.Items.RemoveAt(i);
                        }
                    }
                    MessageBox.Show("Seçilen Satış İşlemi / İşlemleri Silindi / İptal Edildi..");
                }
            }
            else
            {
                MessageBox.Show("Seçili Ürün Bulunamadı!");
            }
        }
    }
}
