using RoomSystems.Class;
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
using static RoomSystems.Class.ClassDO;
//using RoomSystems.Class;

namespace RoomSystems.Renting
{
    public partial class CNRenting : Form
    {
        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;
        string roomid;
        string customerid;
        public CNRenting(DataViews data)
       
        //public CNRenting()
        {
            InitializeComponent();
            roomid = data.roomid;
            customerid = data.customerid;
        }
        void load()
        {
            //string roomid = data.roomid;
            //string customerid = data.customerid;
            MessageBox.Show($"{roomid}, {customerid}");
            //roomview
            string sql = "SELECT id, name FROM Rooms WHERE id = @id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", roomid);
            cmd.ExecuteNonQuery();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.key = dr["id"].ToString();
                item.value = dr["name"].ToString();
                cmbroom.Items.Add(item);
                //cmbroom.Text = item.ToString();
//                cmbroom.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            //customer
            string sqlr = "SELECT id,name FROM customer WHERE id = @id";
            cmd = new SqlCommand(sqlr, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", customerid);
            cmd.ExecuteNonQuery();
            SqlDataAdapter dta1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.key = dr["id"].ToString();
                item.value = dr["name"].ToString();
                cmbcustm.Items.Add(item);
                //cmbcustm.Text = item.ToString();
 //               cmbcustm.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void CNRenting_Load(object sender, EventArgs e)
        {
            //DataViews data = new DataViews();
            //this.cmbroom.Text = data.roomname;
            //this.cmbcustm.Text = data.customername;
            load();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = $@" INSERT INTO  rents_room(customerid, roomid, checkindate, checkoutdate,
                                                     price, startwater, startelectrict, descr)
                            VALUES ( @cus,
                                     @rid, 
                                     @ind,
                                     @outd,
                                     @p,
                                     @sw,
                                     @se,
                                     @des
                                     )";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cus", ((ComboboxItem)this.cmbroom.Items[this.cmbroom.SelectedIndex]).key);
            cmd.Parameters.AddWithValue("@rid", ((ComboboxItem)this.cmbroom.Items[this.cmbroom.SelectedIndex]).key);
            cmd.Parameters.AddWithValue("@ind", dtpcheckin.Value);
            cmd.Parameters.AddWithValue("@outd", dtpcheckout.Value);
            cmd.Parameters.AddWithValue("@p", txtroomprice.Text.Trim());
            cmd.Parameters.AddWithValue("@sw", txtwaternew.Text.Trim());
            cmd.Parameters.AddWithValue("@se", txtelectricnew.Text.Trim());
            cmd.Parameters.AddWithValue("@des", rtbdesc.Text.Trim());
            int affected_row = cmd.ExecuteNonQuery();
            if (affected_row > 0)
            {
                MessageBox.Show($"បន្ទប់ត្រូវបានជួលបន្តដោយ {cmbcustm.Text}");
            }
        }
    }
}
