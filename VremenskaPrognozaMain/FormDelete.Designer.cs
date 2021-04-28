
namespace VremenskaPrognozaMain
{
    partial class FormDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDelete));
            this.lblBrisanjeGrada = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrisanjeGrada
            // 
            this.lblBrisanjeGrada.AutoSize = true;
            this.lblBrisanjeGrada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrisanjeGrada.Location = new System.Drawing.Point(120, 52);
            this.lblBrisanjeGrada.Name = "lblBrisanjeGrada";
            this.lblBrisanjeGrada.Size = new System.Drawing.Size(195, 25);
            this.lblBrisanjeGrada.TabIndex = 0;
            this.lblBrisanjeGrada.Text = "Želite li obrisati grad?";
            this.lblBrisanjeGrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(65, 142);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(251, 142);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 41);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 228);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblBrisanjeGrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(449, 267);
            this.MinimumSize = new System.Drawing.Size(449, 267);
            this.Name = "FormDelete";
            this.Text = "Brisanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnObrisi;
        public System.Windows.Forms.Label lblBrisanjeGrada;
    }
}