namespace partTambahan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.jenis = new System.Windows.Forms.ComboBox();
            this.masuk = new System.Windows.Forms.DateTimePicker();
            this.keluar = new System.Windows.Forms.DateTimePicker();
            this.harga = new System.Windows.Forms.TextBox();
            this.lama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARKIRAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kendaraan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Keluar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Masuk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lama Parkir";
            // 
            // jenis
            // 
            this.jenis.FormattingEnabled = true;
            this.jenis.Items.AddRange(new object[] {
            "Motor",
            "Mobil"});
            this.jenis.Location = new System.Drawing.Point(229, 65);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(201, 21);
            this.jenis.TabIndex = 6;
            this.jenis.SelectedIndexChanged += new System.EventHandler(this.jenis_SelectedIndexChanged);
            // 
            // masuk
            // 
            this.masuk.Location = new System.Drawing.Point(230, 92);
            this.masuk.Name = "masuk";
            this.masuk.Size = new System.Drawing.Size(200, 20);
            this.masuk.TabIndex = 7;
            this.masuk.ValueChanged += new System.EventHandler(this.masuk_ValueChanged);
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(230, 120);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(200, 20);
            this.keluar.TabIndex = 8;
            this.keluar.ValueChanged += new System.EventHandler(this.keluar_ValueChanged);
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(230, 170);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(200, 20);
            this.harga.TabIndex = 9;
            // 
            // lama
            // 
            this.lama.Location = new System.Drawing.Point(230, 144);
            this.lama.Name = "lama";
            this.lama.Size = new System.Drawing.Size(200, 20);
            this.lama.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.lama);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.masuk);
            this.Controls.Add(this.jenis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox jenis;
        private System.Windows.Forms.DateTimePicker masuk;
        private System.Windows.Forms.DateTimePicker keluar;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox lama;
    }
}

