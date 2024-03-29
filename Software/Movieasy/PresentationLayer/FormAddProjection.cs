﻿using BusinessLayer.Services;
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
    public partial class FormAddProjection : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormAddProjection()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie selectedMovie = comboBoxMovies.SelectedItem as Movie;
            Teatre selectedTeatre = comboBoxTeatres.SelectedItem as Teatre;
            Hall selectedHall = comboBox2.SelectedItem as Hall;
            DateTime timeFrom = datePickerFrom.Value.Date + timePickerFrom.Value.TimeOfDay;
            DateTime timeTo = datePickerTo.Value.Date + timePickerTo.Value.TimeOfDay;
            Projection projection = new Projection(timeFrom, timeTo, selectedMovie, selectedTeatre, selectedHall);
            var newProjection = _unitOfWork.Projections.Add(projection);
            _unitOfWork.Complete();
            Close();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#14-dodaj-projekciju");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#14-dodaj-projekciju");
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
            timePickerFrom.Format = DateTimePickerFormat.Time;
            timePickerFrom.ShowUpDown = true;

            timePickerTo.Format = DateTimePickerFormat.Time;
            timePickerTo.ShowUpDown = true;

            RefreshForm();
        }

        private void RefreshForm()
        {
            List<Movie> movies = _unitOfWork.Movies.GetAll();

            comboBoxMovies.DataSource = movies;
            comboBoxMovies.DisplayMember = "Name";

            List<Teatre> teatres = _unitOfWork.Teatres.GetAllTeatres();

            comboBoxTeatres.DataSource = teatres;
            comboBoxTeatres.DisplayMember = "Name";
        }

        private void comboBoxTeatres_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Teatre selectedTeatre = comboBoxTeatres.SelectedItem as Teatre;

            comboBox2.DataSource = selectedTeatre.Halls;
            comboBox2.DisplayMember = "Id";
        }

       
    }
}
