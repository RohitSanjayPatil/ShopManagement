using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string type =  cmbbxType.Text.ToString();

            string Name;
            string Email;                         // label declare
            string Mobileno;
            string UserID2;




            ClsUser Login1 = new ClsUser(txtUserName.Text,txtPassword.Text,type);
            SqlDataReader dr;
            dr = Login1.Login();
            if (dr.Read())
            {

                
                type = dr["Type"].ToString();
                Name = txtUserName.Text;
                txtUserName.Text= dr["Name"].ToString();
                txtPassword.Text = dr["Password"].ToString();
                UserID2= dr ["UserID"].ToString();            //Add for conFirm order one line
                Email = dr["Email"].ToString();
                Mobileno = dr["Mobile no."].ToString();
                MessageBox.Show("Login Successfully");
               if (dr.HasRows == true)
               {
                    if (type == "Admin")

                    {
                        Admin_login login =new Admin_login();
                        login.Show();

                    }
                    else if (type == "Customer")
                    {
                        Order obj = new Order(Name, Email, Mobileno, Convert.ToInt32(UserID2)); //up
                        obj.Show();

                    }
               }

                

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            dr.Close();





        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            cmbbxType.Items.Clear();
        }
    }
}
