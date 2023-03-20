namespace WFA_Kirtasiye_Otomasyon_Odev
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.prbYukle = new System.Windows.Forms.ProgressBar();
            this.lblKalan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.tmrKayanYazi = new System.Windows.Forms.Timer(this.components);
            this.tmrOpacity = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(87, 33);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(228, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "- Güçlü Kalem Kırtasiye -";
            // 
            // prbYukle
            // 
            this.prbYukle.Location = new System.Drawing.Point(44, 98);
            this.prbYukle.Name = "prbYukle";
            this.prbYukle.Size = new System.Drawing.Size(328, 23);
            this.prbYukle.TabIndex = 1;
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(179, 73);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(0, 17);
            this.lblKalan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(130, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programımız Yükleniyor...";
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 500;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // tmrKayanYazi
            // 
            this.tmrKayanYazi.Interval = 500;
            this.tmrKayanYazi.Tick += new System.EventHandler(this.tmrKayanYazi_Tick);
            // 
            // tmrOpacity
            // 
            this.tmrOpacity.Tick += new System.EventHandler(this.tmrOpacity_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(410, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.prbYukle);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.ProgressBar prbYukle;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Timer tmrKayanYazi;
        private System.Windows.Forms.Timer tmrOpacity;
    }
}

