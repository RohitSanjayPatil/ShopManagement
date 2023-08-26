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
    public partial class FrmType : Form
    {
        public FrmType()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClsUser objUser = new ClsUser(txtType.Text);
            objUser.SaveType();
            MessageBox.Show("Type Save");

            
            
        }

        private void FrmType_Load(object sender, EventArgs e)
        { 
        
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtType.Clear();    
        }
    }
}
