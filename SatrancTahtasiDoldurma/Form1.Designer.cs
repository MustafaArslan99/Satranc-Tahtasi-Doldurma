
namespace Ödev1
{
    partial class frmPiyon
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtsatir = new System.Windows.Forms.TextBox();
            this.txtsutun = new System.Windows.Forms.TextBox();
            this.lblSatir = new System.Windows.Forms.Label();
            this.lblSutun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(75, 97);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(74, 31);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtsatir
            // 
            this.txtsatir.Location = new System.Drawing.Point(75, 21);
            this.txtsatir.Name = "txtsatir";
            this.txtsatir.Size = new System.Drawing.Size(74, 20);
            this.txtsatir.TabIndex = 1;
            // 
            // txtsutun
            // 
            this.txtsutun.Location = new System.Drawing.Point(75, 56);
            this.txtsutun.Name = "txtsutun";
            this.txtsutun.Size = new System.Drawing.Size(74, 20);
            this.txtsutun.TabIndex = 2;
            // 
            // lblSatir
            // 
            this.lblSatir.AutoSize = true;
            this.lblSatir.Location = new System.Drawing.Point(19, 28);
            this.lblSatir.Name = "lblSatir";
            this.lblSatir.Size = new System.Drawing.Size(31, 13);
            this.lblSatir.TabIndex = 3;
            this.lblSatir.Text = "Satır:";
            // 
            // lblSutun
            // 
            this.lblSutun.AutoSize = true;
            this.lblSutun.Location = new System.Drawing.Point(12, 59);
            this.lblSutun.Name = "lblSutun";
            this.lblSutun.Size = new System.Drawing.Size(38, 13);
            this.lblSutun.TabIndex = 4;
            this.lblSutun.Text = "Sütun:";
            // 
            // frmPiyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(227, 157);
            this.Controls.Add(this.lblSutun);
            this.Controls.Add(this.lblSatir);
            this.Controls.Add(this.txtsutun);
            this.Controls.Add(this.txtsatir);
            this.Controls.Add(this.btnHesapla);
            this.Name = "frmPiyon";
            this.Text = "Piyon Dizilimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtsatir;
        private System.Windows.Forms.TextBox txtsutun;
        private System.Windows.Forms.Label lblSatir;
        private System.Windows.Forms.Label lblSutun;
    }
}

