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

namespace RoomSystems.BookingRoom
{
    public partial class frmBookingRoom : Form
    {
        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;
        DataTable dt = new DataTable();       
        public frmBookingRoom()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string sql = $@"SELECT​​ rr.id as roombid, r.id as roomid, c.id as customerid, r.name as roomname, c.name as customername, 
                            c.phone, rr.startdate, rr.expiredate, rr.moneybooking, r.status
                             FROM Rooms r
                              INNER JOIN RoomBooking rr ON rr.roomid = r.id
                               INNER JOIN customer c ON rr.customerid = c.id
                                WHERE r.status = 'Booking'";
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
                
                ////cmdCate.Items.Add(dr["Name"].ToString());
                //frm.lblname.Text = dr["name"].ToString();
                //frm.lblgender.Text = dr["gender"].ToString();
                //frm.lblage.Text = dr["age"].ToString();
                ////
                //byte[] raw = (byte[])dr["image"];
                //System.IO.MemoryStream memory = new System.IO.MemoryStream(raw);
                ////picturebox.Image = Class.DO.ToImage(raw[]);
                //frm.pictureBox1.Image = Image.FromStream(memory);
                //frm.lblnation.Text = dr["nationality"].ToString();
                //frm.lblregion.Text = dr["region"].ToString();
                //frm.lblidcad.Text = dr["idcardnumber"].ToString();
                //frm.lblphone.Text = dr["phone"].ToString();
                //frm.lbladdress.Text = dr["address"].ToString();
                //frm.lblpassport.Text = dr["passportnumber"].ToString();
                //frm.btnleave.Text = "ត្រឡប់";
                //this.Hide();
                //frm.ShowDialog();
                //this.Close();
            }
        }
        void updateroom(string id)
        {
            string status = "Available";
            string sql = $@"UPDATE Rooms SET status = @status WHERE id = @id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);
            int update = cmd.ExecuteNonQuery();
        }
        private void frmBookingRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                contextMenuStrip1.Tag = dataGridView1.Rows[e.RowIndex];
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void លមអតToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            viewdatacust(row.Cells[2].Value.ToString());
            tabControl1.SelectedIndex = 1;
        }

        private void ឈបកកToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            updateroom(row.Cells[1].Value.ToString());
            LoadData();
            MessageBox.Show("បន្ទប់ឈប់ជួល");
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                contextMenuStrip1.Tag = dataGridView1.Rows[e.RowIndex];
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
