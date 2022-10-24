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

        mainForm mnform;
        public modifyPart(mainForm mf)
        {
            InitializeComponent();
            this.mnform = mf;
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

        }

        private void button1_Click(object sender, EventArgs e) //modify part screen save button
        {
            foreach (DataGridViewRow row in mnform.partGridView.SelectedRows)
            {
                mnform.partGridView.Rows.RemoveAt(row.Index);
            }
            foreach (DataGridViewRow row in mnform.partGridView.SelectedRows)

                mnform.partGridView.Rows.Add(textBoxModifyPartId.Text, textBoxModifyPartName.Text, textBoxModifyPartInv.Text, textBoxModifyPartPrice.Text);
            this.Close();
        }
    }
}
