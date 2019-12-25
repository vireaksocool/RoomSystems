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

namespace RoomSystems.Rooms
{
    public partial class frmRooms : Form
    {
        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;
        DataSet dts = new DataSet();
        DataTable dt = new DataTable();
        public frmRooms()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            dts.Tables.Clear();
            dt.Rows.Clear();
            //string sql = $@"SELECT id, name, width, length, descr,
            //                 CASE available
            //                  WHEN 1 THEN 'available'
            //                   WHEN 0 THEN 'not available'
            //                    END AS available FROM Rooms";
            string sql = $@"SELECT * FROM Rooms";
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

            // load data into datagridview
            //dts.Tables.Add(dt);
            //cmd = new SqlCommand(sql, conn);
            ////conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //dt.Clear();
            //dt.Load(reader);
            //reader.Close();
            //dataGridView1.DataSource = dt;
        }
        void ClearText()
        {
            txtlenght.Clear();
            txtroom.Clear();
            txtwidth.Clear();
            rtbdesc.Clear();
        }
        bool CheckEmpty()
        {
            bool result = true;
            if (txtroom.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input room");
            }
            else if (txtlenght.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Lenght");
            }
            else if (txtwidth.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Width");
            }
            else if (rtbdesc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Desc");
            }
            else
            {
                return false;
            }
            return result;
            
        }
        private void frmRooms_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        private void CheckText(object sender, EventArgs e)
        {
            btnleave.Text = "លុប";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sta = "Available";
            btnleave.Text = "លុប";
            if (!CheckEmpty())
            {
                try
                {
                    string sql = $@"INSERT INTO Rooms(name, width, length, descr, status)
                             ​​    VALUES(
                                    @na,
                                    @wth,
                                    @lth,
                                    @des,
                                    @sta
                                    )";
                    cmd = new SqlCommand(sql, conn);
                    //conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@na", txtroom.Text.Trim());
                    cmd.Parameters.AddWithValue("@wth", txtwidth.Text.Trim());
                    cmd.Parameters.AddWithValue("@lth", txtlenght.Text.Trim());
                    cmd.Parameters.AddWithValue("@des", rtbdesc.Text.Trim());
                    cmd.Parameters.AddWithValue("@sta", sta.ToString());
                    int affected_row = cmd.ExecuteNonQuery();
                    MessageBox.Show("កាបញ្ចូលទិន្នន័យបានជោគជ័យ");
                    if (affected_row > 0)
                    {
                        //metroGrid.Rows.Clear();
                        loaddata();
                    }
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
            else if(btnleave.Text == "ចាកចេញ")
            {
                
            }
        }

        private void btnsave_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void rtbdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtwidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlenght_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtroom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtroom_Click(object sender, EventArgs e)
        {
            
        }

        private void txtroom_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtroom_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        private void txtroom_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                btnleave.Text = "លុប";
            }
        }  
    }
}
