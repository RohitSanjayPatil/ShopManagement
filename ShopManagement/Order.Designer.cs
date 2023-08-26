namespace ShopManagement
{
    partial class Order
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
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdOrder = new System.Windows.Forms.DataGridView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.cmbbxProduct = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRrmoveFromCart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMobileno = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblMobileno1 = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.ListView = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConFirmOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(84, 35);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // grdOrder
            // 
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Location = new System.Drawing.Point(71, 116);
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.Size = new System.Drawing.Size(263, 190);
            this.grdOrder.TabIndex = 3;
            this.grdOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrder_CellContentClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(71, 387);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(239, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(213, 32);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(121, 21);
            this.cmbbxType.TabIndex = 6;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // cmbbxProduct
            // 
            this.cmbbxProduct.FormattingEnabled = true;
            this.cmbbxProduct.Location = new System.Drawing.Point(213, 83);
            this.cmbbxProduct.Name = "cmbbxProduct";
            this.cmbbxProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbbxProduct.TabIndex = 7;
            this.cmbbxProduct.SelectedIndexChanged += new System.EventHandler(this.cmbbxProduct_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(214, 328);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(359, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRrmoveFromCart
            // 
            this.btnRrmoveFromCart.Location = new System.Drawing.Point(359, 241);
            this.btnRrmoveFromCart.Name = "btnRrmoveFromCart";
            this.btnRrmoveFromCart.Size = new System.Drawing.Size(75, 53);
            this.btnRrmoveFromCart.TabIndex = 10;
            this.btnRrmoveFromCart.Text = "Remove From Cart";
            this.btnRrmoveFromCart.UseVisualStyleBackColor = true;
            this.btnRrmoveFromCart.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(500, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblMobileno
            // 
            this.lblMobileno.AutoSize = true;
            this.lblMobileno.Location = new System.Drawing.Point(500, 71);
            this.lblMobileno.Name = "lblMobileno";
            this.lblMobileno.Size = new System.Drawing.Size(53, 13);
            this.lblMobileno.TabIndex = 12;
            this.lblMobileno.Text = "Mobile.no";
            this.lblMobileno.Click += new System.EventHandler(this.lblMobileno_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(506, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(579, 22);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(41, 13);
            this.lblName1.TabIndex = 14;
            this.lblName1.Text = "Name1";
            // 
            // lblMobileno1
            // 
            this.lblMobileno1.AutoSize = true;
            this.lblMobileno1.Location = new System.Drawing.Point(579, 71);
            this.lblMobileno1.Name = "lblMobileno1";
            this.lblMobileno1.Size = new System.Drawing.Size(59, 13);
            this.lblMobileno1.TabIndex = 15;
            this.lblMobileno1.Text = "Mobile.no1";
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Location = new System.Drawing.Point(582, 116);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(38, 13);
            this.lblEmail1.TabIndex = 16;
            this.lblEmail1.Text = "Email1";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(463, 404);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 17;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(626, 407);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Product,
            this.Size1,
            this.Price,
            this.SizeID});
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(463, 132);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(308, 249);
            this.ListView.TabIndex = 19;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Product
            // 
            this.Product.Text = "Product";
            // 
            // Size1
            // 
            this.Size1.Text = "Size1";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // SizeID
            // 
            this.SizeID.Text = "SizeID";
            this.SizeID.Width = 0;
            // 
            // btnConFirmOrder
            // 
            this.btnConFirmOrder.Location = new System.Drawing.Point(551, 445);
            this.btnConFirmOrder.Name = "btnConFirmOrder";
            this.btnConFirmOrder.Size = new System.Drawing.Size(97, 23);
            this.btnConFirmOrder.TabIndex = 20;
            this.btnConFirmOrder.Text = "ConFirm Order";
            this.btnConFirmOrder.UseVisualStyleBackColor = true;
            this.btnConFirmOrder.Click += new System.EventHandler(this.btnConFirmOrder_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 480);
            this.Controls.Add(this.btnConFirmOrder);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.lblMobileno1);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMobileno);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRrmoveFromCart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbbxProduct);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grdOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblType);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdOrder;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.ComboBox cmbbxProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRrmoveFromCart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMobileno;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblMobileno1;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Size1;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader SizeID;
        private System.Windows.Forms.Button btnConFirmOrder;
    }
}