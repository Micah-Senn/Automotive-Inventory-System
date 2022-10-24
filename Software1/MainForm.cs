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


        private void Form1_Load()
        {

            Software1.Inventory.Populate();
            partGridView.DataSource = Software1.Inventory.Parts;
            productGridView.DataSource = Software1.Inventory.Products;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            addPart addPart = new addPart(this);  //navigates to add part screen
            addPart.ShowDialog();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            addProduct addProduct = new addProduct(this); //navigates to add product screen
            addProduct.ShowDialog();
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            modifyPart modifyPart = new modifyPart(this);  //navigates to modify part screen
            modifyPart.ShowDialog();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            modifyProduct modifyProduct = new modifyProduct(this); //navigates to modify product screen
            modifyProduct.ShowDialog();
        }

        private void exitMain_Click(object sender, EventArgs e)
        {
            this.Close();  //closes the application
        }
       

        private void deletePart_Click(object sender, EventArgs e)
        {
            if (partGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in partGridView.SelectedRows)
                {
                    partGridView.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("No rows to delete");
            }
           
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (productGridView.Rows.Count  > 0)
           {
                foreach (DataGridViewRow row in productGridView.SelectedRows)
                {
                    productGridView.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("No rows to delete");
            }
        }

        private void partGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
