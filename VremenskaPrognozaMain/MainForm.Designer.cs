namespace VremenskaPrognozaMain
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.OdabraniGradoviBtn = new System.Windows.Forms.Button();
            this.dataGridViewGradovi = new System.Windows.Forms.DataGridView();
            this.IdGrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivGrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxGradovi = new System.Windows.Forms.TextBox();
            this.comboBoxCountryTags = new System.Windows.Forms.ComboBox();
            this.LblForStates = new System.Windows.Forms.Label();
            this.sortNameUpBtn = new System.Windows.Forms.Button();
            this.sortNameDownBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenFormHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGradovi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upišite naziv grada za koji želite provjeriti prognozu vremena";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OdabraniGradoviBtn
            // 
            this.OdabraniGradoviBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OdabraniGradoviBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OdabraniGradoviBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.OdabraniGradoviBtn.Location = new System.Drawing.Point(828, 598);
            this.OdabraniGradoviBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OdabraniGradoviBtn.Name = "OdabraniGradoviBtn";
            this.OdabraniGradoviBtn.Size = new System.Drawing.Size(169, 39);
            this.OdabraniGradoviBtn.TabIndex = 2;
            this.OdabraniGradoviBtn.Text = "Odabrani gradovi";
            this.OdabraniGradoviBtn.UseVisualStyleBackColor = true;
            this.OdabraniGradoviBtn.Click += new System.EventHandler(this.OdabraniGradoviBtn_Click);
            // 
            // dataGridViewGradovi
            // 
            this.dataGridViewGradovi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewGradovi.AllowUserToAddRows = false;
            this.dataGridViewGradovi.AllowUserToDeleteRows = false;
            this.dataGridViewGradovi.AllowUserToResizeColumns = false;
            this.dataGridViewGradovi.AllowUserToResizeRows = false;
            this.dataGridViewGradovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrada,
            this.NazivGrada,
            this.Drzava});
            this.dataGridViewGradovi.Location = new System.Drawing.Point(13, 342);
            this.dataGridViewGradovi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewGradovi.Name = "dataGridViewGradovi";
            this.dataGridViewGradovi.RowHeadersVisible = false;
            this.dataGridViewGradovi.Size = new System.Drawing.Size(779, 374);
            this.dataGridViewGradovi.TabIndex = 3;
            this.dataGridViewGradovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGradovi_CellContentClick);
            // 
            // IdGrada
            // 
            this.IdGrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdGrada.DataPropertyName = "nCityID";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.IdGrada.DefaultCellStyle = dataGridViewCellStyle4;
            this.IdGrada.FillWeight = 40F;
            this.IdGrada.HeaderText = "Id grada";
            this.IdGrada.Name = "IdGrada";
            // 
            // NazivGrada
            // 
            this.NazivGrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivGrada.DataPropertyName = "sCityName";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.NazivGrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.NazivGrada.HeaderText = "Naziv grada";
            this.NazivGrada.Name = "NazivGrada";
            // 
            // Drzava
            // 
            this.Drzava.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Drzava.DataPropertyName = "sCountryTag";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Drzava.DefaultCellStyle = dataGridViewCellStyle6;
            this.Drzava.FillWeight = 40F;
            this.Drzava.HeaderText = "Država";
            this.Drzava.Name = "Drzava";
            // 
            // textBoxGradovi
            // 
            this.textBoxGradovi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGradovi.Location = new System.Drawing.Point(448, 176);
            this.textBoxGradovi.Name = "textBoxGradovi";
            this.textBoxGradovi.Size = new System.Drawing.Size(275, 29);
            this.textBoxGradovi.TabIndex = 4;
            this.textBoxGradovi.TextChanged += new System.EventHandler(this.textBoxGradovi_TextChanged);
            // 
            // comboBoxCountryTags
            // 
            this.comboBoxCountryTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCountryTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountryTags.FormattingEnabled = true;
            this.comboBoxCountryTags.ItemHeight = 21;
            this.comboBoxCountryTags.Location = new System.Drawing.Point(828, 461);
            this.comboBoxCountryTags.MaxDropDownItems = 5;
            this.comboBoxCountryTags.MaxLength = 2;
            this.comboBoxCountryTags.Name = "comboBoxCountryTags";
            this.comboBoxCountryTags.Size = new System.Drawing.Size(169, 29);
            this.comboBoxCountryTags.TabIndex = 5;
            // 
            // LblForStates
            // 
            this.LblForStates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblForStates.AutoSize = true;
            this.LblForStates.Location = new System.Drawing.Point(1003, 464);
            this.LblForStates.Name = "LblForStates";
            this.LblForStates.Size = new System.Drawing.Size(165, 21);
            this.LblForStates.TabIndex = 6;
            this.LblForStates.Text = "Filtriranje po državama";
            // 
            // sortNameUpBtn
            // 
            this.sortNameUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortNameUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortNameUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("sortNameUpBtn.Image")));
            this.sortNameUpBtn.Location = new System.Drawing.Point(841, 386);
            this.sortNameUpBtn.Name = "sortNameUpBtn";
            this.sortNameUpBtn.Size = new System.Drawing.Size(49, 38);
            this.sortNameUpBtn.TabIndex = 7;
            this.sortNameUpBtn.UseVisualStyleBackColor = true;
            this.sortNameUpBtn.Click += new System.EventHandler(this.sortNameUpBtn_Click);
            // 
            // sortNameDownBtn
            // 
            this.sortNameDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortNameDownBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.sortNameDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortNameDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("sortNameDownBtn.Image")));
            this.sortNameDownBtn.Location = new System.Drawing.Point(932, 386);
            this.sortNameDownBtn.Name = "sortNameDownBtn";
            this.sortNameDownBtn.Size = new System.Drawing.Size(49, 38);
            this.sortNameDownBtn.TabIndex = 8;
            this.sortNameDownBtn.UseVisualStyleBackColor = false;
            this.sortNameDownBtn.Click += new System.EventHandler(this.sortNameDownBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1003, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sortiranje po nazivu";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(828, 534);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(169, 38);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnOpenFormHistory);
            this.panel1.Location = new System.Drawing.Point(799, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 373);
            this.panel1.TabIndex = 11;
            // 
            // btnOpenFormHistory
            // 
            this.btnOpenFormHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFormHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFormHistory.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnOpenFormHistory.Location = new System.Drawing.Point(29, 320);
            this.btnOpenFormHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFormHistory.Name = "btnOpenFormHistory";
            this.btnOpenFormHistory.Size = new System.Drawing.Size(169, 39);
            this.btnOpenFormHistory.TabIndex = 3;
            this.btnOpenFormHistory.Text = "Povijest mjerenja";
            this.btnOpenFormHistory.UseVisualStyleBackColor = true;
            this.btnOpenFormHistory.Click += new System.EventHandler(this.btnOpenFormHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1206, 727);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortNameDownBtn);
            this.Controls.Add(this.sortNameUpBtn);
            this.Controls.Add(this.LblForStates);
            this.Controls.Add(this.comboBoxCountryTags);
            this.Controls.Add(this.textBoxGradovi);
            this.Controls.Add(this.dataGridViewGradovi);
            this.Controls.Add(this.OdabraniGradoviBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(858, 766);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Vremenska prognoza";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGradovi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OdabraniGradoviBtn;
        private System.Windows.Forms.DataGridView dataGridViewGradovi;
        private System.Windows.Forms.TextBox textBoxGradovi;
        private System.Windows.Forms.ComboBox comboBoxCountryTags;
        private System.Windows.Forms.Label LblForStates;
        private System.Windows.Forms.Button sortNameUpBtn;
        private System.Windows.Forms.Button sortNameDownBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivGrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
        private System.Windows.Forms.Button btnOpenFormHistory;
    }
}

