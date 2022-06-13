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
    public partial class FormMovieList : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormMovieList()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMovieList_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<Movie> movies = _unitOfWork.Movies.GetAllMovies();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = movies;

            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].NumberOfProjections > 100)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }


            List<Movie> filteredMovies = movies.Where(x => x.LastShowed != null).ToList();

            List<Movie> alertedMovies = filteredMovies.Where(x => DateTime.Now.Subtract((DateTime)x.LastShowed).TotalDays > 364).ToList();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = alertedMovies;


        }
    }
}
