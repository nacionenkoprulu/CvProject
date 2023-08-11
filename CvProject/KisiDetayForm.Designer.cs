namespace CvProject
{
    partial class KisiDetayForm
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
            label1 = new Label();
            tbIsim = new TextBox();
            label2 = new Label();
            tbKimlikNo = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dtpDogumTarihi = new DateTimePicker();
            rtbBiyografi = new RichTextBox();
            label7 = new Label();
            ddlSehir = new ComboBox();
            ddlUlke = new ComboBox();
            ddlCinsiyet = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbKisiIs = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // tbIsim
            // 
            tbIsim.Enabled = false;
            tbIsim.Location = new Point(85, 31);
            tbIsim.Name = "tbIsim";
            tbIsim.Size = new Size(147, 27);
            tbIsim.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 34);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "Kimlik No";
            // 
            // tbKimlikNo
            // 
            tbKimlikNo.Enabled = false;
            tbKimlikNo.Location = new Point(318, 31);
            tbKimlikNo.Name = "tbKimlikNo";
            tbKimlikNo.Size = new Size(134, 27);
            tbKimlikNo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 0;
            label3.Text = "Doğum Tarihi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbKisiIs);
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(rtbBiyografi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ddlSehir);
            groupBox1.Controls.Add(ddlUlke);
            groupBox1.Controls.Add(ddlCinsiyet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbIsim);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbKimlikNo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 286);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Enabled = false;
            dtpDogumTarihi.Location = new Point(110, 81);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(144, 27);
            dtpDogumTarihi.TabIndex = 3;
            // 
            // rtbBiyografi
            // 
            rtbBiyografi.Enabled = false;
            rtbBiyografi.Location = new Point(6, 159);
            rtbBiyografi.Name = "rtbBiyografi";
            rtbBiyografi.Size = new Size(375, 103);
            rtbBiyografi.TabIndex = 1;
            rtbBiyografi.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 127);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 0;
            label7.Text = "Biyografi";
            // 
            // ddlSehir
            // 
            ddlSehir.Enabled = false;
            ddlSehir.FormattingEnabled = true;
            ddlSehir.Location = new Point(534, 80);
            ddlSehir.Name = "ddlSehir";
            ddlSehir.Size = new Size(133, 28);
            ddlSehir.TabIndex = 2;
            // 
            // ddlUlke
            // 
            ddlUlke.Enabled = false;
            ddlUlke.FormattingEnabled = true;
            ddlUlke.Location = new Point(318, 80);
            ddlUlke.Name = "ddlUlke";
            ddlUlke.Size = new Size(134, 28);
            ddlUlke.TabIndex = 2;
            // 
            // ddlCinsiyet
            // 
            ddlCinsiyet.Enabled = false;
            ddlCinsiyet.FormattingEnabled = true;
            ddlCinsiyet.Location = new Point(555, 31);
            ddlCinsiyet.Name = "ddlCinsiyet";
            ddlCinsiyet.Size = new Size(112, 28);
            ddlCinsiyet.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 34);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 0;
            label4.Text = "Cinsiyet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(476, 86);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 0;
            label6.Text = "Şehir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 83);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 0;
            label5.Text = "Ülke";
            // 
            // lbKisiIs
            // 
            lbKisiIs.FormattingEnabled = true;
            lbKisiIs.ItemHeight = 20;
            lbKisiIs.Location = new Point(405, 159);
            lbKisiIs.Name = "lbKisiIs";
            lbKisiIs.Size = new Size(262, 104);
            lbKisiIs.TabIndex = 4;
            // 
            // KisiDetayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 319);
            Controls.Add(groupBox1);
            Name = "KisiDetayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KisiDetayForm";
            Load += KisiDetayForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbIsim;
        private Label label2;
        private TextBox tbKimlikNo;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox ddlSehir;
        private ComboBox ddlUlke;
        private ComboBox ddlCinsiyet;
        private Label label4;
        private Label label6;
        private Label label5;
        private RichTextBox rtbBiyografi;
        private Label label7;
        private DateTimePicker dtpDogumTarihi;
        private ListBox lbKisiIs;
    }
}