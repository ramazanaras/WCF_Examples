namespace Win_WebServices
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUrunleriListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMusterilistele = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtDogumYili = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tıkla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUrunleriListele
            // 
            this.btnUrunleriListele.Location = new System.Drawing.Point(131, 12);
            this.btnUrunleriListele.Name = "btnUrunleriListele";
            this.btnUrunleriListele.Size = new System.Drawing.Size(99, 49);
            this.btnUrunleriListele.TabIndex = 1;
            this.btnUrunleriListele.Text = "Ürünler";
            this.btnUrunleriListele.UseVisualStyleBackColor = true;
            this.btnUrunleriListele.Click += new System.EventHandler(this.btnUrunleriListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 113);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnMusterilistele
            // 
            this.btnMusterilistele.Location = new System.Drawing.Point(236, 12);
            this.btnMusterilistele.Name = "btnMusterilistele";
            this.btnMusterilistele.Size = new System.Drawing.Size(127, 49);
            this.btnMusterilistele.TabIndex = 3;
            this.btnMusterilistele.Text = "Müşteri Listele";
            this.btnMusterilistele.UseVisualStyleBackColor = true;
            this.btnMusterilistele.Click += new System.EventHandler(this.btnMusterilistele_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(118, 270);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(173, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(118, 296);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(173, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(118, 244);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(173, 20);
            this.txtTCKN.TabIndex = 4;
            // 
            // txtDogumYili
            // 
            this.txtDogumYili.Location = new System.Drawing.Point(118, 322);
            this.txtDogumYili.Name = "txtDogumYili";
            this.txtDogumYili.Size = new System.Drawing.Size(173, 20);
            this.txtDogumYili.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TCKN Doğrula";
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(141, 358);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(75, 23);
            this.btnDogrula.TabIndex = 6;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TCKN ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "soyad";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "dogum yılı";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 419);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDogumYili);
            this.Controls.Add(this.txtTCKN);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnMusterilistele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUrunleriListele);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUrunleriListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMusterilistele;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.TextBox txtDogumYili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

