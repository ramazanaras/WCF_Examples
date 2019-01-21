namespace Service_Giris
{
    partial class TcknDogrulaForm
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
            this.mskdTCKN = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsıim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyIsim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdDogumYili = new System.Windows.Forms.MaskedTextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tckn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mskdTCKN
            // 
            this.mskdTCKN.Location = new System.Drawing.Point(76, 46);
            this.mskdTCKN.Mask = "00000000000";
            this.mskdTCKN.Name = "mskdTCKN";
            this.mskdTCKN.Size = new System.Drawing.Size(100, 20);
            this.mskdTCKN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIsıim
            // 
            this.txtIsıim.Location = new System.Drawing.Point(76, 84);
            this.txtIsıim.Name = "txtIsıim";
            this.txtIsıim.Size = new System.Drawing.Size(100, 20);
            this.txtIsıim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyİsim";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Location = new System.Drawing.Point(76, 122);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(100, 20);
            this.txtSoyIsim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Yılı:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // mskdDogumYili
            // 
            this.mskdDogumYili.Location = new System.Drawing.Point(79, 161);
            this.mskdDogumYili.Mask = "0000";
            this.mskdDogumYili.Name = "mskdDogumYili";
            this.mskdDogumYili.Size = new System.Drawing.Size(100, 20);
            this.mskdDogumYili.TabIndex = 3;
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(76, 204);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(75, 23);
            this.btnDogrula.TabIndex = 4;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // TcknDogrulaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 296);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.mskdDogumYili);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.txtIsıim);
            this.Controls.Add(this.mskdTCKN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TcknDogrulaForm";
            this.Text = "TcknDogrulaForm";
            this.Load += new System.EventHandler(this.TcknDogrulaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdTCKN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsıim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyIsim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdDogumYili;
        private System.Windows.Forms.Button btnDogrula;

    }
}