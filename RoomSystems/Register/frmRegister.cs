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

namespace RoomSystems.Register
{
    public partial class frmRegister : Form
    {
        SqlConnection conn = Class.ClassConnection.GetDBConnection();
        SqlCommand cmd;
        DataSet dts = new DataSet();
        DataTable dt = new DataTable();
        string values;
        public frmRegister()
        {
            InitializeComponent();
        }
        // 
        MainFrm.frmMainF frmv = new MainFrm.frmMainF();
        bool CheckEmpty()
        {
            bool result = true;
            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Name!");
            }
            else if (cmbgender.SelectedIndex == -1)
            {
                MessageBox.Show("Please Input Gender");
            }
            else if (txtage.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Age");
            }
            else if (txtnation.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Nation");
            }
            else if (txtregion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Region");
            }
            else if (txtidcard.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input IdCard");
            }
            else if (txtphone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Input Phone");
            }
            else
            {
                return false;
            }
            return result;
        }
        void openFileDialogs()
        {
            using (OpenFileDialog op = new OpenFileDialog
            { FileName = "", Filter = "PNG File|*.png|JPEG File|*.jpg|All File|*.*" })
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.LoadAsync(op.FileName);// upload pic into pictureBox
                }
            }
        }
        void loadData()
        {
            string sql = "SELECT * FROM customer";
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

        void UpdateCustomer()
        {
            try
            {
                string sql = $@"UPDATE customer SET name = @ne, gender = @gr, age = @age, image = @img,
                             nationality = @na, region = @re, idcardnumber = @idc, phone = @ph, 
                             address = @addr, passportnumber = @pass WHERE id = @id";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", values);
                cmd.Parameters.AddWithValue("@ne", txtname.Text.Trim());
                cmd.Parameters.AddWithValue("@gr", cmbgender.Text.Trim());
                cmd.Parameters.AddWithValue("@age", txtage.Text.Trim());
                cmd.Parameters.AddWithValue("@img", Class.ClassDO.ToByteArray(pictureBox1.Image));
                cmd.Parameters.AddWithValue("@na", txtnation.Text.Trim());
                cmd.Parameters.AddWithValue("@re", txtregion.Text.Trim());
                cmd.Parameters.AddWithValue("@idc", txtidcard.Text.Trim());
                cmd.Parameters.AddWithValue("@ph", txtphone.Text.Trim());
                cmd.Parameters.AddWithValue("addr", rtbdesc.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtpassport.Text.Trim());
                int affected_row = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //void UpdateToDG()
        //{
        //    DataGridViewRow row = tabDetail.Tag as DataGridViewRow;
        //    //row.Cells[0].Value = values;
        //    row.Cells[1].Value = txtname.Text.Trim();
        //    row.Cells[2].Value = cmbgender.Text.Trim();
        //    row.Cells[3].Value = txtage.Text.Trim();
        //    row.Cells[4].Value = pictureBox1.Image;
        //    row.Cells[5].Value = txtnation.Text.Trim();
        //    row.Cells[6].Value = txtregion.Text.Trim();
        //    row.Cells[7].Value = txtidcard.Text.Trim();
        //    row.Cells[8].Value = txtphone.Text.Trim();
        //    row.Cells[9].Value = rtbdesc.Text.Trim();
        //    row.Cells[10].Value = txtpassport.Text.Trim();
        //}
        void ClearText()
        {

            txtname.Clear();
            cmbgender.SelectedIndex = -1;
            txtage.Clear();
            pictureBox1.Image = null;
            txtnation.Clear();
            txtregion.Clear();
            txtidcard.Clear();
            txtphone.Clear();
            rtbdesc.Clear();
            txtpassport.Clear();
        }
        void DeleteCustomer(DataGridViewRow row)
        {
            string id = row.Cells[0].Value.ToString();
            string dsql = "DELETE FROM customer WHERE id = @id";
            cmd = new SqlCommand(dsql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                dataGridView1.Rows.Remove(row);
                MessageBox.Show("ទិន្នន័យត្រូវបានលុប");
            }
        }
        private Form activeForm = null;
        //public void openChildForm(Form chlidForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = chlidForm;
        //    chlidForm.TopLevel = false;
        //    chlidForm.FormBorderStyle = FormBorderStyle.None;
        //    chlidForm.Dock = DockStyle.Fill;
        //    frmv.panelChlidForm.Controls.Add(chlidForm);

        //    frmv.panelChlidForm.Controls.Add(chlidForm);
        //    frmv.panelChlidForm.Tag = chlidForm;
        //    chlidForm.BringToFront();
        //    chlidForm.BringToFront();
        //    chlidForm.Show();
        //}
        public void openChildForm(Form chlidForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = chlidForm;
            chlidForm.TopLevel = false;
            chlidForm.FormBorderStyle = FormBorderStyle.None;
            chlidForm.Dock = DockStyle.Fill;
            pnlDetail.Controls.Add(chlidForm);
            pnlDetail.Tag = chlidForm;
            chlidForm.BringToFront();
            chlidForm.Show();
        }
        //public void show(Form fm )
        //{
        //    fm.FormBorderStyle = FormBorderStyle.None;
        //    fm.Dock = DockStyle.Fill;
        //    fm.TopLevel = false; // ber true can not jak jol form new 
        //    MainFrm.frmMainF frmv = new MainFrm.frmMainF();
        //    frmv.panelChlidForm.Controls.Clear();
        //    frmv.panelChlidForm.Controls.Add(fm);
        //    fm.Show();
        //}
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //if (!CheckEmpty())
            //{
                //try
                //{
                    string sql = $@"INSERT INTO customer(name, gender, age, image, nationality, region,
                            idcardnumber, phone, address, passportnumber) VALUES(@name, @gen, @age, @img, @nation, @reg, @idcard,
                            @phone, @addr, @pass)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Clear();
            //Object obje = pictureBox1.Image == null ? : Class.ClassDO.ToByteArray(pictureBox1.Image);
           
            //cmd.Parameters.AddWithValue("@id", mtxtid.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@gen", cmbgender.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", txtage.Text.Trim());
                    if (pictureBox1.Image == null)
                        cmd.Parameters.Add("@img", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                    else if (pictureBox1.Image != null)
                        cmd.Parameters.Add("@img", Class.ClassDO.ToByteArray(pictureBox1.Image));
            //cmd.Parameters.Add("@img",SqlDbType.VarBinary, -1).Value = DBNull.Value;
            //cmd.Parameters.AddWithValue("@img", DBNull.Value);
                    cmd.Parameters.AddWithValue("@nation", txtnation.Text.Trim());
                    cmd.Parameters.AddWithValue("@reg", txtregion.Text.Trim());
                    cmd.Parameters.AddWithValue("@idcard", txtidcard.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text.Trim());
                    cmd.Parameters.AddWithValue("@addr", rtbdesc.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtpassport.Text.Trim());
                    int affected_row = cmd.ExecuteNonQuery();
                    //MessageBox.Show("Test");
                    if (affected_row > 0)
                    {
                        //DataGridViewRow row = new DataGridViewRow();
                        //row.CreateCells(metroGrid1);
                        //row.Cells[0].Value = mtxtid.Text.Trim();
                        //row.Cells[1].Value = mtxtname.Text.Trim();
                        //row.Cells[2].Value = mcmdgender.Text.Trim();
                        //row.Cells[3].Value = mtxtage.Text.Trim();
                        //row.Cells[4].Value = picturebox.Image;
                        //row.Cells[5].Value = mtxtnation.Text.Trim();
                        //row.Cells[6].Value = mtxtregion.Text.Trim();
                        //row.Cells[7].Value = mtxtidcard.Text.Trim();
                        //row.Cells[8].Value = mtxtphone.Text.Trim();
                        //row.Cells[9].Value = rtbaddress.Text.Trim();
                        //row.Cells[10].Value = mtxtpassport.Text.Trim();
                        //metroGrid1.Rows.Add(row);
                        loadData();
                        MessageBox.Show("បញ្ចូលទិន្នន័យបានជោគជ័យ");
                    }
               // }
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                // Clear Data in Control

           // }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                contextMenuStrip1.Tag = dataGridView1.Rows[e.RowIndex];
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void កបរទនននយToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            values = row.Cells[0].Value.ToString();
            txtname.Text = row.Cells[1].Value.ToString();
            cmbgender.Text = row.Cells[2].Value.ToString();
            txtage.Text = row.Cells[3].Value.ToString();
            // Image
            byte[] raw = (byte[])row.Cells[4].Value;
            System.IO.MemoryStream memory = new System.IO.MemoryStream(raw);
            //picturebox.Image = Class.DO.ToImage(raw[]);
            pictureBox1.Image = Image.FromStream(memory);
            txtnation.Text = row.Cells[5].Value.ToString();
            txtregion.Text = row.Cells[6].Value.ToString();
            txtidcard.Text = row.Cells[7].Value.ToString();
            txtphone.Text = row.Cells[8].Value.ToString();
            rtbdesc.Text = row.Cells[9].Value.ToString();
            txtpassport.Text = row.Cells[10].Value.ToString();
            tabDetail.SelectTab(0);
            // Change Button Name           
            btnsave.Click -= btnsave_Click;
            btnsave.Text = "Update";
            btnsave.Click += btnupdate_Click;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
            loadData();
            //UpdateToDG();
            ClearText();
            //
            //mtxtid.Enabled = false;
            btnsave.Text = "Save";
            btnsave.Click -= btnupdate_Click;
            btnsave.Click += btnsave_Click;
        }
        private void លមអតToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            //frmview frmv = new frmview();
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            string name = (row.Cells[1].Value.ToString() != null) ? (row.Cells[1].Value.ToString()) : ("null");
            string gender = (row.Cells[2].Value.ToString() != null) ? (row.Cells[2].Value.ToString()) : ("null");
            string age = (row.Cells[3].Value.ToString() != null) ? (row.Cells[3].Value.ToString()) : ("0");
            string nation = (row.Cells[5].Value.ToString() != null) ? (row.Cells[5].Value.ToString()) : ("null");
            string regions = (row.Cells[6].Value.ToString() != null) ? (row.Cells[6].Value.ToString()) : ("null");
            string idcard = (row.Cells[7].Value.ToString() != null) ? (row.Cells[7].Value.ToString()) : ("null");
            string phone = (row.Cells[8].Value.ToString() != null) ? (row.Cells[8].Value.ToString()) : ("null");
            string address = (row.Cells[9].Value.ToString() != null) ? (row.Cells[9].Value.ToString()) : ("null");
            string passport = (row.Cells[10].Value.ToString() != null) ? (row.Cells[10].Value.ToString()) : ("null");
            // frmv.mlbl.Text = row.Cells[0].Value.ToString();
            //frmv.lblname.Text = row.Cells[1].Value.ToString();
            //frmv.lblgender.Text = row.Cells[2].Value.ToString();
            //frmv.lblage.Text = row.Cells[3].Value.ToString();
            //// Image
            //byte[] raw = (byte[])row.Cells[4].Value;
            //System.IO.MemoryStream memory = new System.IO.MemoryStream(raw);
            ////picturebox.Image = Class.DO.ToImage(raw[]);
            //frmv.pictureBox1.Image = Image.FromStream(memory);
            //frmv.lblnation.Text = row.Cells[5].Value.ToString();
            //frmv.lblregion.Text = row.Cells[6].Value.ToString();
            //frmv.lblidcad.Text = row.Cells[7].Value.ToString();
            //frmv.lblphone.Text = row.Cells[8].Value.ToString();
            //frmv.lbladdress.Text = row.Cells[9].Value.ToString();
            //frmv.lblpassport.Text = row.Cells[10].Value.ToString();
            //this.Hide();
            //frmv.btnleave.Text = "ត្រឡប់ក្រោយ";
            openChildForm(new frmview(
                new Class.CustomerView(
                    name,
                    gender,
                    int.Parse(age),
                    (byte[])row.Cells[4].Value,
                    nation,
                    regions,
                    idcard,
                    phone,
                    address,
                    passport
                )));
            tabDetail.SelectedIndex = 2;
            //frmv.ShowDialog();
            //this.Close();
        }

        private void លបទនននយToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            DeleteCustomer(row);
        }

        private void txtname_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox text = sender as TextBox;
            if (text != null)
            {
                btnleave.Text = "លុប";
            }
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            if (btnleave.Text == "លុប")
            {
                ClearText();
                btnleave.Text = "ចាកចេញ";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialogs();
        }
    }
}
