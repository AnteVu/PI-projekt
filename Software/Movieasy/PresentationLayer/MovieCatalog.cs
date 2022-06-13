using BusinessLayer;
using BusinessLayer.Services;
using DataAccessLayer.Model;
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
        List<Projection> Projections;
        List<Projection> FilteredProjections;
        public MovieCatalog()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void MovieCatalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieasyDataSet1.Projection' table. You can move, or remove it, as needed.
            this.projectionTableAdapter.Fill(this.movieasyDataSet1.Projection);
            RefreshForm();
        }

        private void RefreshForm()
        {
            Projections = _unitOfWork.Projections.GetAllProjections();
            FilteredProjections = Projections;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FilteredProjections;
        }

        private void btnDetalj_Click(object sender, EventArgs e)
        {
            FormDetails formDetails = new FormDetails();
            Hide();
            formDetails.ShowDialog();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            FormAddMovie formAddMovie = new FormAddMovie();
            Hide();
            formAddMovie.ShowDialog();
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
            System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#11-katalog-projekcija");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#11-katalog-projekcija");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnTeatre_Click(object sender, EventArgs e)
        {
            FormTeatre formTeatre = new FormTeatre();
            Hide();
            formTeatre.ShowDialog();
            Show();
        }

        private void buttonAddProjection_Click(object sender, EventArgs e)
        {
            FormAddProjection formAddProjection = new FormAddProjection();
            Hide();
            formAddProjection.ShowDialog();
        }

        private void btnPregledFilmova_Click(object sender, EventArgs e)
        {
            FormMovieList movieList = new FormMovieList();
            Hide();
            movieList.ShowDialog();
            Show();
        }

        private void dateTimePickerFilter_ValueChanged(object sender, EventArgs e)
        {
            FilteredProjections = Projections.Where(x => x.TimeFrom.Date >= dateTimePickerFilter.Value.Date).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FilteredProjections;
        }
    }
    
}
