﻿
namespace Software1
{
    partial class modifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.modifyProductLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxModifyProdId = new System.Windows.Forms.TextBox();
            this.textBoxModifyProdName = new System.Windows.Forms.TextBox();
            this.textBoxModifyProdInv = new System.Windows.Forms.TextBox();
            this.textBoxModifyProdPrice = new System.Windows.Forms.TextBox();
            this.textBoxModifyProdMin = new System.Windows.Forms.TextBox();
            this.textBoxModifyProdMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(973, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(973, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(973, 469);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 30);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(917, 469);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(50, 30);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button5_Click);
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Padding = new System.Windows.Forms.Padding(5);
            this.modifyProductLabel.Size = new System.Drawing.Size(138, 30);
            this.modifyProductLabel.TabIndex = 5;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "All Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(628, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 140);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(628, 264);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(395, 140);
            this.dataGridView2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(820, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBoxModifyProdId
            // 
            this.textBoxModifyProdId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxModifyProdId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxModifyProdId.Enabled = false;
            this.textBoxModifyProdId.Location = new System.Drawing.Point(151, 132);
            this.textBoxModifyProdId.Name = "textBoxModifyProdId";
            this.textBoxModifyProdId.ReadOnly = true;
            this.textBoxModifyProdId.Size = new System.Drawing.Size(150, 20);
            this.textBoxModifyProdId.TabIndex = 1;
            this.textBoxModifyProdId.TextChanged += new System.EventHandler(this.textBoxModifyProdId_TextChanged);
            // 
            // textBoxModifyProdName
            // 
            this.textBoxModifyProdName.Location = new System.Drawing.Point(151, 165);
            this.textBoxModifyProdName.Name = "textBoxModifyProdName";
            this.textBoxModifyProdName.Size = new System.Drawing.Size(150, 20);
            this.textBoxModifyProdName.TabIndex = 2;
            // 
            // textBoxModifyProdInv
            // 
            this.textBoxModifyProdInv.Location = new System.Drawing.Point(151, 198);
            this.textBoxModifyProdInv.Name = "textBoxModifyProdInv";
            this.textBoxModifyProdInv.Size = new System.Drawing.Size(150, 20);
            this.textBoxModifyProdInv.TabIndex = 3;
            // 
            // textBoxModifyProdPrice
            // 
            this.textBoxModifyProdPrice.Location = new System.Drawing.Point(151, 234);
            this.textBoxModifyProdPrice.Name = "textBoxModifyProdPrice";
            this.textBoxModifyProdPrice.Size = new System.Drawing.Size(150, 20);
            this.textBoxModifyProdPrice.TabIndex = 4;
            // 
            // textBoxModifyProdMin
            // 
            this.textBoxModifyProdMin.Location = new System.Drawing.Point(151, 264);
            this.textBoxModifyProdMin.Name = "textBoxModifyProdMin";
            this.textBoxModifyProdMin.Size = new System.Drawing.Size(50, 20);
            this.textBoxModifyProdMin.TabIndex = 5;
            // 
            // textBoxModifyProdMax
            // 
            this.textBoxModifyProdMax.Location = new System.Drawing.Point(251, 264);
            this.textBoxModifyProdMax.Name = "textBoxModifyProdMax";
            this.textBoxModifyProdMax.Size = new System.Drawing.Size(50, 20);
            this.textBoxModifyProdMax.TabIndex = 6;
            // 
            // modifyProduct
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.textBoxModifyProdMax);
            this.Controls.Add(this.textBoxModifyProdMin);
            this.Controls.Add(this.textBoxModifyProdPrice);
            this.Controls.Add(this.textBoxModifyProdInv);
            this.Controls.Add(this.textBoxModifyProdName);
            this.Controls.Add(this.textBoxModifyProdId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifyProductLabel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "modifyProduct";
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label modifyProductLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxModifyProdId;
        private System.Windows.Forms.TextBox textBoxModifyProdName;
        private System.Windows.Forms.TextBox textBoxModifyProdInv;
        private System.Windows.Forms.TextBox textBoxModifyProdPrice;
        private System.Windows.Forms.TextBox textBoxModifyProdMin;
        private System.Windows.Forms.TextBox textBoxModifyProdMax;
    }
}