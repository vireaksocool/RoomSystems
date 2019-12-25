using RoomSystems.Class;
using RoomSystems.Renting;
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

namespace RoomSystems.RemiderRoom
{
    public partial class frmReminderRoom : Form
    {
        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;
        //DataSet dts = new DataSet();
        //DataTable dt = new DataTable();
        public frmReminderRoom()
        {
            InitializeComponent();
        }
        // Function
        void loadData()
        {
            try
            {
                string sql = $@"SELECT rr.id as roombookingid, r.id as roomid, c.id as customerid, 
		                         r.name as roomname, c.name as customername, c.phone,
		                          rr.checkindate, rr.checkoutdate
                                   FROM Rooms r
                                    INNER JOIN rents_room rr ON rr.roomid = r.id
                                     INNER JOIN customer c ON rr.customerid = c.id
                                      WHERE DATEDIFF(day, GETDATE(), checkoutdate) < 4 AND 
                                       DATEDIFF(day, GETDATE(), checkoutdate) > 0;
                            ";

                dataGridView1.Rows.Clear();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DataGridViewRow dgv_row = new DataGridViewRow();
                        dgv_row.CreateCells(dataGridView1);
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dgv_row.Cells[i].Value = reader[i];
                        }
                        dataGridView1.Rows.Add(dgv_row);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void UpdapteData(string id)
        {
            string status = "Available";
            string sql = $@"UPDATE Rooms SET status = @status WHERE id = @id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("បន្ទប់ឈប់ជួល");
        }
        //DataViews view = new DataViews();
        //DataView view = new DataView();
       
        //void loadroom(string roomid, string custid)
        //{
           
            
        //    //roomview
        //    string sql = "SELECT id, name FROM Rooms WHERE id = @id";
        //    cmd = new SqlCommand(sql, conn);
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.AddWithValue("@id", roomid);
        //    cmd.ExecuteNonQuery();
        //    SqlDataAdapter dta = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    dta.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
                
        //        ComboboxItem item = new ComboboxItem();
        //        item.key = dr["id"].ToString();
        //        item.value = dr["name"].ToString();
        //        custname = item.value;
        //        //cmbroom.Items.Add(item);
        //    }
        //    //customer
        //    string sqlr = "SELECT id,name FROM customer WHERE id = @id";
        //    cmd = new SqlCommand(sqlr, conn);
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.AddWithValue("@id", custid);
        //    cmd.ExecuteNonQuery();
        //    SqlDataAdapter dta1 = new SqlDataAdapter(cmd);
        //    DataTable dt1 = new DataTable();
        //    dta1.Fill(dt1);
        //    foreach (DataRow dr in dt1.Rows)
        //    {
        //        //Class.DataViews view = new Class.DataViews();
        //        ComboboxItem item = new ComboboxItem();
        //        item.key = dr["id"].ToString();
        //        item.value = dr["name"].ToString();
        //        room = item.value;
                
        //        //cmbroom.Items.Add(item);
        //    }
           

      //  }
        private Form activeForm = null;
        public void openChildForm(Form chlidForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = chlidForm;
            chlidForm.TopLevel = false;
            chlidForm.FormBorderStyle = FormBorderStyle.None;
            chlidForm.Dock = DockStyle.Fill;
            panelcnrenting.Controls.Add(chlidForm);
            panelcnrenting.Tag = chlidForm;
            chlidForm.BringToFront();
            chlidForm.Show();
        }
        private void frmReminderRoom_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                contextMenuStrip1.Tag = dataGridView1.Rows[e.RowIndex];
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void បនតកជលToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            //loadroom(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
            DataViews data = new DataViews();
            string room =  row.Cells[1].Value.ToString();
            string custname = row.Cells[2].Value.ToString();
            //row.Cells[1].Value.ToString();
            //data.customerid = row.Cells[2].Value.ToString();
            // openChildForm(new CNRenting());
            openChildForm(new CNRenting(
               new DataViews(
                   room,
                   custname
                   )));
            tabControl1.SelectedIndex = 1;
        }

        private void ឈបជលToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            UpdapteData(row.Cells[1].Value.ToString());
        }
    }
}
