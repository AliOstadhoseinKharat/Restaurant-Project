using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmEmployee : Form
    {
        private readonly EmployeeRepository repo = new EmployeeRepository();

        #region DataBinders
        private void BindGrid()
        {
            grdEmployees.AutoGenerateColumns = false;
            grdEmployees.DataSource = null;
            grdEmployees.DataSource = repo.GetAll();
        }

        private void Search()
        {

        }

        #endregion

        #region Utility
        private void ClearForm()
        {
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    var text = (TextBox)ctrl as TextBox;
                    text.Text = "";
                }

                if (ctrl is ComboBox)
                {
                    var cmb = (ComboBox)ctrl as ComboBox;
                    cmb.SelectedIndex = -1;
                }
            }
        }

        #endregion
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void grdEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                FirstName = firstNameInput.Text,
                LastName = lastNameInput.Text,
                UserName = userNameInput.Text,
                Password = passwordInput.Text,
                IsActive = rdbActive.Checked,
            };
        }
    }
}
