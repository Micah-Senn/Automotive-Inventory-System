
namespace Software1
{
    partial class addProduct
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.associatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.partGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modifyProductLabel = new System.Windows.Forms.Label();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxProductMax = new System.Windows.Forms.TextBox();
            this.textBoxProductMin = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductInventory = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(820, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 7;
            // 
            // associatedPartsGrid
            // 
            this.associatedPartsGrid.AllowUserToAddRows = false;
            this.associatedPartsGrid.AllowUserToResizeColumns = false;
            this.associatedPartsGrid.AllowUserToResizeRows = false;
            this.associatedPartsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGrid.Location = new System.Drawing.Point(421, 264);
            this.associatedPartsGrid.Name = "associatedPartsGrid";
            this.associatedPartsGrid.ReadOnly = true;
            this.associatedPartsGrid.RowHeadersVisible = false;
            this.associatedPartsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.associatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGrid.Size = new System.Drawing.Size(602, 140);
            this.associatedPartsGrid.TabIndex = 11;
            this.associatedPartsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associatedPartsGrid_CellContentClick);
            // 
            // partGridView
            // 
            this.partGridView.AllowUserToAddRows = false;
            this.partGridView.AllowUserToResizeColumns = false;
            this.partGridView.AllowUserToResizeRows = false;
            this.partGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.Location = new System.Drawing.Point(421, 71);
            this.partGridView.Name = "partGridView";
            this.partGridView.ReadOnly = true;
            this.partGridView.RowHeadersVisible = false;
            this.partGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partGridView.Size = new System.Drawing.Size(602, 140);
            this.partGridView.TabIndex = 9;
            this.partGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partGridView_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "All Parts";
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Padding = new System.Windows.Forms.Padding(5);
            this.modifyProductLabel.Size = new System.Drawing.Size(118, 30);
            this.modifyProductLabel.TabIndex = 22;
            this.modifyProductLabel.Text = "Add Product";
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.Location = new System.Drawing.Point(917, 469);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(50, 30);
            this.buttonSaveProduct.TabIndex = 13;
            this.buttonSaveProduct.Text = "Save";
            this.buttonSaveProduct.UseVisualStyleBackColor = true;
            this.buttonSaveProduct.Click += new System.EventHandler(this.button5_Click);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(973, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(973, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(758, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxProductMax
            // 
            this.textBoxProductMax.Location = new System.Drawing.Point(251, 264);
            this.textBoxProductMax.Name = "textBoxProductMax";
            this.textBoxProductMax.Size = new System.Drawing.Size(50, 20);
            this.textBoxProductMax.TabIndex = 6;
            this.textBoxProductMax.TextChanged += new System.EventHandler(this.textBoxProductMax_TextChanged);
            // 
            // textBoxProductMin
            // 
            this.textBoxProductMin.Location = new System.Drawing.Point(151, 264);
            this.textBoxProductMin.Name = "textBoxProductMin";
            this.textBoxProductMin.Size = new System.Drawing.Size(50, 20);
            this.textBoxProductMin.TabIndex = 5;
            this.textBoxProductMin.TextChanged += new System.EventHandler(this.textBoxProductMin_TextChanged);
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(151, 234);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(150, 20);
            this.textBoxProductPrice.TabIndex = 4;
            this.textBoxProductPrice.TextChanged += new System.EventHandler(this.textBoxProductPrice_TextChanged);
            // 
            // textBoxProductInventory
            // 
            this.textBoxProductInventory.Location = new System.Drawing.Point(151, 198);
            this.textBoxProductInventory.Name = "textBoxProductInventory";
            this.textBoxProductInventory.Size = new System.Drawing.Size(150, 20);
            this.textBoxProductInventory.TabIndex = 3;
            this.textBoxProductInventory.TextChanged += new System.EventHandler(this.textBoxProductInventory_TextChanged);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(151, 165);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(150, 20);
            this.textBoxProductName.TabIndex = 2;
            this.textBoxProductName.TextChanged += new System.EventHandler(this.textBoxProductName_TextChanged);
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(151, 132);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(150, 20);
            this.textBoxProductId.TabIndex = 1;
            this.textBoxProductId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            // 
            // addProduct
            // 
            this.AcceptButton = this.buttonSaveProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.textBoxProductMax);
            this.Controls.Add(this.textBoxProductMin);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.textBoxProductInventory);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.associatedPartsGrid);
            this.Controls.Add(this.partGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.modifyProductLabel);
            this.Controls.Add(this.buttonSaveProduct);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView associatedPartsGrid;
        private System.Windows.Forms.DataGridView partGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label modifyProductLabel;
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxProductMax;
        private System.Windows.Forms.TextBox textBoxProductMin;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductInventory;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}