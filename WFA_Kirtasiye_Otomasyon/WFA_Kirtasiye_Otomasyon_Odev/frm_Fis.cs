using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Kirtasiye_Otomasyon_Odev
{
    public partial class frm_Fis : Form
    {
        public frm_Fis()
        {
            InitializeComponent();
        }

        private void frm_Fis_Load(object sender, EventArgs e)
        {
            frm_kirtasiye frmKirtasiye = new frm_kirtasiye();
            int newHeight = 40 * frm_kirtasiye.labelAdet;
            panel1.MaximumSize = new Size(panel1.Width, 30 * panel1.Height + newHeight);
            panel1.Size = new Size(panel1.Width, panel1.Height + newHeight);
            panel2.MaximumSize = new Size(panel2.Width, panel2.Height + newHeight);
            panel2.Size = new Size(panel2.Width, panel2.Height + newHeight);
            this.Size = new Size(this.Width,this.Height + newHeight);
        }

        int sayac = 0;

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Kaydetmek İstermisiniz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                sayac++;
                int width = panel1.Size.Width;
                int height = panel1.Size.Height;

                Bitmap bm = new Bitmap(width, height);
                panel1.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

                saveFileDialog1.Filter = "JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName == null)
                {
                    bm.Save(@"C:\Users\Hp\Desktop\Fis" + sayac + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    bm.Save(saveFileDialog1.FileName + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            Application.Exit();
        }
        

        private void yazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yazdir = printDialog1.ShowDialog();
            if (yazdir == DialogResult.OK)
            {
                printDocument1.Print();
            }
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.panel1.Width, this.panel1.Height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
