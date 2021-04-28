
namespace VremenskaPrognozaMain
{
    partial class FormHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelForHistory = new System.Windows.Forms.Panel();
            this.LblForSearchHistory = new System.Windows.Forms.Label();
            this.textBoxCitySearch = new System.Windows.Forms.TextBox();
            this.GMapHistory = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridViewPovijestMjerenja = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.IdMjerenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivGrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiniSeKao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clouds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vidljivnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisVremena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPovijestMjerenja)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(12, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(43, 62);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelForHistory
            // 
            this.panelForHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForHistory.Controls.Add(this.btnPrint);
            this.panelForHistory.Controls.Add(this.LblForSearchHistory);
            this.panelForHistory.Controls.Add(this.textBoxCitySearch);
            this.panelForHistory.Controls.Add(this.GMapHistory);
            this.panelForHistory.Location = new System.Drawing.Point(12, 12);
            this.panelForHistory.Name = "panelForHistory";
            this.panelForHistory.Size = new System.Drawing.Size(1430, 362);
            this.panelForHistory.TabIndex = 2;
            // 
            // LblForSearchHistory
            // 
            this.LblForSearchHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblForSearchHistory.AutoSize = true;
            this.LblForSearchHistory.Location = new System.Drawing.Point(215, 135);
            this.LblForSearchHistory.Name = "LblForSearchHistory";
            this.LblForSearchHistory.Size = new System.Drawing.Size(166, 21);
            this.LblForSearchHistory.TabIndex = 2;
            this.LblForSearchHistory.Text = "Tražilica po gradovima";
            // 
            // textBoxCitySearch
            // 
            this.textBoxCitySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCitySearch.Location = new System.Drawing.Point(182, 173);
            this.textBoxCitySearch.Name = "textBoxCitySearch";
            this.textBoxCitySearch.Size = new System.Drawing.Size(240, 29);
            this.textBoxCitySearch.TabIndex = 1;
            this.textBoxCitySearch.TextChanged += new System.EventHandler(this.textBoxCitySearch_TextChanged);
            // 
            // GMapHistory
            // 
            this.GMapHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GMapHistory.Bearing = 0F;
            this.GMapHistory.CanDragMap = true;
            this.GMapHistory.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapHistory.GrayScaleMode = false;
            this.GMapHistory.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapHistory.LevelsKeepInMemmory = 5;
            this.GMapHistory.Location = new System.Drawing.Point(628, 3);
            this.GMapHistory.MarkersEnabled = true;
            this.GMapHistory.MaxZoom = 2;
            this.GMapHistory.MinZoom = 2;
            this.GMapHistory.MouseWheelZoomEnabled = true;
            this.GMapHistory.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapHistory.Name = "GMapHistory";
            this.GMapHistory.NegativeMode = false;
            this.GMapHistory.PolygonsEnabled = true;
            this.GMapHistory.RetryLoadTile = 0;
            this.GMapHistory.RoutesEnabled = true;
            this.GMapHistory.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapHistory.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapHistory.ShowTileGridLines = false;
            this.GMapHistory.Size = new System.Drawing.Size(799, 356);
            this.GMapHistory.TabIndex = 0;
            this.GMapHistory.Zoom = 0D;
            // 
            // dataGridViewPovijestMjerenja
            // 
            this.dataGridViewPovijestMjerenja.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewPovijestMjerenja.AllowUserToAddRows = false;
            this.dataGridViewPovijestMjerenja.AllowUserToDeleteRows = false;
            this.dataGridViewPovijestMjerenja.AllowUserToResizeColumns = false;
            this.dataGridViewPovijestMjerenja.AllowUserToResizeRows = false;
            this.dataGridViewPovijestMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPovijestMjerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPovijestMjerenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMjerenja,
            this.IdGrada,
            this.NazivGrada,
            this.Drzava,
            this.Temp,
            this.MinTemp,
            this.MaxTemp,
            this.CiniSeKao,
            this.Pressure,
            this.Humidity,
            this.Clouds,
            this.Wind,
            this.Vidljivnost,
            this.OpisVremena,
            this.Date});
            this.dataGridViewPovijestMjerenja.Location = new System.Drawing.Point(12, 382);
            this.dataGridViewPovijestMjerenja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPovijestMjerenja.Name = "dataGridViewPovijestMjerenja";
            this.dataGridViewPovijestMjerenja.RowHeadersVisible = false;
            this.dataGridViewPovijestMjerenja.Size = new System.Drawing.Size(1429, 298);
            this.dataGridViewPovijestMjerenja.TabIndex = 5;
            this.dataGridViewPovijestMjerenja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPovijestMjerenja_CellContentClick);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(3, 281);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 78);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // IdMjerenja
            // 
            this.IdMjerenja.DataPropertyName = "nIdMjerenja";
            this.IdMjerenja.HeaderText = "Id mjerenja";
            this.IdMjerenja.Name = "IdMjerenja";
            // 
            // IdGrada
            // 
            this.IdGrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdGrada.DataPropertyName = "nCityId";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.IdGrada.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdGrada.HeaderText = "Id grada";
            this.IdGrada.Name = "IdGrada";
            // 
            // NazivGrada
            // 
            this.NazivGrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivGrada.DataPropertyName = "sCityName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.NazivGrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.NazivGrada.HeaderText = "Naziv grada";
            this.NazivGrada.Name = "NazivGrada";
            // 
            // Drzava
            // 
            this.Drzava.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Drzava.DataPropertyName = "sCityTag";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Drzava.DefaultCellStyle = dataGridViewCellStyle3;
            this.Drzava.HeaderText = "Država";
            this.Drzava.Name = "Drzava";
            // 
            // Temp
            // 
            this.Temp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Temp.DataPropertyName = "sTemp";
            this.Temp.HeaderText = "Temperatura, °C";
            this.Temp.Name = "Temp";
            // 
            // MinTemp
            // 
            this.MinTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MinTemp.DataPropertyName = "sMinTemp";
            this.MinTemp.HeaderText = "Minimalna temp. °C";
            this.MinTemp.Name = "MinTemp";
            // 
            // MaxTemp
            // 
            this.MaxTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaxTemp.DataPropertyName = "sMaxTemp";
            this.MaxTemp.HeaderText = "Maksimalna temp. °C";
            this.MaxTemp.Name = "MaxTemp";
            // 
            // CiniSeKao
            // 
            this.CiniSeKao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CiniSeKao.DataPropertyName = "sFeelsLike";
            this.CiniSeKao.HeaderText = "Subjektivni dojam, °C";
            this.CiniSeKao.Name = "CiniSeKao";
            // 
            // Pressure
            // 
            this.Pressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pressure.DataPropertyName = "sPressure";
            this.Pressure.HeaderText = "Tlak zraka, mb";
            this.Pressure.Name = "Pressure";
            // 
            // Humidity
            // 
            this.Humidity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Humidity.DataPropertyName = "sHumidity";
            this.Humidity.HeaderText = "Vlaga, %";
            this.Humidity.Name = "Humidity";
            // 
            // Clouds
            // 
            this.Clouds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clouds.DataPropertyName = "sClouds";
            this.Clouds.HeaderText = "Postotak oblacnosti, %";
            this.Clouds.Name = "Clouds";
            // 
            // Wind
            // 
            this.Wind.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wind.DataPropertyName = "sWind";
            this.Wind.HeaderText = "Brzina vjetra, km/h";
            this.Wind.Name = "Wind";
            // 
            // Vidljivnost
            // 
            this.Vidljivnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vidljivnost.DataPropertyName = "sViewDistance";
            this.Vidljivnost.HeaderText = "Vidljivost, m";
            this.Vidljivnost.Name = "Vidljivnost";
            // 
            // OpisVremena
            // 
            this.OpisVremena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpisVremena.DataPropertyName = "sWeatherDisc";
            this.OpisVremena.HeaderText = "Opis vremena";
            this.OpisVremena.Name = "OpisVremena";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "sDatum";
            this.Date.HeaderText = "Datum mjerenja";
            this.Date.Name = "Date";
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1455, 694);
            this.Controls.Add(this.dataGridViewPovijestMjerenja);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelForHistory);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1471, 733);
            this.Name = "FormHistory";
            this.Text = "Pregled povijesti mjerenja";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.panelForHistory.ResumeLayout(false);
            this.panelForHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPovijestMjerenja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelForHistory;
        private System.Windows.Forms.DataGridView dataGridViewPovijestMjerenja;
        private System.Windows.Forms.Label LblForSearchHistory;
        private System.Windows.Forms.TextBox textBoxCitySearch;
        private GMap.NET.WindowsForms.GMapControl GMapHistory;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMjerenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivGrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiniSeKao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clouds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vidljivnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisVremena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}