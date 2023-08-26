using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class FrmSize : Form
    {
        public FrmSize()
        {
            InitializeComponent();
        }

        private void FrmSize_Load(object sender, EventArgs e)
        {
            
            ClsUser objType = new ClsUser();
            DataTable dt = new DataTable();
            dt = objType.GetType();
            cmbbxType.ValueMember = "TypeID";
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.DataSource = dt;


           

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            ClsUser objType = new ClsUser(TypeID);
            DataTable dt1 = new DataTable();
            dt1 = objType.GProduct();
            cmbbxProductName.ValueMember = "TypeID";
            cmbbxProductName.DisplayMember = "ProductName";
            cmbbxProductName.DataSource= dt1;

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int ProductID = Convert.ToInt32(cmbbxProductName.SelectedValue.ToString());
            ClsUser objSize = new ClsUser(TypeID, ProductID, txtsize.Text, Convert.ToInt32(txtMRP.Text), Convert.ToInt32(txtRealPrice.Text));
            objSize.SaveSize();
            MessageBox.Show("Save Size");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsize.Clear();
            txtMRP.Clear();
            txtRealPrice.Clear();
            cmbbxType.Items.Clear();
            cmbbxProductName.Items.Clear();
        }

        private void cmbbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
