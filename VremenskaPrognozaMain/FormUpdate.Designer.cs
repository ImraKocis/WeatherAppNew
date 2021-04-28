
namespace VremenskaPrognozaMain
{
    partial class FormUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdate));
            this.lblNaslovAzuriranje = new System.Windows.Forms.Label();
            this.lblTrenutniNazivGrada = new System.Windows.Forms.Label();
            this.inputNazivGrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslovAzuriranje
            // 
            this.lblNaslovAzuriranje.AutoSize = true;
            this.lblNaslovAzuriranje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovAzuriranje.Location = new System.Drawing.Point(240, 42);
            this.lblNaslovAzuriranje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslovAzuriranje.Name = "lblNaslovAzuriranje";
            this.lblNaslovAzuriranje.Size = new System.Drawing.Size(137, 21);
            this.lblNaslovAzuriranje.TabIndex = 0;
            this.lblNaslovAzuriranje.Text = "Ažuriranje grada";
            // 
            // lblTrenutniNazivGrada
            // 
            this.lblTrenutniNazivGrada.AutoSize = true;
            this.lblTrenutniNazivGrada.Location = new System.Drawing.Point(240, 86);
            this.lblTrenutniNazivGrada.Name = "lblTrenutniNazivGrada";
            this.lblTrenutniNazivGrada.Size = new System.Drawing.Size(45, 21);
            this.lblTrenutniNazivGrada.TabIndex = 1;
            this.lblTrenutniNazivGrada.Text = "naziv";
            this.lblTrenutniNazivGrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputNazivGrada
            // 
            this.inputNazivGrada.Location = new System.Drawing.Point(175, 208);
            this.inputNazivGrada.Name = "inputNazivGrada";
            this.inputNazivGrada.Size = new System.Drawing.Size(264, 29);
            this.inputNazivGrada.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Novi naziv grada:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(97, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(373, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Potvrdi";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 391);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNazivGrada);
            this.Controls.Add(this.lblTrenutniNazivGrada);
            this.Controls.Add(this.lblNaslovAzuriranje);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(648, 430);
            this.MinimumSize = new System.Drawing.Size(648, 430);
            this.Name = "FormUpdate";
            this.Text = "Ažuriranje grada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovAzuriranje;
        public System.Windows.Forms.Label lblTrenutniNazivGrada;
        private System.Windows.Forms.TextBox inputNazivGrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
    }
}