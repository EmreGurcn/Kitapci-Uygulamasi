namespace KitapciUygulamasi.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.txtMahalle = new System.Windows.Forms.TextBox();
            this.txtAdresDetay = new System.Windows.Forms.TextBox();
            this.txtPostaKodu = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(543, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(152, 491);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(195, 83);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(378, 491);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(195, 83);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(604, 491);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(195, 83);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(830, 491);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(195, 83);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(152, 664);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(309, 31);
            this.txtSehir.TabIndex = 2;
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(152, 717);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(309, 31);
            this.txtIlce.TabIndex = 2;
            // 
            // txtMahalle
            // 
            this.txtMahalle.Location = new System.Drawing.Point(152, 766);
            this.txtMahalle.Name = "txtMahalle";
            this.txtMahalle.Size = new System.Drawing.Size(309, 31);
            this.txtMahalle.TabIndex = 2;
            // 
            // txtAdresDetay
            // 
            this.txtAdresDetay.Location = new System.Drawing.Point(152, 819);
            this.txtAdresDetay.Name = "txtAdresDetay";
            this.txtAdresDetay.Size = new System.Drawing.Size(309, 31);
            this.txtAdresDetay.TabIndex = 2;
            // 
            // txtPostaKodu
            // 
            this.txtPostaKodu.Location = new System.Drawing.Point(152, 865);
            this.txtPostaKodu.Name = "txtPostaKodu";
            this.txtPostaKodu.Size = new System.Drawing.Size(309, 31);
            this.txtPostaKodu.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 610);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(758, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(543, 432);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 946);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPostaKodu);
            this.Controls.Add(this.txtAdresDetay);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.txtMahalle);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnListele;
        private TextBox txtSehir;
        private TextBox txtIlce;
        private TextBox txtMahalle;
        private TextBox txtAdresDetay;
        private TextBox txtPostaKodu;
        private ComboBox comboBox1;
        private DataGridView dataGridView2;
    }
}