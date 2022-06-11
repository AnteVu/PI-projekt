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
    public partial class FormGenre : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormGenre()
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
            string genreName = textBox1.Text;

            Genre genre = new Genre(genreName);
            _unitOfWork.Genres.Add(genre);
            _unitOfWork.Complete();
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#10-dodaj-%C5%BEanr");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#10-dodaj-%C5%BEanr");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
