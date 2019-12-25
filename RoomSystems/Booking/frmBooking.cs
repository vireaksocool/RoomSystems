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

namespace RoomSystems.Booking
{
    public partial class frmBooking : Form
    {
        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;       
        DataTable dt = new DataTable();
        string values;      
        string bookingid;
        public frmBooking()
        {
            InitializeComponent();
        }
        // function
        void loaddataintod()
        {
            //string sql = $@"SELECT rr.id as roombid, r.id as roomid, c.id as customerid, r.name as roomname, c.name as customername, 
            //                c.phone, rr.startdate, rr.expiredate, rr.moneybooking, r.status
            //                 FROM Rooms r
            //                  INNER JOIN RoomBooking rr ON rr.roomid = r.id
            //                   INNER JOIN customer c ON rr.customerid = c.id
            //                    WHERE r.status = 'Booking'";
            //dataGridView1.Rows.Clear();
            //cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.Clear();
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        DataGridViewRow dgv_row = new DataGridViewRow();
            //        dgv_row.CreateCells(dataGridView1);
            //        for (int i = 0; i < reader.FieldCount; i++)
            //        {
            //            dgv_row.Cells[i].Value = reader[i];
            //        }
            //        dataGridView1.Rows.Add(dgv_row);
            //    }
            //}
        }
        void loaddata()
        {
            string sqlr = "SELECT id, name FROM Rooms WHERE status = 'Available';";
            cmbroom.Items.Clear();
            cmd = new SqlCommand(sqlr, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter dta1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.key = dr["id"].ToString();
                item.value = dr["name"].ToString();
                cmbroom.Items.Add(item);
            }
            // load into cmbcustomer
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
        // load data into cmb when data is update       
        void updatedata()
        {
            string sql = $@"UPDATE RoomBooking SET roomid = @rid, customerid = @cusid, startdate = @sd,
                             expiredate = @ed, moneybooking = @mb
                              WHERE id = @id";
            cmd = new SqlCommand(sql,conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", bookingid);
            cmd.Parameters.AddWithValue("@rid", ((ComboboxItem)this.cmbroom.Items[this.cmbroom.SelectedIndex]).key);
            cmd.Parameters.AddWithValue("@cusid", ((ComboboxItem)this.cmbcustm.Items[this.cmbcustm.SelectedIndex]).key);
            cmd.Parameters.AddWithValue("@sd", datestart.Value);
            cmd.Parameters.AddWithValue("@ed", dateexpired.Value);
            cmd.Parameters.AddWithValue("@mb", txtmbooking.Text.Trim());
            int affected_row = cmd.ExecuteNonQuery();
            if (affected_row > 0)
            {
                Class.QuerySql.BookingRoom(((ComboboxItem)this.cmbroom.Items[cmbroom.SelectedIndex]).key);
                loaddataintod();
                MessageBox.Show("បញ្ចូលទិន្នន័យត្រូវបានកែប្រែ");
            }
        }
        private void frmBooking_Load(object sender, EventArgs e)
        {
            //loaddataintod();
              loaddata();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {           
            string sql = $@"INSERT INTO RoomBooking(roomid, customerid, startdate, expiredate, moneybooking)
                             VALUES(
                                    @rid,
                                    @cusid,
                                    @sdate,
                                    @edate,
                                    @mb                                      
                                    )";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@rid", ((ComboboxItem)this.cmbroom.Items[this.cmbroom.SelectedIndex]).key);
            cmd.Parameters.AddWithValue("@cusid", ((ComboboxItem)this.cmbcustm.Items[this.cmbcustm.SelectedIndex]).key);
            cmd.Parameters.AddWithValue("@sdate", datestart.Value);
            cmd.Parameters.AddWithValue("@edate", dateexpired.Value);
            cmd.Parameters.AddWithValue("@mb", txtmbooking.Text.Trim());
            int affected_row = cmd.ExecuteNonQuery();
            if (affected_row > 0)
            {
                Class.QuerySql.BookingRoom(((ComboboxItem)this.cmbroom.Items[cmbroom.SelectedIndex]).key);
                //loaddataintod();
                MessageBox.Show("បញ្ចូលទិន្នន័យបានជោជ័យ");
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {         
        }

        private void កបរទនននយToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            //bookingid = row.Cells[0].Value.ToString();
            ////cmbroom.DropDownStyle = ComboBoxStyle.DropDown;
            //cmbroom.Text = row.Cells[3].Value.ToString();
            ////cmbcustm.DropDownStyle = ComboBoxStyle.DropDown;
            //cmbcustm.Text = row.Cells[4].Value.ToString();
            ////loadcmbroom(row.Cells[1].Value.ToString());
            ////loadcmbcust(row.Cells[2].Value.ToString());
            ////custid = row.Cells[2].Value.ToString();         
            //datestart.Value = DateTime.Parse(row.Cells[6].Value.ToString());
            //dateexpired.Value = DateTime.Parse(row.Cells[7].Value.ToString());
            //txtmbooking.Text = row.Cells[8].Value.ToString();
            //btnsave.Click -= btnsave_Click;
            //btnsave.Text = "កែប្រែ";
            //btnsave.Click += btnupdate_Click;         

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            updatedata();
        }
    }
}
