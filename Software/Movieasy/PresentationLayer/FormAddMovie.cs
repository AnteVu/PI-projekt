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
using BusinessLayer;
using DataAccessLayer.Model;

namespace PresentationLayer
{
    public partial class FormAddMovie : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormAddMovie()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Genre genre = comboBoxGenres.SelectedItem as Genre;
            int duration = int.Parse(textBox4.Text);
            string description = richTextBox1.Text;

            Movie movie = new Movie(name, duration, description, genre);

            _unitOfWork.Movies.Add(movie);
            _unitOfWork.Complete();

            Close();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#4-dodaj-film");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#4-dodaj-film");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<Genre> teatres = _unitOfWork.Genres.GetAll();

            comboBoxGenres.DataSource = teatres;
            comboBoxGenres.DisplayMember = "Name";
        }
    }
}
