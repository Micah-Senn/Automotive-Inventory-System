using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
            Form1_Load();
        }


        public void Form1_Load()
        {

            Software1.Inventory.Populate();
            partGridView.DataSource = Software1.Inventory.Parts;
            productGridView.DataSource = Software1.Inventory.Products;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (partSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.Parts.Count; i++)
                {
                    if (Inventory.Parts[i].Name.ToUpper().Contains(partSearchBox.Text.ToUpper()))
                     { 
                        TempList.Add(Inventory.Parts[i]);
                        found = true;
                     }
                    if (found == true)
                        partGridView.DataSource = TempList;

                   
                }
                if (found == false)
                {
                    MessageBox.Show("No results found", "Invalid search");
                    partGridView.DataSource = Inventory.Parts;
                }
            }
    }

        
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addPart_Click(object sender, EventArgs e)
        {
            addPart addPart = new addPart();  //navigates to add part screen
            addPart.ShowDialog();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            addProduct addProduct = new addProduct(this); //navigates to add product screen
            addProduct.ShowDialog();
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            if (partGridView.Rows.Count == 0)
            {
                MessageBox.Show("The parts table is empty", "Invalid command"); //if part table is empty it will not allow the modify screen to open
            }
            else if (partGridView.CurrentRow.DataBoundItem.GetType() == typeof(Software1.InHousePart))
            {
                InHousePart inHousePart = (InHousePart)partGridView.CurrentRow.DataBoundItem;
                new modifyPart(inHousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)partGridView.CurrentRow.DataBoundItem;
                new modifyPart(outsourcedPart).ShowDialog();
            }
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            if (productGridView.Rows.Count == 0)
            {
                MessageBox.Show("The product table is empty", "Invalid command"); //if product table is empty it will not allow the modify screen to open
            }
            Product selected = (Product)productGridView.CurrentRow.DataBoundItem; //navigates to modify product screen
            new modifyProduct(selected).ShowDialog();
        }

        private void exitMain_Click(object sender, EventArgs e)
        {
            this.Close();  //closes the application
        }
       

        private void deletePart_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this item?", "Confirm deletion", MessageBoxButtons.OKCancel);

            if (confirmDelete == DialogResult.OK && partGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in partGridView.SelectedRows)
                {
                    partGridView.Rows.RemoveAt(row.Index);
                }
            }
            else
            { MessageBox.Show("No rows to delete", "Invalid deletion");
              
            }




        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)productGridView.CurrentRow.DataBoundItem;
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this item?", "Confirm deletion", MessageBoxButtons.OKCancel);

            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot remove a product with associated parts", "Invalid deletion");
            }

            else if (productGridView.Rows.Count < 0)
            {
                MessageBox.Show("No rows to delete", "Invalid deletion");
            }

            else if (confirmDelete == DialogResult.OK)
            {
                foreach (DataGridViewRow row in productGridView.SelectedRows)
                {
                    productGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void partGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void partSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        public int ProductSearchBox
        {
            get { return int.Parse(productSearchBox.Text); }
            set { productSearchBox.Text = value.ToString(); }
        }
        private void productSearch_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempProductList = new BindingList<Product>();
            bool found = false;
            if (productSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(productSearchBox.Text.ToUpper()))
                    {
                        TempProductList.Add(Inventory.Products[i]);
                        found = true;
                    }
                    if (found == true)
                        productGridView.DataSource = TempProductList;


                }
                if (found == false)
                {
                    MessageBox.Show("No results found", "Invalid search");
                    productGridView.DataSource = Inventory.Products;
                }
            }
        }
    }
}
