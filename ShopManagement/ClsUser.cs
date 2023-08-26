using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Data.SqlTypes;
using System.Net.Configuration;
using System.Windows.Forms;

namespace ShopManagement
{
    internal class ClsUser
    {
        //Sqlconnection
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ENQN31T;Initial Catalog=ShopManagement;Integrated Security=True");

        //Access Modifier properties
          
        //radio button regUser
        public string  size { get; set; }
        string ButtonName = string.Empty;


        //Save user

        public string RType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string State { get; set; }
        public int password { get; set; }
       

        //SaveType
        public string TypeName { get; set; }
        //Save Product
        public string ProductName { get; set; }

        //Save Size
        public int ProductId { get; set; }
        public int TypeID { get; set; }
        public string Size { get; set; }
        public int MRP { get; set; }
        public int RealPrice { get; set; }
     //   public string Product { get; set; }


        //Login Modifire
        public string UserName { get; set; }
        public string Password { get; set; }

        //ConFirm Order

        public string Orderdate { get; set; }
        public string Status { get; set; }
        public int UserID { get; set; }
        public int SizeID { get; set; }

        //Offer Form

        public decimal discountinPercentage { get; set; }






        //constructor SaveUser
        public ClsUser(String type, string uname, string mail, string gender ,string number, string sState, int Pass)
        {
            RType = type;
            Name = uname;
            Email = mail;
            Gender = gender;
            MobileNo = number;
            State = sState;
            password = Pass;


        }
        //SaveUser function

        public void SaveUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveUser");
            cmd.Parameters.AddWithValue("@UType", RType);
            cmd.Parameters.AddWithValue("@UUName", Name);
            cmd.Parameters.AddWithValue("@UMail", Email);          
            cmd.Parameters.AddWithValue("@UMobile", MobileNo);
            cmd.Parameters.AddWithValue("@UPass", password);
            cmd.Parameters.AddWithValue("@UState", State);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //constructor SaveType
        public ClsUser(string Ttype)
        {
            TypeName = Ttype;
        }

        //SaveType Function
        public void SaveType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveType");
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //Constructor SaveProduct

        public ClsUser(int tID, string Pname)
        {

            ProductName = Pname;
            TypeID = tID;

        }



        //SaveProduct Function
        public void SaveProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeID);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        // Product Get value
        public DataTable GetType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        //constructor SaveSize

        public ClsUser(int tid, int pid, string size, int mrp, int Rprice)
        {
            TypeID = tid;
            ProductId = pid;
            Size = size;
            MRP = mrp;
            RealPrice = Rprice;
        }

        //Default constructor
        public ClsUser()
        {

        }
                   //SaveSize Function
        public void SaveSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveSize");
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            cmd.Parameters.AddWithValue("@ProductID", ProductId);
            cmd.Parameters.AddWithValue("@Size", Size);
            cmd.Parameters.AddWithValue("@MRP", MRP);
            cmd.Parameters.AddWithValue("@RealPrice", RealPrice);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GProduct() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeID);
            SqlDataAdapter adpt1 = new SqlDataAdapter();
            adpt1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt1.Fill(dt);
            return dt;                                                      //size get type
            con.Close();
            
        }
       // public ClsUser(int TypeId) {TypeID = TypeId;}

        //public DataTable PType()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("ShopUser2", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "PType");
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    adpt.SelectCommand = cmd;
        //    DataTable data = new DataTable();
        //    adpt.Fill(data);
        //    return data;
        //    con.Close();
        //}

        //Login constructor


        public ClsUser(string userName,string Pass,string type1 )
        {
            UserName= userName;
            Password= Pass;
            TypeName = type1;

        }
                //Login Function
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Login");
            cmd.Parameters.AddWithValue("@UUname", UserName);
            cmd.Parameters.AddWithValue("@UPass", Password);
            cmd.Parameters.AddWithValue("@UType", TypeName);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

                //Order constructor
        public ClsUser(int pid,int tid)
        {
            ProductId = pid;
            TypeID = tid;
           
            
        }
        public DataTable GetOrder()
        
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","GetOrder");
            cmd.Parameters.AddWithValue("@TypeId",TypeID);
            cmd.Parameters.AddWithValue("@ProductId",ProductId);
            cmd.Parameters.AddWithValue("@RealPrice",RealPrice);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        
          //On grd Show Size

        public DataTable GetSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpt = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@Flag", "GetSize");
            cmd.Parameters.AddWithValue("@ProductID", ProductId);
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            adpt.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

             //Price show Order

        public SqlDataReader PriceView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser2",con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Flag", "PriceView");
            cmd.Parameters.AddWithValue("@SizeID", TypeID);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();           
            return dr;               
            con.Close();
        }

       //ConFirm Order Constructor

        public ClsUser(int UserId,int SizeId,string status,string orderDate)
        {
            UserID = UserId;
            SizeID = SizeId;
            Status = status;
            Orderdate = orderDate;

        }

        //ConFirm Order Function
        public void ConFirmOder()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser3", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ConFirmOrder");
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@SizeID", SizeID);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@OrderDate", Orderdate);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public DataTable AllProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser3", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpt = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@Flag", "AllProduct");
            adpt.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable OrderProductName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser3", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "OrderProductName");
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public ClsUser(string name,string product)
        {
            Name = name;
            ProductName = product;
        }

        public DataTable Search()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser3", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Search");
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("ShopUser3", con);
            adpt.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        // offer form constructor

        public ClsUser(int UserID1,decimal discountin)
        {
            TypeID = UserID1;
            discountinPercentage = discountin;           
        }

        public ClsUser(int typeID)
        {
            TypeID = typeID;
        }

        //Offer Form Function
        public void UpdateOrder()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopUser3",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateOrder");
            cmd.Parameters.AddWithValue("OrderID", TypeID);
            cmd.Parameters.AddWithValue("@DiscountinPercentage", discountinPercentage);
            cmd.ExecuteNonQuery();
            con.Close();
        }














    }
}
