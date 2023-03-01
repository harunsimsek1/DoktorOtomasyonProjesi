
namespace DoktorOtomasyonProjesi
{
    partial class FrmAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaEkran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntaburcuet = new System.Windows.Forms.Button();
            this.btntahliller = new System.Windows.Forms.Button();
            this.btnmuayene = new System.Windows.Forms.Button();
            this.btnrandevular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhesap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 46);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.Image = ((System.Drawing.Image)(resources.GetObject("btncikis.Image")));
            this.btncikis.Location = new System.Drawing.Point(1088, 0);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(52, 45);
            this.btncikis.TabIndex = 7;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntaburcuet);
            this.groupBox1.Controls.Add(this.btntahliller);
            this.groupBox1.Controls.Add(this.btnmuayene);
            this.groupBox1.Controls.Add(this.btnrandevular);
            this.groupBox1.Location = new System.Drawing.Point(7, 179);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(194, 422);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // btntaburcuet
            // 
            this.btntaburcuet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btntaburcuet.Location = new System.Drawing.Point(0, 326);
            this.btntaburcuet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntaburcuet.Name = "btntaburcuet";
            this.btntaburcuet.Size = new System.Drawing.Size(194, 58);
            this.btntaburcuet.TabIndex = 8;
            this.btntaburcuet.Text = "TABURCU ET";
            this.btntaburcuet.UseVisualStyleBackColor = true;
            this.btntaburcuet.Click += new System.EventHandler(this.btntaburcuet_Click);
            // 
            // btntahliller
            // 
            this.btntahliller.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btntahliller.Location = new System.Drawing.Point(0, 230);
            this.btntahliller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntahliller.Name = "btntahliller";
            this.btntahliller.Size = new System.Drawing.Size(194, 58);
            this.btntahliller.TabIndex = 8;
            this.btntahliller.Text = "TAHLİLLER";
            this.btntahliller.UseVisualStyleBackColor = true;
            this.btntahliller.Click += new System.EventHandler(this.btntahliller_Click);
            // 
            // btnmuayene
            // 
            this.btnmuayene.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmuayene.Location = new System.Drawing.Point(0, 135);
            this.btnmuayene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmuayene.Name = "btnmuayene";
            this.btnmuayene.Size = new System.Drawing.Size(194, 58);
            this.btnmuayene.TabIndex = 8;
            this.btnmuayene.Text = "MUAYENE";
            this.btnmuayene.UseVisualStyleBackColor = true;
            this.btnmuayene.Click += new System.EventHandler(this.btnmuayene_Click);
            // 
            // btnrandevular
            // 
            this.btnrandevular.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnrandevular.Location = new System.Drawing.Point(0, 42);
            this.btnrandevular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrandevular.Name = "btnrandevular";
            this.btnrandevular.Size = new System.Drawing.Size(194, 58);
            this.btnrandevular.TabIndex = 8;
            this.btnrandevular.Text = "RANDEVULAR";
            this.btnrandevular.UseVisualStyleBackColor = true;
            this.btnrandevular.Click += new System.EventHandler(this.btnrandevular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(221, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(912, 422);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(906, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(278, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "KOCAELİ ÜNİVERSİTESİ HASTANESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnhesap
            // 
            this.btnhesap.BackColor = System.Drawing.Color.Transparent;
            this.btnhesap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhesap.Image = ((System.Drawing.Image)(resources.GetObject("btnhesap.Image")));
            this.btnhesap.Location = new System.Drawing.Point(1031, 51);
            this.btnhesap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(105, 74);
            this.btnhesap.TabIndex = 7;
            this.btnhesap.UseVisualStyleBackColor = false;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1139, 605);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FrmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Button btnrandevular;
        private System.Windows.Forms.Button btnmuayene;
        private System.Windows.Forms.Button btntahliller;
        private System.Windows.Forms.Button btntaburcuet;
    }
}