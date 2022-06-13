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
    }
}
