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
    public partial class modifyProduct : Form
    {
        mainForm MainForm = (mainForm)Application.OpenForms["MainForm"];
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
        public modifyProduct(Product product)
        {
            InitializeComponent();
            ModifyProduct_Load(product);
            partGridView.DataSource = Software1.Inventory.Parts;
            var associatedTable = new BindingSource();
            associatedPartsGrid.DataSource = associated;

            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ModifyProduct_Load(Product selected)
        {
            TextBoxProductID = selected.ProductID;
            TextBoxProductName = selected.Name;
            TextBoxProductInventory = selected.Current_Inventory;
            TextBoxProductPrice = decimal.Parse(selected.Price.Substring(1));
            TextBoxProductMin = selected.Min;
            TextBoxProductMax = selected.Max;

            foreach (Part part in selected.AssociatedParts)
            {
                associated.Add(part);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxModifyProdId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TextBoxProductMin > TextBoxProductMax)
            {
                MessageBox.Show("Minimum cannot be greater than the maximum.", "Invalid entry");
                return;
            }

            if(TextBoxProductMin > TextBoxProductInventory || TextBoxProductInventory > TextBoxProductMax)
            {
                MessageBox.Show("Inventory must be between minimum and maximum");
                return;
            }
          
                Product updated = new Product(TextBoxProductID, TextBoxProductName, TextBoxProductPrice, TextBoxProductInventory, TextBoxProductMin, TextBoxProductMax);
            foreach (Part partAdd in associated)
            {
                updated.AddAssociatedPart(partAdd);
            }
            Inventory.ModifyProduct(TextBoxProductID, updated);
                
            
            MainForm.productGridView.Update();
            MainForm.productGridView.Refresh();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void associatedPartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //add button modify part screen
        {
            Part associatedParts = (Part)partGridView.CurrentRow.DataBoundItem;
            associated.Add(associatedParts);
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
