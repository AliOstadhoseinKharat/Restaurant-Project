using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            CategoryRepository repo = new CategoryRepository();
            Category cat = new Category
            {
                CategoryName = catNameTextBox.Text,
                Description = catDescriptionTextBox.Text,
            };
            repo.Add(cat);

            /**** Load Grid Data */
            BindGrid();

            /*** Clear Form  */
            ClearForm();
        }

        private void ClearForm()
        {
            catNameTextBox.Text = "";
            catDescriptionTextBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("آیا مطمئن هستید ؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int cateID = Convert.ToInt32(grdCategories.Rows[e.RowIndex].Cells[0].Value);
                    CategoryRepository repo = new CategoryRepository();
                    bool hasFood = repo.HasFood(cateID);

                    if (!hasFood)
                    {
                        repo.Remove(cateID);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("این رده دارای کالای زیر مجموعه است.");
                    }
                }
            }
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            grdCategories.AutoGenerateColumns = false;
            grdCategories.DataSource = null;
            CategoryRepository repo = new CategoryRepository();
            grdCategories.DataSource = repo.GetAll();
        }
    }
}
