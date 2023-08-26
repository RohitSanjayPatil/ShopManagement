namespace ShopManagement
{
    partial class FrmSize
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
            this.lblSize = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblsize1 = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.cmbbxProductName = new System.Windows.Forms.ComboBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtRealPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(352, 23);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(158, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(158, 132);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name";
            // 
            // lblsize1
            // 
            this.lblsize1.AutoSize = true;
            this.lblsize1.Location = new System.Drawing.Point(158, 198);
            this.lblsize1.Name = "lblsize1";
            this.lblsize1.Size = new System.Drawing.Size(25, 13);
            this.lblsize1.TabIndex = 3;
            this.lblsize1.Text = "size";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Location = new System.Drawing.Point(158, 261);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(31, 13);
            this.lblMRP.TabIndex = 4;
            this.lblMRP.Text = "MRP";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(158, 340);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Real Price";
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(388, 65);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(121, 21);
            this.cmbbxType.TabIndex = 6;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbbxProductName
            // 
            this.cmbbxProductName.FormattingEnabled = true;
            this.cmbbxProductName.Location = new System.Drawing.Point(388, 124);
            this.cmbbxProductName.Name = "cmbbxProductName";
            this.cmbbxProductName.Size = new System.Drawing.Size(121, 21);
            this.cmbbxProductName.TabIndex = 7;
            this.cmbbxProductName.SelectedIndexChanged += new System.EventHandler(this.cmbbxProductName_SelectedIndexChanged);
            // 
            // txtMRP
            // 
            this.txtMRP.Location = new System.Drawing.Point(388, 255);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(121, 20);
            this.txtMRP.TabIndex = 8;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(388, 191);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(121, 20);
            this.txtsize.TabIndex = 9;
            // 
            // txtRealPrice
            // 
            this.txtRealPrice.Location = new System.Drawing.Point(388, 333);
            this.txtRealPrice.Name = "txtRealPrice";
            this.txtRealPrice.Size = new System.Drawing.Size(121, 20);
            this.txtRealPrice.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(434, 393);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 457);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRealPrice);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.txtMRP);
            this.Controls.Add(this.cmbbxProductName);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMRP);
            this.Controls.Add(this.lblsize1);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSize);
            this.Name = "FrmSize";
            this.Text = "FrmSize";
            this.Load += new System.EventHandler(this.FrmSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblsize1;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.ComboBox cmbbxProductName;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txtRealPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}