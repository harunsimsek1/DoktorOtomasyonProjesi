﻿
namespace DoktorOtomasyonProjesi
{
    partial class FrmRecete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecete));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIlacEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIlacSil = new System.Windows.Forms.Button();
            this.listrecete = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richsonuc = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIlacEkle);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(326, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaçlar";
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.Location = new System.Drawing.Point(209, 19);
            this.btnIlacEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(111, 61);
            this.btnIlacEkle.TabIndex = 31;
            this.btnIlacEkle.Text = "EKLE";
            this.btnIlacEkle.UseVisualStyleBackColor = true;
            this.btnIlacEkle.Click += new System.EventHandler(this.btnIlacEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIlacSil);
            this.groupBox2.Controls.Add(this.listrecete);
            this.groupBox2.Location = new System.Drawing.Point(344, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(425, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reçete";
            // 
            // btnIlacSil
            // 
            this.btnIlacSil.Location = new System.Drawing.Point(126, 224);
            this.btnIlacSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlacSil.Name = "btnIlacSil";
            this.btnIlacSil.Size = new System.Drawing.Size(179, 55);
            this.btnIlacSil.TabIndex = 31;
            this.btnIlacSil.Text = "İlacı Sil";
            this.btnIlacSil.UseVisualStyleBackColor = true;
            this.btnIlacSil.Click += new System.EventHandler(this.btnIlacSil_Click);
            // 
            // listrecete
            // 
            this.listrecete.FormattingEnabled = true;
            this.listrecete.ItemHeight = 16;
            this.listrecete.Location = new System.Drawing.Point(6, 19);
            this.listrecete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listrecete.Name = "listrecete";
            this.listrecete.Size = new System.Drawing.Size(413, 196);
            this.listrecete.TabIndex = 0;
            this.listrecete.Click += new System.EventHandler(this.listrecete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(646, 58);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richsonuc);
            this.groupBox3.Location = new System.Drawing.Point(12, 289);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(326, 174);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Muayene Sonucu";
            // 
            // richsonuc
            // 
            this.richsonuc.Enabled = false;
            this.richsonuc.Location = new System.Drawing.Point(6, 21);
            this.richsonuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richsonuc.Name = "richsonuc";
            this.richsonuc.Size = new System.Drawing.Size(308, 138);
            this.richsonuc.TabIndex = 0;
            this.richsonuc.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 53);
            this.panel1.TabIndex = 28;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.Image = ((System.Drawing.Image)(resources.GetObject("btncikis.Image")));
            this.btncikis.Location = new System.Drawing.Point(716, 0);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(58, 53);
            this.btncikis.TabIndex = 31;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(254, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 49);
            this.label3.TabIndex = 30;
            this.label3.Text = "       HASTANESİ\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(231, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 49);
            this.label2.TabIndex = 29;
            this.label2.Text = "KOCAELİ  ÜNİVERSİTESİ \r\n";
            // 
            // FrmRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(774, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecete";
            this.Load += new System.EventHandler(this.FrmRecete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listrecete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richsonuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.Button btnIlacSil;
    }
}