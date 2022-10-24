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
        mainForm mnform;
        public modifyProduct(mainForm mf)
        {
            InitializeComponent();
            this.mnform = mf;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

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
            foreach (DataGridViewRow row in mnform.productGridView.SelectedRows)
            {
                mnform.productGridView.Rows.RemoveAt(row.Index);
            }
            foreach (DataGridViewRow row in mnform.productGridView.SelectedRows)

                mnform.productGridView.Rows.Add(textBoxModifyProdId.Text, textBoxModifyProdName.Text, textBoxModifyProdInv.Text, textBoxModifyProdPrice.Text);
            this.Close();
        }
    }
}
