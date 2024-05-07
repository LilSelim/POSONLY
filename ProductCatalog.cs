using System.Data;
using System.Windows.Forms;
using System;

namespace SalesAdminscreenfinal
{
    public partial class ProductCatalog : Form
    {
        private DataTable vehicleDataTable;

        private ShoppingCartForm shoppingCartForm;

        public ProductCatalog(DataTable dataTable, ShoppingCartForm shoppingCartForm)
        {
            InitializeComponent();
            vehicleDataTable = dataTable;
            this.shoppingCartForm = shoppingCartForm;
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Set up DataGridView properties
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = vehicleDataTable;

            // Add columns for displaying vehicle information
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            imageColumn.DataPropertyName = "Image"; 
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(imageColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.DataPropertyName = "Name";
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.HeaderText = "Price";
            priceColumn.DataPropertyName = "Price";
            dataGridView1.Columns.Add(priceColumn);

            // Handle cell click event to make images clickable
            dataGridView1.CellClick += DataGridView1_CellClick;
        }
        private void OpenShoppingCartButton_Click(object sender, EventArgs e)
        {
            var shoppingCartForm = new ShoppingCartForm();
            shoppingCartForm.Show();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ImageColumn"].Index)
            {
                string vehicleName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                decimal vehiclePrice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value);

                var item = new Item { Name = vehicleName, Price = vehiclePrice };
                shoppingCartForm.AddItem(item);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}