using RoomSystems.Class;
using RoomSystems.Register;
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

namespace RoomSystems.RentingRoom
{
    public partial class frmRentingRoom : Form
    {
        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet dts = new DataSet();
        public frmRentingRoom()
        {
            InitializeComponent();
        }
        // Function
        void loaddata()
        {
            string sql = $@"SELECT  rs.id as roomid , c.id as customerid,rs.name AS roomname, c.name AS customername, c.phone, rr.checkindate, rr.checkoutdate, rs.status
                             FROM Rooms rs 
                              INNER JOIN rents_room rr ON rr.roomid = rs.id
                               INNER JOIN customer c ON rr.customerid = c.id
                                where rs.status = 'checkin';";
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
        private Form activeForm = null;
        public void openChildForm(Form chlidForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = chlidForm;
            chlidForm.TopLevel = false;
            chlidForm.FormBorderStyle = FormBorderStyle.None;
            chlidForm.Dock = DockStyle.Fill;
            paneldetail.Controls.Add(chlidForm);
            paneldetail.Tag = chlidForm;
            chlidForm.BringToFront();
            chlidForm.Show();
        }
        void viewdatacust(string idcust)
        {
            string sqls = $@"SELECT name, gender, age, image, nationality,
                              region, idcardnumber, phone, address, passportnumber
                               FROM customer WHERE id = @id;";
            cmd = new SqlCommand(sqls, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", idcust);
            //
            cmd.ExecuteNonQuery();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            //Register.frmview frm = new Register.frmview();
            foreach (DataRow dr in dt.Rows)
            {              
                string name = (dr["name"].ToString() != null) ? (dr["name"].ToString()) : ("null");
                string gender = (dr["gender"].ToString() != null) ? (dr["gender"].ToString()) : ("null");
                string age = (dr["age"].ToString() != null) ? (dr["age"].ToString()) : ("0");
                string nation = (dr["nationality"].ToString() != null) ? (dr["nationality"].ToString()) : ("null");
                string regions = (dr["region"].ToString() != null) ? (dr["region"].ToString()) : ("null");
                string idcard = (dr["idcardnumber"].ToString() != null) ? (dr["idcardnumber"].ToString()) : ("null");
                string phone = (dr["phone"].ToString() != null) ? (dr["phone"].ToString()) : ("null");
                string address = (dr["address"].ToString() != null) ? (dr["address"].ToString()) : ("null");
                string passport = (dr["passportnumber"].ToString() != null) ? (dr["passportnumber"].ToString()) : ("null");
                openChildForm(new frmview(
                new Class.CustomerView(
                    name,
                    gender,
                    int.Parse(age),
                    (byte[])dr["image"],
                    nation,
                    regions,
                    idcard,
                    phone,
                    address,
                    passport
                )));
            }
        }
        private void frmRentingRoom_Load(object sender, EventArgs e)
        {
            loaddata();         
        }

        private void លមអតToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            viewdatacust(row.Cells[1].Value.ToString());
            tabControl1.SelectedIndex = 1;
        }

        private void លបToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            
            UpdapteData(row.Cells[0].Value.ToString());
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick_2(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                contextMenuStrip1.Tag = dataGridView1.Rows[e.RowIndex];
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
