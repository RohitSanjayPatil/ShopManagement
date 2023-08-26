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
    public partial class FrmProdut : Form
    {
        public FrmProdut()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void FrmProdut_Load(object sender, EventArgs e) 
        {
            ClsUser objType = new ClsUser();
            DataTable dt = new DataTable();
            dt = objType.GetType();
            cmbbxType.ValueMember = "TypeID";
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.DataSource = dt;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeID =Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            ClsUser objType = new ClsUser(TypeID,txtProductName.Text);
            objType.SaveProduct();
            MessageBox.Show("Product Save Successfully");
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            cmbbxType.Items.Clear();
        }
    }
}
