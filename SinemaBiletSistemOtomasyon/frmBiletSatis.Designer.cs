namespace SinemaBiletSistemOtomasyon
{
    partial class frmBiletSatis
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
            this.btnOnaylaveSatınAl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.btnFilmlerGeri = new System.Windows.Forms.Button();
            this.picSecilenAfis = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSeanslar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSecilenAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOnaylaveSatınAl
            // 
            this.btnOnaylaveSatınAl.BackColor = System.Drawing.Color.DarkRed;
            this.btnOnaylaveSatınAl.FlatAppearance.BorderSize = 0;
            this.btnOnaylaveSatınAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnaylaveSatınAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaylaveSatınAl.ForeColor = System.Drawing.Color.White;
            this.btnOnaylaveSatınAl.Location = new System.Drawing.Point(1178, 602);
            this.btnOnaylaveSatınAl.Name = "btnOnaylaveSatınAl";
            this.btnOnaylaveSatınAl.Size = new System.Drawing.Size(146, 68);
            this.btnOnaylaveSatınAl.TabIndex = 4;
            this.btnOnaylaveSatınAl.Text = "Koltuk Seçimine İlerle ➔";
            this.btnOnaylaveSatınAl.UseVisualStyleBackColor = false;
            this.btnOnaylaveSatınAl.Click += new System.EventHandler(this.btnOnaylaveSatınAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(798, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seans Seçiniz:";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmAdi.Location = new System.Drawing.Point(44, -4);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(82, 31);
            this.lblFilmAdi.TabIndex = 9;
            this.lblFilmAdi.Text = "label3";
            this.lblFilmAdi.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnFilmlerGeri
            // 
            this.btnFilmlerGeri.BackColor = System.Drawing.Color.DarkRed;
            this.btnFilmlerGeri.FlatAppearance.BorderSize = 0;
            this.btnFilmlerGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmlerGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmlerGeri.ForeColor = System.Drawing.Color.White;
            this.btnFilmlerGeri.Location = new System.Drawing.Point(30, 632);
            this.btnFilmlerGeri.Name = "btnFilmlerGeri";
            this.btnFilmlerGeri.Size = new System.Drawing.Size(201, 38);
            this.btnFilmlerGeri.TabIndex = 11;
            this.btnFilmlerGeri.Text = "❮ Filmlere Geri Dön";
            this.btnFilmlerGeri.UseVisualStyleBackColor = false;
            this.btnFilmlerGeri.Click += new System.EventHandler(this.btnFilmlerGeri_Click);
            // 
            // picSecilenAfis
            // 
            this.picSecilenAfis.Location = new System.Drawing.Point(30, 48);
            this.picSecilenAfis.Name = "picSecilenAfis";
            this.picSecilenAfis.Size = new System.Drawing.Size(709, 556);
            this.picSecilenAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecilenAfis.TabIndex = 13;
            this.picSecilenAfis.TabStop = false;
            this.picSecilenAfis.Click += new System.EventHandler(this.picSecilenAfis_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(963, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(797, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tarih Seçiniz:";
            // 
            // cmbSeanslar
            // 
            this.cmbSeanslar.BackColor = System.Drawing.Color.DarkRed;
            this.cmbSeanslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeanslar.FormattingEnabled = true;
            this.cmbSeanslar.Items.AddRange(new object[] {
            "11:00",
            "",
            "",
            "13:30",
            "",
            "",
            "16:00",
            "",
            "",
            "18:30",
            "",
            "",
            "21:00"});
            this.cmbSeanslar.Location = new System.Drawing.Point(972, 55);
            this.cmbSeanslar.Name = "cmbSeanslar";
            this.cmbSeanslar.Size = new System.Drawing.Size(132, 24);
            this.cmbSeanslar.TabIndex = 2;
            this.cmbSeanslar.SelectedIndexChanged += new System.EventHandler(this.cmbSeanslar_SelectedIndexChanged);
            // 
            // frmBiletSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1346, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.picSecilenAfis);
            this.Controls.Add(this.btnFilmlerGeri);
            this.Controls.Add(this.lblFilmAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOnaylaveSatınAl);
            this.Controls.Add(this.cmbSeanslar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBiletSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BİLET SATIŞ VE REZERVASYON İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmBiletSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSecilenAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOnaylaveSatınAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Button btnFilmlerGeri;
        private System.Windows.Forms.PictureBox picSecilenAfis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSeanslar;
    }
}