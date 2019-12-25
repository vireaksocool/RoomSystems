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

namespace RoomSystems.Renting
{
    public partial class frmRentingRooms : Form
    {
        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;
        SqlCommand cmd1;
        DataTable dt = new DataTable();
        public frmRentingRooms()
        {
            InitializeComponent();
        }
        // Function
        void LoadData()
        {
            //get data into mcmdroom
            string sqlr = "SELECT id, name FROM Rooms WHERE status = 'Available';";
            cmbroom.Items.Clear();
            cmd1 = new SqlCommand(sqlr, conn);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter dta1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.key = dr["id"].ToString();
                item.value = dr["name"].ToString();
                cmbroom.Items.Add(item);
            }

            // get data into mcmdcust
            string sql = "SELECT id,name FROM customer;";
            cmbcustm.Items.Clear();

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.key = dr["id"].ToString();
                item.value = dr["name"].ToString();
                cmbcustm.Items.Add(item);

            }
        }
        public void loadDataRoom()
        {

        }
        bool CheckEmpty()
        {
            bool result = true;
            if (cmbroom.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select to choose Room");                
            }
            else if (cmbcustm.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select to choose your customer");
            }
            else if (txtmbooking.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Money for Booking");
            }
            else if (txtroomprice.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Money for Renting Room");
            }
            else if (txtoldelec.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input a Old Electrict for this Room");
            }
            else if (txtoldwater.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input a Old Water for this Room");
            }
            else if (!dtpcheckin.Checked)
            {
                MessageBox.Show("Please Check day for stay");
            }
            else if (!dtpcheckout.Checked)
            {
                MessageBox.Show("Please check day for leave ");
            }
            else if (rtbdesc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Something desc for this Room");
            }
           else
            {
                return false;
            }
            return result;
        }
        void ClearText()
        {
            txtmbooking.Clear();
            txtoldelec.Clear();
            txtoldwater.Clear();
            txtroomprice.Clear();
            cmbcustm.SelectedIndex = -1;
            cmbroom.SelectedIndex = -1;
            rtbdesc.Clear();
        }
        private void frmRentingRooms_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                try
                {
                    string sql = $@"INSERT INTO rents_room(customerid, roomid, checkindate, checkoutdate, prepaid,
                              price,startwater, startelectrict, descr) 
                                                                        VALUES(
                                                                        @cuid,
                                                                        @rmid,
                                                                        @chinid,
                                                                        @choutid,
                                                                        @prepaid,
                                                                        @pr,
                                                                        @sw,
                                                                        @se,
                                                                        @de
                                                                    )
                                SELECT SCOPE_IDENTITY();
                               ";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cuid", ((ComboboxItem)this.cmbcustm.Items[this.cmbcustm.SelectedIndex]).key);
                    cmd.Parameters.AddWithValue("@rmid", ((ComboboxItem)this.cmbroom.Items[this.cmbroom.SelectedIndex]).key);
                    cmd.Parameters.AddWithValue("@chinid", dtpcheckin.Value);
                    cmd.Parameters.AddWithValue("@choutid", dtpcheckout.Value);
                    cmd.Parameters.AddWithValue("@prepaid", txtmbooking.Text.Trim());
                    cmd.Parameters.AddWithValue("@pr", txtroomprice.Text.Trim());
                    cmd.Parameters.AddWithValue("@sw", txtoldwater.Text.Trim());
                    cmd.Parameters.AddWithValue("@se", txtoldelec.Text.Trim());
                    cmd.Parameters.AddWithValue("@de", rtbdesc.Text.Trim());
                    SqlDataReader reader= cmd.ExecuteReader();
                    // MessageBox.Show(affected_row.ToString());
                    reader.Read();
                    string id = reader[0].ToString();
                    MessageBox.Show(id);
                    //if (affected_row == 1)
                    //{
                    //    cmd = new SqlCommand("SELECT * FROM rents_room WHERE id = SCOPE_IDENTITY();", conn);
                    //    object v = cmd.ExecuteNonQuery();
                    //    MessageBox.Show(v.ToString());
                    //}
                    // Class.QuerySql.Checkinroom(((ComboboxItem)this.cmbroom.Items[cmbroom.SelectedIndex]).key);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            if (btnleave.Text == "លុប")
            {
                ClearText();
                btnleave.Text = "ចាកចេញ";
            }
            else
            {
                
            }
        }

        private void cmbroom_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb != null)
            {
                btnleave.Text = "លុប";
            }
        }
    }
}
