using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopManagement
{
    public partial class Form2 : Form
    {
      
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           //cmbbx type(registeruser) 
                      
            cmbbxType.Items.Add("Admin");
            cmbbxType.Items.Add("Customer");

            cmbbxState.Items.Add("Maharastra");
            cmbbxState.Items.Add("Kerela");
            cmbbxState.Items.Add("Karnataka");

           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Gender = null;

            if(rbtMale.Checked==true)
            {
                Gender = "Male";
            }
            if(rbtFemale.Checked==true)
            {
                Gender = "Female";
            }

            
             
            ClsUser objUser = new ClsUser(cmbbxType.Text, txtName.Text, txtEmail.Text, Gender, txtMobileNumber.Text,cmbbxState.Text,Convert.ToInt32(txtPassword.Text));
            objUser.SaveUser();
            MessageBox.Show("Added Successfully");
           
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

          

            
                    

            
        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtMobileNumber.Clear();
            txtPassword.Clear();
            cmbbxType.Items.Clear();
            cmbbxState.Items.Clear();
           
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
           
         

        }
    }
}

