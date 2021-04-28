
namespace VremenskaPrognozaMain
{
    partial class FormObrisiPovijest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObrisiPovijest));
            this.buttonCloseObrisi = new System.Windows.Forms.Button();
            this.btnObrisiPovijest = new System.Windows.Forms.Button();
            this.labelBrisanjePovijest = new System.Windows.Forms.Label();
            this.lblIdMjerenja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCloseObrisi
            // 
            this.buttonCloseObrisi.Location = new System.Drawing.Point(37, 144);
            this.buttonCloseObrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseObrisi.Name = "buttonCloseObrisi";
            this.buttonCloseObrisi.Size = new System.Drawing.Size(105, 45);
            this.buttonCloseObrisi.TabIndex = 0;
            this.buttonCloseObrisi.Text = "Zatvori";
            this.buttonCloseObrisi.UseVisualStyleBackColor = true;
            this.buttonCloseObrisi.Click += new System.EventHandler(this.buttonCloseObrisi_Click);
            // 
            // btnObrisiPovijest
            // 
            this.btnObrisiPovijest.Location = new System.Drawing.Point(286, 144);
            this.btnObrisiPovijest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrisiPovijest.Name = "btnObrisiPovijest";
            this.btnObrisiPovijest.Size = new System.Drawing.Size(105, 45);
            this.btnObrisiPovijest.TabIndex = 1;
            this.btnObrisiPovijest.Text = "Obriši";
            this.btnObrisiPovijest.UseVisualStyleBackColor = true;
            this.btnObrisiPovijest.Click += new System.EventHandler(this.btnObrisiPovijest_Click);
            // 
            // labelBrisanjePovijest
            // 
            this.labelBrisanjePovijest.AutoSize = true;
            this.labelBrisanjePovijest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrisanjePovijest.Location = new System.Drawing.Point(33, 40);
            this.labelBrisanjePovijest.Name = "labelBrisanjePovijest";
            this.labelBrisanjePovijest.Size = new System.Drawing.Size(88, 21);
            this.labelBrisanjePovijest.TabIndex = 2;
            this.labelBrisanjePovijest.Text = "Obrisi grad";
            // 
            // lblIdMjerenja
            // 
            this.lblIdMjerenja.AutoSize = true;
            this.lblIdMjerenja.Location = new System.Drawing.Point(34, 74);
            this.lblIdMjerenja.Name = "lblIdMjerenja";
            this.lblIdMjerenja.Size = new System.Drawing.Size(76, 17);
            this.lblIdMjerenja.TabIndex = 3;
            this.lblIdMjerenja.Text = "Id mjerenja:";
            // 
            // FormObrisiPovijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 228);
            this.Controls.Add(this.lblIdMjerenja);
            this.Controls.Add(this.labelBrisanjePovijest);
            this.Controls.Add(this.btnObrisiPovijest);
            this.Controls.Add(this.buttonCloseObrisi);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(449, 267);
            this.MinimumSize = new System.Drawing.Size(449, 267);
            this.Name = "FormObrisiPovijest";
            this.Text = "Brisanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseObrisi;
        private System.Windows.Forms.Button btnObrisiPovijest;
        public System.Windows.Forms.Label labelBrisanjePovijest;
        public System.Windows.Forms.Label lblIdMjerenja;
    }
}