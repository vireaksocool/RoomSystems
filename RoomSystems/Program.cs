using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomSystems
{
    static class Program
    {
        internal static string Connectionstring = Properties.Settings.Default.ConStr;
        public static bool ValidConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Connectionstring);
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!ValidConnection())
            {
                Application.Run(new Connection.frmConnection());
            }
            else
            {
                Application.Run(new Login.frmLogin());
                //pplication.Run(new MainFrm.frmMainF());
                //Application.Run(new MainFrm.frmMainF());
                //Application.Run(new Rooms.frmRooms());
                //Application.Run(new Renting.frmRentingRooms());
                //Application.Run(new Register.frmRegister());
                //Application.Run(new Register.frmRegister());
                // Application.Run(new RentingRoom.frmRentingRoom());
                // Application.Run(new Booking.frmBooking());
                //Application.Run(new BookingRoom.frmBookingRoom());
            }
        }
    }
}
