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
    public partial class FormAdd : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormAdd()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Genre genre = comboBox1.SelectedItem as Genre;
            int duration = int.Parse(textBox4.Text);
            string description = richTextBox1.Text;
            DateTime showDate = this.showDatePicker.Value;
            Movie movie = new Movie(name,genre,duration,description, showDate);
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
    }
}
