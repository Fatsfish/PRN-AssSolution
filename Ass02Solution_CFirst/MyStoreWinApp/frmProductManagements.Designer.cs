
namespace SalesWinApp
{
    partial class frmProductManagements
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
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.txtProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(490, 161);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(219, 23);
            this.txtFreight.TabIndex = 63;
            this.txtFreight.TextChanged += new System.EventHandler(this.txtFreight_TextChanged);
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(490, 127);
            this.txtShippedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(219, 23);
            this.txtShippedDate.TabIndex = 62;
            this.txtShippedDate.TextChanged += new System.EventHandler(this.txtShippedDate_TextChanged);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtProductId,
            this.txtUnitPrice,
            this.txtDiscount,
            this.txtQuantity});
            this.dgvMemberList.Location = new System.Drawing.Point(134, 238);
            this.dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(518, 126);
            this.dgvMemberList.TabIndex = 61;
            this.dgvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellContentClick);
            // 
            // txtProductId
            // 
            this.txtProductId.HeaderText = "Product ID";
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.HeaderText = "Unit Price";
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            // 
            // txtDiscount
            // 
            this.txtDiscount.HeaderText = "Discount";
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.HeaderText = "Quantity";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(134, 203);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 22);
            this.btnLoad.TabIndex = 60;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(351, 203);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 22);
            this.btnNew.TabIndex = 59;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(570, 203);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(189, 161);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.PasswordChar = '*';
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(192, 23);
            this.txtOrderDate.TabIndex = 57;
            this.txtOrderDate.TextChanged += new System.EventHandler(this.txtOrderDate_TextChanged);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(189, 127);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(192, 23);
            this.txtMemberID.TabIndex = 56;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(189, 87);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(192, 23);
            this.txtOrderID.TabIndex = 55;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(490, 87);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(219, 23);
            this.txtRequiredDate.TabIndex = 54;
            this.txtRequiredDate.TextChanged += new System.EventHandler(this.txtRequiredDate_TextChanged);
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(403, 90);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            this.lbRequiredDate.TabIndex = 53;
            this.lbRequiredDate.Text = "Required Date";
            this.lbRequiredDate.Click += new System.EventHandler(this.lbRequiredDate_Click);
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(403, 164);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 52;
            this.lbFreight.Text = "Freight";
            this.lbFreight.Click += new System.EventHandler(this.lbFreight_Click);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(403, 129);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(77, 15);
            this.lbCountry.TabIndex = 51;
            this.lbCountry.Text = "Shipped Date";
            this.lbCountry.Click += new System.EventHandler(this.lbCountry_Click);
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(92, 127);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(66, 15);
            this.lbMemberID.TabIndex = 50;
            this.lbMemberID.Text = "Member ID";
            this.lbMemberID.Click += new System.EventHandler(this.lbMemberID_Click);
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(92, 161);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 49;
            this.lbOrderDate.Text = "Order Date";
            this.lbOrderDate.Click += new System.EventHandler(this.lbOrderDate_Click);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(92, 90);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(51, 15);
            this.lbOrderID.TabIndex = 48;
            this.lbOrderID.Text = "Order ID";
            this.lbOrderID.Click += new System.EventHandler(this.lbOrderID_Click);
            // 
            // frmProductManagements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmProductManagements";
            this.Text = "frmProductManagements";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderID;
    }
}