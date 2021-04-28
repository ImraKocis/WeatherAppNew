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
    public partial class FormUpdate : Form
    {
        private CityRepository _CityRepository = new CityRepository();
        private BindingSource bindingSource = new BindingSource();
        private int GradId;
        private Form GlavnaForma = new Form();
        public FormUpdate(int IdGrada, Form Azurirano)
        {
            GradId = IdGrada;
            GlavnaForma = Azurirano as MainForm;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _CityRepository.UpdateCityDb(GradId.ToString(), inputNazivGrada.Text);
            DataGridView dataGridView = (DataGridView)this.GlavnaForma.Controls[6];
            bindingSource.DataSource = _CityRepository.DohvatiGradoveDb();
            dataGridView.DataSource = bindingSource;
            //Console.WriteLine(GlavnaForma.Controls[6]);
            this.Close();
        }
    }
}
