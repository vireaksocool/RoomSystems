using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomSystems.Class
{
    static class QuerySql
    {
        static SqlConnection conn = Class.ClassConnection.GetDBConnection();
        static SqlCommand cmd;
        static DataTable dt = new DataTable();
        public static void Checkinroom(string mcmd)
        {
            string sta = "Checkin";
            try
            {
                string sql = $@"UPDATE Rooms SET status = @sta WHERE id = @id";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@situa", );
                cmd.Parameters.AddWithValue("@id", mcmd);
                cmd.Parameters.AddWithValue("@sta", sta);
                int affected_row = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(affected_row.ToString());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public static void BookingRoom(string booking)
        {
            string sta = "Booking";
            try
            {
                string sql = $@"UPDATE Rooms SET status = @sta WHERE id = @id";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@situa", sta);
                cmd.Parameters.AddWithValue("@id", booking);
                cmd.Parameters.AddWithValue("@sta", sta);
                int affected_row = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(affected_row.ToString());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //public string querycmbroom(string id)
        //{
        //    string sql = "SELECT id,name FROM customer;";

        //    cmd = new SqlCommand(sql, conn);
        //    cmd.ExecuteNonQuery();
        //    SqlDataAdapter dta = new SqlDataAdapter(cmd);
        //    dta.Fill(dt);

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        ClassDO.ComboboxItem item = new ClassDO.ComboboxItem();
        //        item.key = dr["id"].ToString();
        //        item.value = dr["name"].ToString();
        //        //cmbcustm.Items.Add(item);
        //    }

        //}      

    }
}
