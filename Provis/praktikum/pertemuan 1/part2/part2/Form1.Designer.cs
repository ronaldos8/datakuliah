namespace part2
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
            this.nomor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.TextBox();
            this.ongkos = new System.Windows.Forms.TextBox();
            this.kepada = new System.Windows.Forms.TextBox();
            this.jenis = new System.Windows.Forms.ComboBox();
            this.asuransi = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hitung = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.berat = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nomor
            // 
            this.nomor.Location = new System.Drawing.Point(190, 55);
            this.nomor.Name = "nomor";
            this.nomor.Size = new System.Drawing.Size(200, 20);
            this.nomor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nomor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "E.X.P.E.D.I.S.I P.A.K.E.T";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(317, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "JEJEN EXPRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kepada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ongkos Kirim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Berat (Kg)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Jenis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Alamat";
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(190, 110);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.alamat.Size = new System.Drawing.Size(200, 99);
            this.alamat.TabIndex = 2;
            // 
            // ongkos
            // 
            this.ongkos.Location = new System.Drawing.Point(190, 275);
            this.ongkos.Name = "ongkos";
            this.ongkos.ReadOnly = true;
            this.ongkos.Size = new System.Drawing.Size(200, 20);
            this.ongkos.TabIndex = 6;
            // 
            // kepada
            // 
            this.kepada.Location = new System.Drawing.Point(190, 83);
            this.kepada.Name = "kepada";
            this.kepada.Size = new System.Drawing.Size(200, 20);
            this.kepada.TabIndex = 1;
            // 
            // jenis
            // 
            this.jenis.FormattingEnabled = true;
            this.jenis.Items.AddRange(new object[] {
            "Reguler",
            "Kilat",
            "ONS"});
            this.jenis.Location = new System.Drawing.Point(190, 215);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(137, 21);
            this.jenis.TabIndex = 3;
            this.jenis.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // asuransi
            // 
            this.asuransi.AutoSize = true;
            this.asuransi.Checked = true;
            this.asuransi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.asuransi.Location = new System.Drawing.Point(412, 218);
            this.asuransi.Name = "asuransi";
            this.asuransi.Size = new System.Drawing.Size(15, 14);
            this.asuransi.TabIndex = 4;
            this.asuransi.UseVisualStyleBackColor = true;
            this.asuransi.CheckedChanged += new System.EventHandler(this.asuransi_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Asuransi";
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(240, 302);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(75, 23);
            this.hitung.TabIndex = 7;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Visible = false;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(320, 302);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 8;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // berat
            // 
            this.berat.Location = new System.Drawing.Point(190, 242);
            this.berat.Name = "berat";
            this.berat.Size = new System.Drawing.Size(200, 20);
            this.berat.TabIndex = 5;
            this.berat.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.berat_MaskInputRejected);
            this.berat.TextChanged += new System.EventHandler(this.berat_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 337);
            this.Controls.Add(this.berat);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.asuransi);
            this.Controls.Add(this.jenis);
            this.Controls.Add(this.kepada);
            this.Controls.Add(this.ongkos);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox ongkos;
        private System.Windows.Forms.TextBox kepada;
        private System.Windows.Forms.ComboBox jenis;
        private System.Windows.Forms.CheckBox asuransi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.MaskedTextBox berat;
    }
}

