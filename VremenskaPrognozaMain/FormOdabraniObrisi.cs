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
    public partial class FormOdabraniObrisi : Form
    {
        private CityRepository _CityRepository = new CityRepository();
        private WeatherRepository _WeatherRepository = new WeatherRepository();
        private BindingSource bindingSource = new BindingSource();
        private int GradId;
        private Form GlavnaForma = new Form();
        public FormOdabraniObrisi(int IdGrada, Form Obrisano)
        {
            GradId = IdGrada;
            GlavnaForma = Obrisano as FormPrognozeOdabraniGradovi;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            _CityRepository.BrisanjeOdabranogGrada(GradId);
            DataGridView dataGridView = (DataGridView)this.GlavnaForma.Controls[5];
            bindingSource.DataSource = _WeatherRepository.DohvatiPrognozeOdabranihGradova();
            dataGridView.DataSource = bindingSource;

            //Console.WriteLine(GlavnaForma.Controls[5]);
            this.Close();
        }
    }
}
