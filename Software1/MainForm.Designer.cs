
namespace Software1
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.partSearch = new System.Windows.Forms.Button();
            this.productSearch = new System.Windows.Forms.Button();
            this.partGridView = new System.Windows.Forms.DataGridView();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.addPart = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.exitMain = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelParts = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partSearch
            // 
            this.partSearch.Location = new System.Drawing.Point(298, 74);
            this.partSearch.Name = "partSearch";
            this.partSearch.Size = new System.Drawing.Size(60, 20);
            this.partSearch.TabIndex = 0;
            this.partSearch.Text = "Search";
            this.partSearch.UseVisualStyleBackColor = true;
            this.partSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(981, 74);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(60, 20);
            this.productSearch.TabIndex = 1;
            this.productSearch.Text = "Search";
            this.productSearch.UseVisualStyleBackColor = true;
            // 
            // partGridView
            // 
            this.partGridView.AllowUserToAddRows = false;
            this.partGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.partGridView.Location = new System.Drawing.Point(12, 115);
            this.partGridView.Name = "partGridView";
            this.partGridView.ReadOnly = true;
            this.partGridView.RowHeadersVisible = false;
            this.partGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partGridView.Size = new System.Drawing.Size(586, 158);
            this.partGridView.TabIndex = 2;
            this.partGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partGridView_CellContentClick);
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(689, 115);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(572, 158);
            this.productGridView.TabIndex = 3;
            this.productGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(361, 297);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 38);
            this.addPart.TabIndex = 4;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(1024, 297);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 38);
            this.addProduct.TabIndex = 7;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(442, 297);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(75, 38);
            this.modifyPart.TabIndex = 5;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(523, 297);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 38);
            this.deletePart.TabIndex = 6;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(1105, 297);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(75, 38);
            this.modifyProduct.TabIndex = 8;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(1186, 297);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 38);
            this.deleteProduct.TabIndex = 9;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // exitMain
            // 
            this.exitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMain.Location = new System.Drawing.Point(1186, 408);
            this.exitMain.Name = "exitMain";
            this.exitMain.Size = new System.Drawing.Size(75, 41);
            this.exitMain.TabIndex = 10;
            this.exitMain.Text = "Exit";
            this.exitMain.UseVisualStyleBackColor = true;
            this.exitMain.Click += new System.EventHandler(this.exitMain_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMain.Location = new System.Drawing.Point(7, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(310, 25);
            this.labelMain.TabIndex = 11;
            this.labelMain.Text = "Inventory Management System";
            this.labelMain.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParts.Location = new System.Drawing.Point(12, 86);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(51, 20);
            this.labelParts.TabIndex = 12;
            this.labelParts.Text = "Parts";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(685, 86);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(80, 20);
            this.labelProducts.TabIndex = 13;
            this.labelProducts.Text = "Products";
            this.labelProducts.Click += new System.EventHandler(this.label3_Click);
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(1047, 74);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(214, 20);
            this.productSearchBox.TabIndex = 1;
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(364, 73);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(234, 20);
            this.partSearchBox.TabIndex = 0;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(Software1.Inventory);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 461);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.labelParts);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.exitMain);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.partGridView);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.partSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button partSearch;
        private System.Windows.Forms.Button productSearch;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button exitMain;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.TextBox partSearchBox;
        public System.Windows.Forms.DataGridView partGridView;
        public System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
    }
}

