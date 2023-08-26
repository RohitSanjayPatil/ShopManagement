using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class Order : Form
    {

        public string size;
        public int UserId;              //Conform order 2 lines
        public string SizeID1;
        public Order()
        {
            InitializeComponent();
        }

        public Order(string Name, string Email, string Mobileno,int userid)  //Order label
        {
            InitializeComponent();
            lblName1.Text = Name;
            lblEmail1.Text = Email;
            lblMobileno1.Text = Mobileno;
            UserId = userid;                 //conform order line

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int ProductId = Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            ClsUser Product = new ClsUser(TypeId, ProductId);
            Product.SaveSize();
            MessageBox.Show("Size Saved");
        }

        private void cmbbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int ProductID = Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            ClsUser objsize = new ClsUser(ProductID, TypeID);
            DataTable dt = new DataTable();
            dt = objsize.GetSize();
            grdOrder.DataSource = dt;
            grdOrder.Show();


        }


        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            ClsUser objSize = new ClsUser(TypeId);
            DataTable dt = new DataTable();
            dt = objSize.GProduct();
            cmbbxProduct.ValueMember = "ProductID";
            cmbbxProduct.DisplayMember = "ProductName";
            cmbbxProduct.DataSource = dt;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            ClsUser objType = new ClsUser();
            DataTable dt = new DataTable();
            dt = objType.GetType();
            cmbbxType.ValueMember = "TypeID";
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.DataSource = dt;




        }


        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Items.Clear();
            cmbbxProduct.Items.Clear();
        }

             //price Show

        private void grdOrder_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            int SizeID = Convert.ToInt32(grdOrder.Rows[e.RowIndex].Cells[1].Value);
            ClsUser Price = new ClsUser(SizeID);
            SqlDataReader dr;
            dr = Price.PriceView();
            while (dr.Read())
            {
                txtPrice.Text = dr["MRP"].ToString();
            }
            size = this.grdOrder.CurrentRow.Cells[0].Value.ToString();
            SizeID1= this.grdOrder.CurrentRow.Cells[1].Value.ToString();               //conform order line
        }

        private void button1_Click(object sender, EventArgs e)             //Add to Cart Btn
        {
            String ProductType, Product, Size, Price;
            string SizeID = this.grdOrder.CurrentRow.Cells[0].Value.ToString();
            string Size12 = this.grdOrder.CurrentRow.Cells[0].Value.ToString();
            ProductType = cmbbxType.Text.ToString();
            Product = cmbbxProduct.Text.ToString();
            Size = SizeID;
            Price = txtPrice.Text.ToString();
            ListViewItem List = new ListViewItem();
            List.Text = ProductType;
            List.SubItems.Add(Product);
            List.SubItems.Add(Size);
            List.SubItems.Add(Price);
            List.SubItems.Add(SizeID1);

            ListView.Items.Add(List);

        }

        private void button2_Click(object sender, EventArgs e)  //Remove btn
        {
            for(int i = ListView.Items.Count - 1; i>=0;i--)
            {

                if (ListView.Items[i].Selected)
                {
                    ListView.Items[i].Remove();
                }
            }
          


        }

        private void lblMobileno_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)   //Total listview
        {
            decimal sum = 0;
            foreach (ListViewItem item in ListView.Items)
            {
                sum += decimal.Parse(item.SubItems[3].Text);
            }
            txtTotal.Text = sum.ToString();

        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConFirmOrder_Click(object sender, EventArgs e)
        {
            for (int i=0; i<ListView.Items.Count; i++)
            {
                string Status12 = "ConFirm";
                DateTime orderDate = DateTime.Now;
                int SizeID1 = Convert.ToInt32(ListView.Items[i].SubItems[4].Text);
                ClsUser OrderConfirmed = new ClsUser(UserId,SizeID1,Status12,Convert.ToString(orderDate));
                OrderConfirmed.ConFirmOder();
            }
               MessageBox.Show("Order ConFirmed");

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
