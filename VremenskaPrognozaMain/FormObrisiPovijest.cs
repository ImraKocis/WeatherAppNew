using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cites;

namespace VremenskaPrognozaMain
{
    public partial class FormObrisiPovijest : Form
    {
        private WeatherRepository _WeatherRepository = new WeatherRepository();
        private BindingSource bindingSource = new BindingSource();
        private int nIdMjerenje;
        private Form GlavnaForma = new Form();
        public FormObrisiPovijest(int IdMjerenja, Form Obrisano)
        {
            nIdMjerenje = IdMjerenja;
            GlavnaForma = Obrisano as FormHistory;
            InitializeComponent();
        }

        private void buttonCloseObrisi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisiPovijest_Click(object sender, EventArgs e)
        {
            _WeatherRepository.ObrisiPovijestDb(nIdMjerenje);
            DataGridView dataGridView = (DataGridView)this.GlavnaForma.Controls[0];
            bindingSource.DataSource = _WeatherRepository.DohvatiPovijetsMjerenja();
            dataGridView.DataSource = bindingSource;

            //Console.WriteLine(GlavnaForma.Controls[0]);
            this.Close();
        }
    }
}
