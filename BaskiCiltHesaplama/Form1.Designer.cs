namespace BaskiCiltHesaplama
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
            this.GelenSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GelenUzunluk = new System.Windows.Forms.TextBox();
            this.GelenGenislik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzunluk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genişlik:";
            // 
            // GelenSonuc
            // 
            this.GelenSonuc.AutoSize = true;
            this.GelenSonuc.Location = new System.Drawing.Point(38, 166);
            this.GelenSonuc.Name = "GelenSonuc";
            this.GelenSonuc.Size = new System.Drawing.Size(0, 13);
            this.GelenSonuc.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Klişe Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GelenUzunluk
            // 
            this.GelenUzunluk.Location = new System.Drawing.Point(95, 34);
            this.GelenUzunluk.Name = "GelenUzunluk";
            this.GelenUzunluk.Size = new System.Drawing.Size(100, 20);
            this.GelenUzunluk.TabIndex = 4;
            // 
            // GelenGenislik
            // 
            this.GelenGenislik.Location = new System.Drawing.Point(95, 62);
            this.GelenGenislik.Name = "GelenGenislik";
            this.GelenGenislik.Size = new System.Drawing.Size(100, 20);
            this.GelenGenislik.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GelenGenislik);
            this.Controls.Add(this.GelenUzunluk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GelenSonuc);
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
        private System.Windows.Forms.Label GelenSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GelenUzunluk;
        private System.Windows.Forms.TextBox GelenGenislik;
    }
}

