
namespace VremenskaPrognozaMain
{
    partial class FormPrognozeOdabraniGradovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrognozeOdabraniGradovi));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOdabraniGradovi = new System.Windows.Forms.DataGridView();
            this.panelVrijeme = new System.Windows.Forms.Panel();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.buttonGrafStatistika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipGrafa = new System.Windows.Forms.ComboBox();
            this.btnPrintToFile = new System.Windows.Forms.Button();
            this.btnCloseGraph = new System.Windows.Forms.Button();
            this.IdGradaLbl = new System.Windows.Forms.Label();
            this.btnPrikaziGraf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblForTime = new System.Windows.Forms.Label();
            this.comboBoxUnapred = new System.Windows.Forms.ComboBox();
            this.ChartTemps = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHideMap = new System.Windows.Forms.Button();
            this.textBoxSearchForStats = new System.Windows.Forms.TextBox();
            this.lblForSearch = new System.Windows.Forms.Label();
            this.btnZatvoriGraf = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdabraniGradovi)).BeginInit();
            this.panelVrijeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTemps)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOdabraniGradovi
            // 
            this.dataGridViewOdabraniGradovi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewOdabraniGradovi.AllowUserToAddRows = false;
            this.dataGridViewOdabraniGradovi.AllowUserToDeleteRows = false;
            this.dataGridViewOdabraniGradovi.AllowUserToResizeColumns = false;
            this.dataGridViewOdabraniGradovi.AllowUserToResizeRows = false;
            this.dataGridViewOdabraniGradovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOdabraniGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdabraniGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewOdabraniGradovi.Location = new System.Drawing.Point(13, 382);
            this.dataGridViewOdabraniGradovi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOdabraniGradovi.Name = "dataGridViewOdabraniGradovi";
            this.dataGridViewOdabraniGradovi.RowHeadersVisible = false;
            this.dataGridViewOdabraniGradovi.Size = new System.Drawing.Size(1328, 298);
            this.dataGridViewOdabraniGradovi.TabIndex = 4;
            this.dataGridViewOdabraniGradovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOdabraniGradovi_CellContentClick);
            this.dataGridViewOdabraniGradovi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOdabraniGradovi_CellValueChanged);
            // 
            // panelVrijeme
            // 
            this.panelVrijeme.Controls.Add(this.gMapControl);
            this.panelVrijeme.Controls.Add(this.buttonGrafStatistika);
            this.panelVrijeme.Controls.Add(this.label1);
            this.panelVrijeme.Controls.Add(this.comboBoxTipGrafa);
            this.panelVrijeme.Controls.Add(this.btnPrintToFile);
            this.panelVrijeme.Controls.Add(this.btnCloseGraph);
            this.panelVrijeme.Controls.Add(this.IdGradaLbl);
            this.panelVrijeme.Controls.Add(this.btnPrikaziGraf);
            this.panelVrijeme.Controls.Add(this.label2);
            this.panelVrijeme.Controls.Add(this.lblForTime);
            this.panelVrijeme.Controls.Add(this.comboBoxUnapred);
            this.panelVrijeme.Controls.Add(this.ChartTemps);
            this.panelVrijeme.Location = new System.Drawing.Point(13, 12);
            this.panelVrijeme.Name = "panelVrijeme";
            this.panelVrijeme.Size = new System.Drawing.Size(1328, 323);
            this.panelVrijeme.TabIndex = 5;
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(602, 4);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 20;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(723, 316);
            this.gMapControl.TabIndex = 24;
            this.gMapControl.Zoom = 5D;
            // 
            // buttonGrafStatistika
            // 
            this.buttonGrafStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrafStatistika.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrafStatistika.Location = new System.Drawing.Point(395, 225);
            this.buttonGrafStatistika.Name = "buttonGrafStatistika";
            this.buttonGrafStatistika.Size = new System.Drawing.Size(137, 40);
            this.buttonGrafStatistika.TabIndex = 23;
            this.buttonGrafStatistika.Text = "Prikaži statistiku";
            this.buttonGrafStatistika.UseVisualStyleBackColor = true;
            this.buttonGrafStatistika.Click += new System.EventHandler(this.buttonGrafStatistika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Željeni tip grafa";
            // 
            // comboBoxTipGrafa
            // 
            this.comboBoxTipGrafa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipGrafa.FormattingEnabled = true;
            this.comboBoxTipGrafa.Location = new System.Drawing.Point(205, 157);
            this.comboBoxTipGrafa.Name = "comboBoxTipGrafa";
            this.comboBoxTipGrafa.Size = new System.Drawing.Size(327, 29);
            this.comboBoxTipGrafa.TabIndex = 21;
            // 
            // btnPrintToFile
            // 
            this.btnPrintToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintToFile.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintToFile.Image")));
            this.btnPrintToFile.Location = new System.Drawing.Point(3, 246);
            this.btnPrintToFile.Name = "btnPrintToFile";
            this.btnPrintToFile.Size = new System.Drawing.Size(82, 74);
            this.btnPrintToFile.TabIndex = 12;
            this.btnPrintToFile.UseVisualStyleBackColor = true;
            this.btnPrintToFile.Click += new System.EventHandler(this.btnPrintToFile_Click);
            // 
            // btnCloseGraph
            // 
            this.btnCloseGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseGraph.Image")));
            this.btnCloseGraph.Location = new System.Drawing.Point(3, 4);
            this.btnCloseGraph.Name = "btnCloseGraph";
            this.btnCloseGraph.Size = new System.Drawing.Size(45, 59);
            this.btnCloseGraph.TabIndex = 11;
            this.btnCloseGraph.UseVisualStyleBackColor = true;
            this.btnCloseGraph.Click += new System.EventHandler(this.btnCloseGraph_Click);
            // 
            // IdGradaLbl
            // 
            this.IdGradaLbl.AutoSize = true;
            this.IdGradaLbl.Location = new System.Drawing.Point(212, 23);
            this.IdGradaLbl.Name = "IdGradaLbl";
            this.IdGradaLbl.Size = new System.Drawing.Size(23, 21);
            this.IdGradaLbl.TabIndex = 8;
            this.IdGradaLbl.Text = "id";
            // 
            // btnPrikaziGraf
            // 
            this.btnPrikaziGraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziGraf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziGraf.Location = new System.Drawing.Point(205, 225);
            this.btnPrikaziGraf.Name = "btnPrikaziGraf";
            this.btnPrikaziGraf.Size = new System.Drawing.Size(137, 40);
            this.btnPrikaziGraf.TabIndex = 7;
            this.btnPrikaziGraf.Text = "Prikaži graf";
            this.btnPrikaziGraf.UseVisualStyleBackColor = true;
            this.btnPrikaziGraf.Click += new System.EventHandler(this.btnPrikaziGraf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Željeni raspon";
            // 
            // lblForTime
            // 
            this.lblForTime.AutoSize = true;
            this.lblForTime.Location = new System.Drawing.Point(279, 23);
            this.lblForTime.Name = "lblForTime";
            this.lblForTime.Size = new System.Drawing.Size(218, 21);
            this.lblForTime.TabIndex = 2;
            this.lblForTime.Text = "Odabir raspona točaka u grafu";
            // 
            // comboBoxUnapred
            // 
            this.comboBoxUnapred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnapred.FormattingEnabled = true;
            this.comboBoxUnapred.Location = new System.Drawing.Point(205, 104);
            this.comboBoxUnapred.Name = "comboBoxUnapred";
            this.comboBoxUnapred.Size = new System.Drawing.Size(327, 29);
            this.comboBoxUnapred.TabIndex = 1;
            // 
            // ChartTemps
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartTemps.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartTemps.Legends.Add(legend1);
            this.ChartTemps.Location = new System.Drawing.Point(602, 4);
            this.ChartTemps.Name = "ChartTemps";
            this.ChartTemps.Size = new System.Drawing.Size(723, 316);
            this.ChartTemps.TabIndex = 9;
            title1.Name = "Title1";
            title1.Text = "naslov";
            this.ChartTemps.Titles.Add(title1);
            // 
            // btnHideMap
            // 
            this.btnHideMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideMap.Location = new System.Drawing.Point(1201, 338);
            this.btnHideMap.Name = "btnHideMap";
            this.btnHideMap.Size = new System.Drawing.Size(137, 40);
            this.btnHideMap.TabIndex = 26;
            this.btnHideMap.Text = "Sakrij kartu";
            this.btnHideMap.UseVisualStyleBackColor = true;
            this.btnHideMap.Click += new System.EventHandler(this.btnHideMap_Click);
            // 
            // textBoxSearchForStats
            // 
            this.textBoxSearchForStats.Location = new System.Drawing.Point(16, 345);
            this.textBoxSearchForStats.Name = "textBoxSearchForStats";
            this.textBoxSearchForStats.Size = new System.Drawing.Size(178, 29);
            this.textBoxSearchForStats.TabIndex = 6;
            this.textBoxSearchForStats.TextChanged += new System.EventHandler(this.textBoxSearchForStats_TextChanged);
            // 
            // lblForSearch
            // 
            this.lblForSearch.AutoSize = true;
            this.lblForSearch.Location = new System.Drawing.Point(214, 348);
            this.lblForSearch.Name = "lblForSearch";
            this.lblForSearch.Size = new System.Drawing.Size(174, 21);
            this.lblForSearch.TabIndex = 7;
            this.lblForSearch.Text = "Pretraži po nazivu grada";
            // 
            // btnZatvoriGraf
            // 
            this.btnZatvoriGraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvoriGraf.Location = new System.Drawing.Point(615, 338);
            this.btnZatvoriGraf.Name = "btnZatvoriGraf";
            this.btnZatvoriGraf.Size = new System.Drawing.Size(137, 40);
            this.btnZatvoriGraf.TabIndex = 27;
            this.btnZatvoriGraf.Text = "Sakrij graf";
            this.btnZatvoriGraf.UseVisualStyleBackColor = true;
            this.btnZatvoriGraf.Click += new System.EventHandler(this.btnZatvoriGraf_Click);
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
            this.Temp.HeaderText = "Temperatura";
            this.Temp.Name = "Temp";
            // 
            // MinTemp
            // 
            this.MinTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MinTemp.DataPropertyName = "sMinTemp";
            this.MinTemp.HeaderText = "Minimalna temp.";
            this.MinTemp.Name = "MinTemp";
            // 
            // MaxTemp
            // 
            this.MaxTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaxTemp.DataPropertyName = "sMaxTemp";
            this.MaxTemp.HeaderText = "Maksimalna temp.";
            this.MaxTemp.Name = "MaxTemp";
            // 
            // CiniSeKao
            // 
            this.CiniSeKao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CiniSeKao.DataPropertyName = "sFeelsLike";
            this.CiniSeKao.HeaderText = "Subjektivni dojam";
            this.CiniSeKao.Name = "CiniSeKao";
            // 
            // Pressure
            // 
            this.Pressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pressure.DataPropertyName = "sPressure";
            this.Pressure.HeaderText = "Tlak zraka";
            this.Pressure.Name = "Pressure";
            // 
            // Humidity
            // 
            this.Humidity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Humidity.DataPropertyName = "sHumidity";
            this.Humidity.HeaderText = "Vlaga ";
            this.Humidity.Name = "Humidity";
            // 
            // Clouds
            // 
            this.Clouds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clouds.DataPropertyName = "sClouds";
            this.Clouds.HeaderText = "Postotak oblacnosti";
            this.Clouds.Name = "Clouds";
            // 
            // Wind
            // 
            this.Wind.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wind.DataPropertyName = "sWind";
            this.Wind.HeaderText = "Brzina vjetra";
            this.Wind.Name = "Wind";
            // 
            // Vidljivnost
            // 
            this.Vidljivnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vidljivnost.DataPropertyName = "sViewDistance";
            this.Vidljivnost.HeaderText = "Vidljivost";
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
            // FormPrognozeOdabraniGradovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1357, 694);
            this.Controls.Add(this.btnZatvoriGraf);
            this.Controls.Add(this.btnHideMap);
            this.Controls.Add(this.lblForSearch);
            this.Controls.Add(this.textBoxSearchForStats);
            this.Controls.Add(this.panelVrijeme);
            this.Controls.Add(this.dataGridViewOdabraniGradovi);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrognozeOdabraniGradovi";
            this.Text = "Statiskita gradova";
            this.Load += new System.EventHandler(this.FormPrognozeOdabraniGradovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdabraniGradovi)).EndInit();
            this.panelVrijeme.ResumeLayout(false);
            this.panelVrijeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTemps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOdabraniGradovi;
        private System.Windows.Forms.Panel panelVrijeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblForTime;
        private System.Windows.Forms.ComboBox comboBoxUnapred;
        private System.Windows.Forms.Button btnPrikaziGraf;
        private System.Windows.Forms.Label IdGradaLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTemps;
        private System.Windows.Forms.Button btnCloseGraph;
        private System.Windows.Forms.Button btnPrintToFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipGrafa;
        private System.Windows.Forms.Button buttonGrafStatistika;
        private System.Windows.Forms.TextBox textBoxSearchForStats;
        private System.Windows.Forms.Label lblForSearch;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Button btnHideMap;
        private System.Windows.Forms.Button btnZatvoriGraf;
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