using BusinessLayer;
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
    public partial class FormTeatre : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormTeatre()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddTeatre addTeatre = new FormAddTeatre();
            Hide();
            addTeatre.ShowDialog();
            Show();
            RefreshDataGrid();
        }

        private void FormTeatre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieasyDataSet.Teatre' table. You can move, or remove it, as needed.
            this.teatreTableAdapter.Fill(this.movieasyDataSet.Teatre);
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridViewTeatres.DataSource = null;
            dataGridViewTeatres.DataSource = _unitOfWork.Teatres.GetAll();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#12-upravljanje-kinima");

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#12-upravljanje-kinima");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
