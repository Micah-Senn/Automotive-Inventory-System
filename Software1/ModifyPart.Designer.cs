
namespace Software1
{
    partial class modifyPart
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
            this.textBoxPartID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxInOut = new System.Windows.Forms.TextBox();
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelInOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inHouseRadio = new System.Windows.Forms.RadioButton();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.ButtonModifyPartSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPartID
            // 
            this.textBoxPartID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPartID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxPartID.Enabled = false;
            this.textBoxPartID.Location = new System.Drawing.Point(125, 56);
            this.textBoxPartID.Name = "textBoxPartID";
            this.textBoxPartID.ReadOnly = true;
            this.textBoxPartID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartID.TabIndex = 3;
            this.textBoxPartID.TabStop = false;
            this.textBoxPartID.TextChanged += new System.EventHandler(this.textBoxModifyPartId_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 82);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxModifyPartName_TextChanged);
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Location = new System.Drawing.Point(125, 108);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(100, 20);
            this.textBoxInventory.TabIndex = 5;
            this.textBoxInventory.TextChanged += new System.EventHandler(this.textBoxModifyPartInv_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(125, 134);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 6;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxModifyPartPrice_TextChanged);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(125, 160);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(69, 20);
            this.textBoxMin.TabIndex = 7;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxModifyPartMin_TextChanged);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(252, 160);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(69, 20);
            this.textBoxMax.TabIndex = 8;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxModifyPartMax_TextChanged);
            // 
            // textBoxInOut
            // 
            this.textBoxInOut.Location = new System.Drawing.Point(125, 186);
            this.textBoxInOut.Name = "textBoxInOut";
            this.textBoxInOut.Size = new System.Drawing.Size(100, 20);
            this.textBoxInOut.TabIndex = 9;
            this.textBoxInOut.TextChanged += new System.EventHandler(this.textBoxInOut_TextChanged);
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(60, 13);
            this.modifyPartLabel.TabIndex = 7;
            this.modifyPartLabel.Text = "Modify Part";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(101, 59);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(84, 85);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Min";
            // 
            // labelInOut
            // 
            this.labelInOut.AutoSize = true;
            this.labelInOut.Location = new System.Drawing.Point(37, 189);
            this.labelInOut.Name = "labelInOut";
            this.labelInOut.Size = new System.Drawing.Size(82, 13);
            this.labelInOut.TabIndex = 13;
            this.labelInOut.Text = "Company Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Max";
            // 
            // inHouseRadio
            // 
            this.inHouseRadio.AutoSize = true;
            this.inHouseRadio.Location = new System.Drawing.Point(104, 7);
            this.inHouseRadio.Name = "inHouseRadio";
            this.inHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.inHouseRadio.TabIndex = 1;
            this.inHouseRadio.TabStop = true;
            this.inHouseRadio.Text = "In-House";
            this.inHouseRadio.UseVisualStyleBackColor = true;
            this.inHouseRadio.CheckedChanged += new System.EventHandler(this.inHouseRadio_CheckedChanged);
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Location = new System.Drawing.Point(178, 7);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadio.TabIndex = 2;
            this.outsourcedRadio.TabStop = true;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.outsourcedRadio_CheckedChanged);
            // 
            // ButtonModifyPartSave
            // 
            this.ButtonModifyPartSave.Location = new System.Drawing.Point(229, 234);
            this.ButtonModifyPartSave.Name = "ButtonModifyPartSave";
            this.ButtonModifyPartSave.Size = new System.Drawing.Size(50, 30);
            this.ButtonModifyPartSave.TabIndex = 17;
            this.ButtonModifyPartSave.Text = "Save";
            this.ButtonModifyPartSave.UseVisualStyleBackColor = true;
            this.ButtonModifyPartSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(296, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 30);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // modifyPart
            // 
            this.AcceptButton = this.ButtonModifyPartSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonModifyPartSave);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.inHouseRadio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelInOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.modifyPartLabel);
            this.Controls.Add(this.textBoxInOut);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPartID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "modifyPart";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPartID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxInOut;
        private System.Windows.Forms.Label modifyPartLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelInOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton inHouseRadio;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.Button ButtonModifyPartSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}