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

namespace RoomSystems.Connection
{
    public partial class frmConnection : Form
    {
        SqlConnection conn;
        public frmConnection()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (cmdtype.SelectedIndex != -1)
            {
                if (cmdtype.SelectedIndex == 0)
                {
                    if (txtservername.Text.Trim() == string.Empty)
                    {

                        MessageBox.Show("Please input ServerName");
                        txtservername.Focus();
                    }
                    else if (txtdbname.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please input DBName");
                        txtdbname.Text.Trim();
                    }
                    else
                    {
                        try
                        {
                            sql = "data source=" + txtservername.Text.Trim() + ";initial catalog=" + txtdbname.Text.Trim() + ";Integrated Security=True;MultipleActiveResultSets=true";
                            conn = new SqlConnection(sql);
                            conn.Open();
                            Properties.Settings.Default.ConStr = sql;
                            Properties.Settings.Default.Save();
                            MessageBox.Show("success to conncetion to database");
                            Class.ClassDO.Restart();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }
                if (cmdtype.SelectedIndex == 1)
                {
                    if (txtservername.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Input Server !");
                        txtservername.Focus();
                    }
                    else if (txtdbname.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Input DatabseName");
                        txtdbname.Focus();
                    }
                    else if (txtusername.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Input UserName");
                        txtusername.Focus();
                    }
                    else if (txtpassword.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Input Password");
                        txtpassword.Focus();
                    }
                    else
                    {
                        try
                        {
                            sql = "data source=" + txtservername.Text.Trim() + ";initial catalog=" + txtdbname.Text.Trim() + ";Integrated Security=True;MultipleActiveResultSets=true";
                            conn = new SqlConnection(sql);
                            conn.Open();
                            Properties.Settings.Default.ConStr = sql;
                            Properties.Settings.Default.Save();
                            MessageBox.Show("Connection Success");
                            Class.ClassDO.Restart();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Pick Authentication !");
                cmdtype.Focus();
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtservername.Focus();
            if (cmdtype.SelectedIndex == 0) { gpb.Enabled = false; }
            else { gpb.Enabled = true; }
        }

        private void chbshow_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = chbshow.Checked ? '\0' : '￭';
        }

        private void frmConnection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                SendKeys.Send("{TAB}");
        }
    }
}
