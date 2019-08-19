namespace latihan_kereta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.TextBox();
            this.nama_kereta = new System.Windows.Forms.TextBox();
            this.harga_tiket = new System.Windows.Forms.TextBox();
            this.jenis_kereta = new System.Windows.Forms.ComboBox();
            this.jumlah_tiket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jp_anak = new System.Windows.Forms.CheckBox();
            this.jp_dewasa = new System.Windows.Forms.CheckBox();
            this.jp_lansia = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.biaya_asuransi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.biaya = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.total_bayar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.potongan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.jumlah_uang = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ppn = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.kembali = new System.Windows.Forms.TextBox();
            this.proses = new System.Windows.Forms.Button();
            this.bersih = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::latihan_kereta.Properties.Resources.fast_train;
            this.pictureBox1.Location = new System.Drawing.Point(51, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stasiun Kereta Listrik BSI";
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(655, 96);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(99, 20);
            this.tanggal.TabIndex = 2;
            // 
            // nama_kereta
            // 
            this.nama_kereta.Location = new System.Drawing.Point(655, 136);
            this.nama_kereta.Name = "nama_kereta";
            this.nama_kereta.Size = new System.Drawing.Size(99, 20);
            this.nama_kereta.TabIndex = 3;
            this.nama_kereta.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // harga_tiket
            // 
            this.harga_tiket.Location = new System.Drawing.Point(655, 174);
            this.harga_tiket.Name = "harga_tiket";
            this.harga_tiket.Size = new System.Drawing.Size(99, 20);
            this.harga_tiket.TabIndex = 4;
            // 
            // jenis_kereta
            // 
            this.jenis_kereta.FormattingEnabled = true;
            this.jenis_kereta.Location = new System.Drawing.Point(387, 136);
            this.jenis_kereta.Name = "jenis_kereta";
            this.jenis_kereta.Size = new System.Drawing.Size(121, 21);
            this.jenis_kereta.TabIndex = 5;
            // 
            // jumlah_tiket
            // 
            this.jumlah_tiket.Location = new System.Drawing.Point(387, 174);
            this.jumlah_tiket.Name = "jumlah_tiket";
            this.jumlah_tiket.Size = new System.Drawing.Size(121, 20);
            this.jumlah_tiket.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Kereta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harga Tiket";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // jp_anak
            // 
            this.jp_anak.AutoSize = true;
            this.jp_anak.Location = new System.Drawing.Point(70, 248);
            this.jp_anak.Name = "jp_anak";
            this.jp_anak.Size = new System.Drawing.Size(51, 17);
            this.jp_anak.TabIndex = 9;
            this.jp_anak.Text = "Anak";
            this.jp_anak.UseVisualStyleBackColor = true;
            // 
            // jp_dewasa
            // 
            this.jp_dewasa.AutoSize = true;
            this.jp_dewasa.Location = new System.Drawing.Point(70, 271);
            this.jp_dewasa.Name = "jp_dewasa";
            this.jp_dewasa.Size = new System.Drawing.Size(65, 17);
            this.jp_dewasa.TabIndex = 10;
            this.jp_dewasa.Text = "Dewasa";
            this.jp_dewasa.UseVisualStyleBackColor = true;
            // 
            // jp_lansia
            // 
            this.jp_lansia.AutoSize = true;
            this.jp_lansia.Location = new System.Drawing.Point(70, 294);
            this.jp_lansia.Name = "jp_lansia";
            this.jp_lansia.Size = new System.Drawing.Size(57, 17);
            this.jp_lansia.TabIndex = 11;
            this.jp_lansia.Text = "Lansia";
            this.jp_lansia.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jenis Penumpang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Biaya Asuransi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Jenis Kereta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Jumlah Tiket";
            // 
            // biaya_asuransi
            // 
            this.biaya_asuransi.Location = new System.Drawing.Point(250, 220);
            this.biaya_asuransi.Name = "biaya_asuransi";
            this.biaya_asuransi.Size = new System.Drawing.Size(99, 20);
            this.biaya_asuransi.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(0, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(800, 2);
            this.label8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(368, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 500);
            this.label9.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Biaya";
            // 
            // biaya
            // 
            this.biaya.Location = new System.Drawing.Point(457, 223);
            this.biaya.Name = "biaya";
            this.biaya.Size = new System.Drawing.Size(99, 20);
            this.biaya.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(586, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total Bayar";
            // 
            // total_bayar
            // 
            this.total_bayar.Location = new System.Drawing.Point(655, 223);
            this.total_bayar.Name = "total_bayar";
            this.total_bayar.Size = new System.Drawing.Size(99, 20);
            this.total_bayar.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Potongan";
            // 
            // potongan
            // 
            this.potongan.Location = new System.Drawing.Point(457, 265);
            this.potongan.Name = "potongan";
            this.potongan.Size = new System.Drawing.Size(99, 20);
            this.potongan.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(586, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Jumlah Uang";
            // 
            // jumlah_uang
            // 
            this.jumlah_uang.Location = new System.Drawing.Point(655, 268);
            this.jumlah_uang.Name = "jumlah_uang";
            this.jumlah_uang.Size = new System.Drawing.Size(99, 20);
            this.jumlah_uang.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(388, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "PPN";
            // 
            // ppn
            // 
            this.ppn.Location = new System.Drawing.Point(457, 312);
            this.ppn.Name = "ppn";
            this.ppn.Size = new System.Drawing.Size(99, 20);
            this.ppn.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(586, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Kembali";
            // 
            // kembali
            // 
            this.kembali.Location = new System.Drawing.Point(655, 315);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(99, 20);
            this.kembali.TabIndex = 29;
            // 
            // proses
            // 
            this.proses.Location = new System.Drawing.Point(457, 387);
            this.proses.Name = "proses";
            this.proses.Size = new System.Drawing.Size(75, 23);
            this.proses.TabIndex = 31;
            this.proses.Text = "Proses";
            this.proses.UseVisualStyleBackColor = true;
            this.proses.Click += new System.EventHandler(this.Proses_Click);
            // 
            // bersih
            // 
            this.bersih.Location = new System.Drawing.Point(556, 387);
            this.bersih.Name = "bersih";
            this.bersih.Size = new System.Drawing.Size(75, 23);
            this.bersih.TabIndex = 32;
            this.bersih.Text = "Bersih";
            this.bersih.UseVisualStyleBackColor = true;
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(655, 387);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(75, 23);
            this.keluar.TabIndex = 33;
            this.keluar.Text = "Keluar";
            this.keluar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.bersih);
            this.Controls.Add(this.proses);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ppn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.jumlah_uang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.potongan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.total_bayar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.biaya);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.biaya_asuransi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jp_lansia);
            this.Controls.Add(this.jp_dewasa);
            this.Controls.Add(this.jp_anak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jumlah_tiket);
            this.Controls.Add(this.jenis_kereta);
            this.Controls.Add(this.harga_tiket);
            this.Controls.Add(this.nama_kereta);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tanggal;
        private System.Windows.Forms.TextBox nama_kereta;
        private System.Windows.Forms.TextBox harga_tiket;
        private System.Windows.Forms.ComboBox jenis_kereta;
        private System.Windows.Forms.TextBox jumlah_tiket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox jp_anak;
        private System.Windows.Forms.CheckBox jp_dewasa;
        private System.Windows.Forms.CheckBox jp_lansia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox biaya_asuransi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox biaya;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox total_bayar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox potongan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox jumlah_uang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ppn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox kembali;
        private System.Windows.Forms.Button proses;
        private System.Windows.Forms.Button bersih;
        private System.Windows.Forms.Button keluar;
    }
}

