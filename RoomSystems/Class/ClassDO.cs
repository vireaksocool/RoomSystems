
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RoomSystems.Class
{
    public static class ClassDO
    {
        static SqlConnection conn = Class.ClassConnection.GetDBConnection();
        static SqlCommand cmd;
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int connDescription, int ReservedValue);


        // this code is to use windinet.dll
        public static void Restart()
        {
            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                frm.Close();
            }
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            // Application Restart();
        }
        public class ComboboxItem
        {
            public string key { set; get; }
            public string value { set; get; }

            override
            public String ToString()
            {
                return this.value;
            }
        }
        public static void NotavaibleRoom(string mcmd)
        {
            try
            {
                string sql = $@"UPDATE Rooms SET available​​ = 0 WHERE id = @id";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@situa", );
                cmd.Parameters.AddWithValue("@id", mcmd);
                int affected_row = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(affected_row.ToString());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public static byte[] ToByteArray(this Image img)
        {
            MemoryStream memory = new MemoryStream();
            img.Save(memory, img.RawFormat);
            return memory.ToArray(); // img pointer to image
        }
    }
}
