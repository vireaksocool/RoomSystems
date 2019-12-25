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

namespace RoomSystems.Login
{
    public partial class frmLogin : Form
    {

        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;
        SqlDataAdapter sdap;
        DataTable dt;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) || (string.IsNullOrWhiteSpace(txtpassword.Text)))
            {
                MessageBox.Show("Please Input either \"UserName\" or \"Password\"");
                return;
            }

            try
            {
                string sql = $@"SELECT * FROM 
                               Users WHERE username = @usern
                               AND password = @passw";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usern", txtusername.Text.Trim());
                cmd.Parameters.AddWithValue("@passw", txtpassword.Text.Trim());
                sdap = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdap.Fill(dt);            
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Login Successfully");
                    MainFrm.frmMainF fmain = new MainFrm.frmMainF();
                    this.Hide();
                    fmain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please check your UserName Or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
