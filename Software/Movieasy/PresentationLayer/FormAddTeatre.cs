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
    public partial class FormAddTeatre : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private Teatre Teatre = new Teatre();

        public FormAddTeatre()
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
            string name = textBoxName.Text;
            string address = textBoxAdress.Text;
            string oib = textBoxOIB.Text;
            string telephone = textBoxTelephone.Text;
            string email = textBoxEMail.Text;

            Teatre.Name = name;
            Teatre.Address = address;
            Teatre.OIB = oib;
            Teatre.Phone = telephone;
            Teatre.EMail = email;

            Teatre newTeatre = _unitOfWork.Teatres.Add(Teatre);
            _unitOfWork.Complete();

            Close();
        }

        private void buttonAddHall_Click(object sender, EventArgs e)
        {
            int capacity = int.Parse(textBoxCapacity.Text);


            Hall hall = new Hall(capacity);
            var newHall = _unitOfWork.Halls.Add(hall);
            _unitOfWork.Complete();

            Teatre.Halls.Add(newHall);

            RefreshDataGrid();
        }

        private void FormAddTeatre_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridViewHalls.DataSource = null;
            var listBinding = new BindingList<Hall>((IList<Hall>)Teatre.Halls);
            dataGridViewHalls.DataSource = listBinding;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#13-dodaj-kino");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi22-thodak-pkordic-avucic/wiki/4)-Korisni%C4%8Dka-dokumentacija#13-dodaj-kino");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
