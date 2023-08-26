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
    public partial class Admin_login : Form
    {
        public string Price { get; set; }
        public int orderid { get; set; }    
        public Admin_login()
        {
            InitializeComponent();
        }

        private void orderProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsUser p = new ClsUser();
            DataTable dt = new DataTable();
            dt = p.OrderProductName();
            grdAdmin.DataSource = dt;
            grdAdmin.Show();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void allProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsUser p1 = new ClsUser();
            DataTable dt = new DataTable();
            dt = p1.AllProduct();
            grdAdmin.DataSource = dt;
            grdAdmin.Show();
         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Name = txtSearchbyName.Text;
            string ProductName = txtsearchbyProduct.Text;
            ClsUser p = new ClsUser(Name, ProductName);
            DataTable dt = new DataTable();
            dt = p.Search();
            grdAdmin.DataSource = dt;
            grdAdmin.Show();



        }

        private void grdAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectdrow = grdAdmin.Rows[index];
            Price = selectdrow.Cells[9].Value.ToString();
            orderid = Convert.ToInt32(selectdrow.Cells[10].Value.ToString());
            Offer offer = new Offer(Convert.ToString(Price), orderid);
            offer.Show();
        }
    }
}
