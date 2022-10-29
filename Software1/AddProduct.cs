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
    public partial class addProduct : Form
    {
        mainForm mnform;
        BindingList<Part> associated = new BindingList<Part>();
        public int TextBoxProductID
        {
            get { return int.Parse(textBoxProductId.Text); }
            set { textBoxProductId.Text = value.ToString(); }
        }
        public string TextBoxProductName
        {
            get { return textBoxProductName.Text; }
            set { textBoxProductName.Text = value.ToString(); }
        }
        public decimal TextBoxProductPrice
        {
            get { return decimal.Parse(textBoxProductPrice.Text); }
            set { textBoxProductPrice.Text = value.ToString(); }
        }
        public int TextBoxProductInventory
        {
            get { return int.Parse(textBoxProductInventory.Text); }
            set { textBoxProductInventory.Text = value.ToString(); }
        }
        public int TextBoxProductMin
        {
            get { return int.Parse(textBoxProductMin.Text); }
            set { textBoxProductMin.Text = value.ToString(); }
        }
        public int TextBoxProductMax
        {
            get { return int.Parse(textBoxProductMax.Text); }
            set { textBoxProductMax.Text = value.ToString(); }
        }

        public addProduct(mainForm mf)
        {
            InitializeComponent();
            this.mnform = mf;
            partGridView.DataSource = Software1.Inventory.Parts;
            var associatedTable = new BindingSource();
            associatedPartsGrid.DataSource = associated;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxProductId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxProductId.Text = textBoxProductId.Text.Remove(textBoxProductId.Text.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TextBoxProductMin > TextBoxProductMax)
            {
                MessageBox.Show("Minimum cannot be greater than the maximum.", "Invalid entry");
                return;
            }

            if (TextBoxProductMin > TextBoxProductInventory || TextBoxProductInventory > TextBoxProductMax)
            {
                MessageBox.Show("Inventory must be between minimum and maximum");
                return;
            }
            Product product = new Product(TextBoxProductID, TextBoxProductName, TextBoxProductPrice, TextBoxProductInventory, TextBoxProductMin, TextBoxProductMax);
            Inventory.AddProduct(product);
            foreach (Part part in associated)
            {
                product.AddAssociatedPart(part);
            }
            this.Close();
        }

        private void partGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void associatedPartsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProductInventory_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxProductInventory.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxProductInventory.Text = textBoxProductInventory.Text.Remove(textBoxProductInventory.Text.Length - 1);
            }
        }

        private void textBoxProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxProductPrice.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxProductPrice.Text = textBoxProductPrice.Text.Remove(textBoxProductPrice.Text.Length - 1);
            }
        }

        private void textBoxProductMin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxProductMin.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxProductMin.Text = textBoxProductMin.Text.Remove(textBoxProductMin.Text.Length - 1);
            }
        }

        private void textBoxProductMax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxProductMax.Text, "[^0-9]"))
            {

                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxProductMax.Text = textBoxProductMax.Text.Remove(textBoxProductMax.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e) //delete button
        {
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this item?", "Confirm deletion", MessageBoxButtons.OKCancel);
            if (associatedPartsGrid.Rows.Count > 0 && confirmDelete == DialogResult.OK)
            {
                foreach (DataGridViewRow row in partGridView.SelectedRows)
                {
                    associatedPartsGrid.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("No rows to delete", "Invalid deletion");
            }
        }

        private void button2_Click(object sender, EventArgs e)//add button
        {
            Part associatedParts = (Part)partGridView.CurrentRow.DataBoundItem;
            associated.Add(associatedParts);
        }
    }
}
