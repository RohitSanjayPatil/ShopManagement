namespace ShopManagement
{
    partial class Admin_login
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdAdmin = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblsearchbyName = new System.Windows.Forms.Label();
            this.lblsearchbyProduct = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchbyName = new System.Windows.Forms.TextBox();
            this.txtsearchbyProduct = new System.Windows.Forms.TextBox();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductToolStripMenuItem,
            this.orderProductToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allProductToolStripMenuItem
            // 
            this.allProductToolStripMenuItem.Name = "allProductToolStripMenuItem";
            this.allProductToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.allProductToolStripMenuItem.Text = "All Product";
            this.allProductToolStripMenuItem.Click += new System.EventHandler(this.allProductToolStripMenuItem_Click);
            // 
            // orderProductToolStripMenuItem
            // 
            this.orderProductToolStripMenuItem.Name = "orderProductToolStripMenuItem";
            this.orderProductToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.orderProductToolStripMenuItem.Text = "Order Product";
            this.orderProductToolStripMenuItem.Click += new System.EventHandler(this.orderProductToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // grdAdmin
            // 
            this.grdAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Discount});
            this.grdAdmin.Location = new System.Drawing.Point(214, 43);
            this.grdAdmin.Name = "grdAdmin";
            this.grdAdmin.Size = new System.Drawing.Size(501, 289);
            this.grdAdmin.TabIndex = 1;
            this.grdAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAdmin_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Text = "Discount";
            this.Discount.UseColumnTextForButtonValue = true;
            // 
            // lblsearchbyName
            // 
            this.lblsearchbyName.AutoSize = true;
            this.lblsearchbyName.Location = new System.Drawing.Point(327, 358);
            this.lblsearchbyName.Name = "lblsearchbyName";
            this.lblsearchbyName.Size = new System.Drawing.Size(86, 13);
            this.lblsearchbyName.TabIndex = 2;
            this.lblsearchbyName.Text = "Search by Name";
            // 
            // lblsearchbyProduct
            // 
            this.lblsearchbyProduct.AutoSize = true;
            this.lblsearchbyProduct.Location = new System.Drawing.Point(327, 413);
            this.lblsearchbyProduct.Name = "lblsearchbyProduct";
            this.lblsearchbyProduct.Size = new System.Drawing.Size(95, 13);
            this.lblsearchbyProduct.TabIndex = 3;
            this.lblsearchbyProduct.Text = "Search by Product";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(405, 448);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchbyName
            // 
            this.txtSearchbyName.Location = new System.Drawing.Point(447, 358);
            this.txtSearchbyName.Name = "txtSearchbyName";
            this.txtSearchbyName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchbyName.TabIndex = 5;
            // 
            // txtsearchbyProduct
            // 
            this.txtsearchbyProduct.Location = new System.Drawing.Point(447, 406);
            this.txtsearchbyProduct.Name = "txtsearchbyProduct";
            this.txtsearchbyProduct.Size = new System.Drawing.Size(100, 20);
            this.txtsearchbyProduct.TabIndex = 6;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 483);
            this.Controls.Add(this.txtsearchbyProduct);
            this.Controls.Add(this.txtSearchbyName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblsearchbyProduct);
            this.Controls.Add(this.lblsearchbyName);
            this.Controls.Add(this.grdAdmin);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_login";
            this.Text = "Admin_login";
            this.Load += new System.EventHandler(this.Admin_login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdAdmin;
        private System.Windows.Forms.Label lblsearchbyName;
        private System.Windows.Forms.Label lblsearchbyProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchbyName;
        private System.Windows.Forms.TextBox txtsearchbyProduct;
        private System.Windows.Forms.ToolStripMenuItem allProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Discount;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}