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
        public addProduct(mainForm mf)
        {
            InitializeComponent();
            this.mnform = mf;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mnform.productGridView.Rows.Add(textBoxProductId.Text, textBoxProductName.Text, textBoxProductInventory.Text, textBoxProductPrice.Text);
        }
    }
}
