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
    public partial class addPart : Form
    {
        public int TextBoxPartID
        {
            get { return int.Parse(textBoxPartID.Text); }
            set { textBoxPartID.Text = value.ToString(); }
        }
        public string TextBoxPartName
        {
            get { return textBoxPartName.Text; }
            set { textBoxPartName.Text = value.ToString(); }
        }
        public decimal TextBoxPrice
        {
            get { return decimal.Parse(textBoxPrice.Text); }
            set { textBoxPrice.Text = value.ToString(); }
        }
        public int TextBoxInventory
        {
            get { return int.Parse(textBoxInventory.Text); }
            set { textBoxInventory.Text = value.ToString(); }
        }
        public int TextBoxMin
        {
            get { return int.Parse(textBoxMin.Text); }
            set { textBoxMin.Text = value.ToString(); }
        }
        public int TextBoxMax
        {
            get { return int.Parse(textBoxMax.Text); }
            set { textBoxMax.Text = value.ToString(); }
        }

        public string TextBoxInOut
        {
            get { return textBoxInOut.Text; }
            set { textBoxInOut.Text = value; }
        }

        public addPart()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e) // cancel button closes document
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e) // add part screen save button
        {
           if (TextBoxMin > TextBoxMax)
            {
                MessageBox.Show("Minimum cannot be greater than the maximum."); 
                return;
            }

            if (inHouseRadio.Checked)
            {
                
                InHousePart inHousePart = new InHousePart(TextBoxPartID, TextBoxPartName, TextBoxPrice, TextBoxInventory,  TextBoxMin, TextBoxMax, int.Parse(TextBoxInOut));
                Inventory.AddPart(inHousePart);
            }
            
             else
             {
                 OutsourcedPart outsourcedPart = new OutsourcedPart(TextBoxPartID, TextBoxPartName, TextBoxPrice, TextBoxInventory, TextBoxMin, TextBoxMax, TextBoxInOut);
                 Inventory.AddPart(outsourcedPart);
             }
             this.Close();
        }

        private void addPart_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPartID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPartID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.");
                textBoxPartID.Text = textBoxPartID.Text.Remove(textBoxPartID.Text.Length - 1);
            }
        }

        private void textBoxPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxInventory.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.");
                textBoxInventory.Text = textBoxInventory.Text.Remove(textBoxInventory.Text.Length - 1);
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.");
            textBoxPrice.Text = textBoxPrice.Text.Remove(textBoxPrice.Text.Length - 1);
            }
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMin.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.");
                textBoxMin.Text = textBoxMin.Text.Remove(textBoxMin.Text.Length - 1);
            }
        }

        private void textBoxCompany_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRadio.Checked)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxInOut.Text, "[^0-9]"))
                {

                    MessageBox.Show("Please enter only numerical values for Machine ID");
                    textBoxInOut.Text = textBoxInOut.Text.Remove(textBoxInOut.Text.Length - 1);
                }
            }
                
           
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMax.Text, "[^0-9]"))
            {

                MessageBox.Show("Please enter only numerical values.");
                textBoxMax.Text = textBoxMax.Text.Remove(textBoxMax.Text.Length - 1);
            }
        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            labelInOut.Text = "Machine Id";
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxInOut.Text, "[^0-9]"))
            {
                textBoxInOut.Text = String.Empty;
            }
     
        }
        private void outsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            labelInOut.Text = "Company Name";
        }
    }
}
