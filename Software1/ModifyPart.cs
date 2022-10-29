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
    public partial class modifyPart : Form
    {
        mainForm MainForm = (mainForm)Application.OpenForms["MainForm"];

        public int TextBoxPartID
        {
            get { return int.Parse(textBoxPartID.Text); }
            set { textBoxPartID.Text = value.ToString(); }
        }
        public string TextBoxPartName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value.ToString(); }
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
        public modifyPart(InHousePart inHousePart)
        {
            InitializeComponent();
            TextBoxPartID = inHousePart.PartID;
            TextBoxPartName = inHousePart.Name;
            TextBoxPrice = decimal.Parse(inHousePart.Price.Substring(1));
            TextBoxInventory = inHousePart.Current_Inventory;
            TextBoxMin = inHousePart.Min;
            TextBoxMax = inHousePart.Max;
            TextBoxInOut = inHousePart.MachineID.ToString();
            inHouseRadio.Checked = true;

        }
        public modifyPart(OutsourcedPart outsourcedPart)
        {
            InitializeComponent();
            TextBoxPartID = outsourcedPart.PartID;
            TextBoxPartName = outsourcedPart.Name;
            TextBoxPrice = decimal.Parse(outsourcedPart.Price.Substring(1));
            TextBoxInventory = outsourcedPart.Current_Inventory;
            TextBoxMin = outsourcedPart.Min;
            TextBoxMax = outsourcedPart.Max;
            TextBoxInOut = outsourcedPart.CompanyName.ToString();
            outsourcedRadio.Checked = true;

        }
        private void button1_Click(object sender, EventArgs e) //modify part screen save button
        {
            if (TextBoxMin > TextBoxMax)
            {
                MessageBox.Show("Minimum cannot be greater than the maximum.", "Invalid entry");
                return;
            }

            if (TextBoxMin > TextBoxInventory || TextBoxInventory > TextBoxMax)
            {
                MessageBox.Show("Inventory must be between minimum and maximum");
                return;
            }
            if (inHouseRadio.Checked)
            {
                    
                InHousePart inHousePart = new InHousePart(TextBoxPartID, TextBoxPartName, TextBoxPrice, TextBoxInventory, TextBoxMin, TextBoxMax, int.Parse(TextBoxInOut));
                Inventory.ModifyInHousePart(TextBoxPartID, inHousePart);
                inHouseRadio.Checked = true;
            }

            else
            {
                OutsourcedPart outsourcedPart = new OutsourcedPart(TextBoxPartID, TextBoxPartName, TextBoxPrice, TextBoxInventory, TextBoxMin, TextBoxMax, TextBoxInOut);
                Inventory.ModifyOutsourcedPart(TextBoxPartID, outsourcedPart);
                outsourcedRadio.Checked = true;
            }

            MainForm.partGridView.Update();
            MainForm.partGridView.Refresh();
            this.Close();
        }
        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxModifyPartId_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPartID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxPartID.Text = textBoxPartID.Text.Remove(textBoxPartID.Text.Length - 1);
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

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            labelInOut.Text = "Company Name";
        }

        private void textBoxInOut_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRadio.Checked)
            {
               
            }
        }

        private void textBoxModifyPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModifyPartInv_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxInventory.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxInventory.Text = textBoxInventory.Text.Remove(textBoxInventory.Text.Length - 1);
            }

        }

        private void textBoxModifyPartPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPrice.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxPrice.Text = textBoxPrice.Text.Remove(textBoxPrice.Text.Length - 1);
            }
        }

        private void textBoxModifyPartMin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMin.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxMin.Text = textBoxMin.Text.Remove(textBoxMin.Text.Length - 1);
            }

        }

        private void textBoxModifyPartMax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMax.Text, "[^0-9]"))
            {

                MessageBox.Show("Please enter only numerical values.");
                textBoxMax.Text = textBoxMax.Text.Remove(textBoxMax.Text.Length - 1);
            }

        }
    }
}
