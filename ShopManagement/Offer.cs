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
    public partial class Offer : Form
    {
        public int OrderID; public string selepri;    //Offer form
        public Offer()
        {
            InitializeComponent();
        }

        public Offer(string price)          
        { selepri = price; }

        public Offer(string price, int orderid)            // offer form
        {
            InitializeComponent();
            label6.Text = price;
            OrderID = Convert.ToInt32(orderid); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClaculateNewPrice_Click(object sender, EventArgs e)
        {
            int originalPrice = 0;
            double discount, discountgiven, seleprice = 0;
            originalPrice = int.Parse(label6.Text);
            discount = int.Parse(txtDiscountinPercentage.Text);
            discountgiven = originalPrice * (discount / 100);
            seleprice = originalPrice - discountgiven;
            txtNewPrice.Text = seleprice.ToString();
            
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(txtNewPrice.Text);
            decimal Discount = Convert.ToDecimal(txtDiscountinPercentage.Text);
            ClsUser p = new ClsUser(OrderID, Discount);
            p.UpdateOrder();
            MessageBox.Show("Updated Successfully");

        }
    }
}
