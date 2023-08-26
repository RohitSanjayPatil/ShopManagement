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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form2 obj = new Form2();
            obj.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmType obj = new FrmType();
            obj.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin obj = new FrmLogin();
            obj.Show();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProdut objProduct = new FrmProdut();
            objProduct.Show();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSize objSize = new FrmSize();
            objSize.Show();
            
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registeretionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order objOrder = new Order();
            objOrder.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
