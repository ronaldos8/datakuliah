namespace part3
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
            this.judul = new System.Windows.Forms.TextBox();
            this.lama = new System.Windows.Forms.TextBox();
            this.denda = new System.Windows.Forms.TextBox();
            this.pinjam = new System.Windows.Forms.DateTimePicker();
            this.kembali = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORIGINAL VIDEO RENTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judul Film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Denda (Rp)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lama Pinjam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal Kembali";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tanggal Pinjam";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // judul
            // 
            this.judul.Location = new System.Drawing.Point(171, 71);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(214, 20);
            this.judul.TabIndex = 6;
            // 
            // lama
            // 
            this.lama.Location = new System.Drawing.Point(171, 149);
            this.lama.Name = "lama";
            this.lama.Size = new System.Drawing.Size(214, 20);
            this.lama.TabIndex = 7;
            // 
            // denda
            // 
            this.denda.Location = new System.Drawing.Point(171, 180);
            this.denda.Name = "denda";
            this.denda.Size = new System.Drawing.Size(214, 20);
            this.denda.TabIndex = 8;
            this.denda.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pinjam
            // 
            this.pinjam.Location = new System.Drawing.Point(171, 97);
            this.pinjam.Name = "pinjam";
            this.pinjam.Size = new System.Drawing.Size(214, 20);
            this.pinjam.TabIndex = 9;
            this.pinjam.ValueChanged += new System.EventHandler(this.pinjam_ValueChanged);
            // 
            // kembali
            // 
            this.kembali.Location = new System.Drawing.Point(171, 123);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(214, 20);
            this.kembali.TabIndex = 10;
            this.kembali.ValueChanged += new System.EventHandler(this.kembali_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 217);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.pinjam);
            this.Controls.Add(this.denda);
            this.Controls.Add(this.lama);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox judul;
        private System.Windows.Forms.TextBox lama;
        private System.Windows.Forms.TextBox denda;
        private System.Windows.Forms.DateTimePicker pinjam;
        private System.Windows.Forms.DateTimePicker kembali;
    }
}

