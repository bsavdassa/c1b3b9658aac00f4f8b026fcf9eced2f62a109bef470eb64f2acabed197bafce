namespace ARAC_KIRALAMA
{
    partial class AraçKayıt
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAraçMarkası = new System.Windows.Forms.ComboBox();
            this.cmbAraçSeri = new System.Windows.Forms.ComboBox();
            this.cmbAraçyakıt = new System.Windows.Forms.ComboBox();
            this.txtKiralamaücreti = new System.Windows.Forms.TextBox();
            this.txtAraçkm = new System.Windows.Forms.TextBox();
            this.txtAraçrenk = new System.Windows.Forms.TextBox();
            this.txtAraçyıl = new System.Windows.Forms.TextBox();
            this.txtAraçPlakası = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Model (yıl):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Renk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Km:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yakıt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kira ücreti:";
            // 
            // cmbAraçMarkası
            // 
            this.cmbAraçMarkası.FormattingEnabled = true;
            this.cmbAraçMarkası.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford",
            "Mercedes",
            "Bmw"});
            this.cmbAraçMarkası.Location = new System.Drawing.Point(139, 81);
            this.cmbAraçMarkası.Name = "cmbAraçMarkası";
            this.cmbAraçMarkası.Size = new System.Drawing.Size(121, 21);
            this.cmbAraçMarkası.TabIndex = 1;
            this.cmbAraçMarkası.SelectedIndexChanged += new System.EventHandler(this.txtAraçMarkası_SelectedIndexChanged);
            // 
            // cmbAraçSeri
            // 
            this.cmbAraçSeri.FormattingEnabled = true;
            this.cmbAraçSeri.Location = new System.Drawing.Point(139, 112);
            this.cmbAraçSeri.Name = "cmbAraçSeri";
            this.cmbAraçSeri.Size = new System.Drawing.Size(121, 21);
            this.cmbAraçSeri.TabIndex = 1;
            // 
            // cmbAraçyakıt
            // 
            this.cmbAraçyakıt.FormattingEnabled = true;
            this.cmbAraçyakıt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "LPG"});
            this.cmbAraçyakıt.Location = new System.Drawing.Point(139, 233);
            this.cmbAraçyakıt.Name = "cmbAraçyakıt";
            this.cmbAraçyakıt.Size = new System.Drawing.Size(121, 21);
            this.cmbAraçyakıt.TabIndex = 1;
            // 
            // txtKiralamaücreti
            // 
            this.txtKiralamaücreti.Location = new System.Drawing.Point(139, 264);
            this.txtKiralamaücreti.Name = "txtKiralamaücreti";
            this.txtKiralamaücreti.Size = new System.Drawing.Size(121, 20);
            this.txtKiralamaücreti.TabIndex = 2;
            // 
            // txtAraçkm
            // 
            this.txtAraçkm.Location = new System.Drawing.Point(139, 203);
            this.txtAraçkm.Name = "txtAraçkm";
            this.txtAraçkm.Size = new System.Drawing.Size(121, 20);
            this.txtAraçkm.TabIndex = 2;
            // 
            // txtAraçrenk
            // 
            this.txtAraçrenk.Location = new System.Drawing.Point(139, 173);
            this.txtAraçrenk.Name = "txtAraçrenk";
            this.txtAraçrenk.Size = new System.Drawing.Size(121, 20);
            this.txtAraçrenk.TabIndex = 2;
            // 
            // txtAraçyıl
            // 
            this.txtAraçyıl.Location = new System.Drawing.Point(139, 143);
            this.txtAraçyıl.Name = "txtAraçyıl";
            this.txtAraçyıl.Size = new System.Drawing.Size(121, 20);
            this.txtAraçyıl.TabIndex = 2;
            // 
            // txtAraçPlakası
            // 
            this.txtAraçPlakası.Location = new System.Drawing.Point(139, 51);
            this.txtAraçPlakası.Name = "txtAraçPlakası";
            this.txtAraçPlakası.Size = new System.Drawing.Size(121, 20);
            this.txtAraçPlakası.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resim ekleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kayıt";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "İptal";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AraçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 408);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAraçPlakası);
            this.Controls.Add(this.txtAraçyıl);
            this.Controls.Add(this.txtAraçrenk);
            this.Controls.Add(this.txtAraçkm);
            this.Controls.Add(this.txtKiralamaücreti);
            this.Controls.Add(this.cmbAraçyakıt);
            this.Controls.Add(this.cmbAraçSeri);
            this.Controls.Add(this.cmbAraçMarkası);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "AraçKayıt";
            this.Text = "Araç Kiralama Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAraçMarkası;
        private System.Windows.Forms.ComboBox cmbAraçSeri;
        private System.Windows.Forms.ComboBox cmbAraçyakıt;
        private System.Windows.Forms.TextBox txtKiralamaücreti;
        private System.Windows.Forms.TextBox txtAraçkm;
        private System.Windows.Forms.TextBox txtAraçrenk;
        private System.Windows.Forms.TextBox txtAraçyıl;
        private System.Windows.Forms.TextBox txtAraçPlakası;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}