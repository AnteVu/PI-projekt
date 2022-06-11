using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MovieCatalog : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public MovieCatalog()
        {
            InitializeComponent();
        }

        private void MovieCatalog_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _unitOfWork;
        }

        private void btnDetalj_Click(object sender, EventArgs e)
        {
            FormDetails formDetails = new FormDetails();
            this.Hide();
            formDetails.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            this.Hide();
            formAdd.ShowDialog();
        }
        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            FormGenre formGenre = new FormGenre();
            Hide();
            formGenre.ShowDialog();
            Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#11-katalog-filmova");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#11-katalog-filmova");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
    
}
