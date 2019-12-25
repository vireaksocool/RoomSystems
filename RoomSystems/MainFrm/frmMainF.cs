using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomSystems.Renting;

namespace RoomSystems.MainFrm
{
    public partial class frmMainF : Form
    {
        public frmMainF()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            paneldatasubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (paneldatasubmenu.Visible == false)
                paneldatasubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
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
            panelChlidForm.Controls.Add(chlidForm);
            panelChlidForm.Tag = chlidForm;
            chlidForm.BringToFront();
            chlidForm.Show();
        }
        //public void openChild(Form chlidForm)
        //{
        //    chlidForm.TopLevel = false;
        //    chlidForm.FormBorderStyle = FormBorderStyle.None;
        //    chlidForm.Dock = DockStyle.Fill;
        //    panelChlidForm.Controls.Add(chlidForm);
        //    panelChlidForm.Tag = chlidForm;
        //    chlidForm.BringToFront();
        //    chlidForm.Show();
        //}
        //public void showformCNRenting(Form frm)
        //{
        //    //panelChlidForm.Invalidate();
        //    openChild(frm);
        //}
        private bool mouseDown;
        private Point lastLocation;
        private void frmMainF_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;          
        }

        private void frmMainF_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;         
        }
        private void frmMainF_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y );
            }        
        }
        private void panelheader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void panelheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void panelheader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelleft_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelleft_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void panelleft_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void btndata_Click(object sender, EventArgs e)
        {
            showSubMenu(paneldatasubmenu);
        }

        private void panelChlidForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelChlidForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void panelChlidForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void btnrenting_Click(object sender, EventArgs e)
        {
            //openChildForm(new Register.frmRegister());
            openChildForm(new Renting.frmRentingRooms());
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            openChildForm(new Booking.frmBooking());
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            openChildForm(new Register.frmRegister());
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            openChildForm(new Rooms.frmRooms());
        }

        private void btnshowrentingcust_Click(object sender, EventArgs e)
        {
            openChildForm(new RentingRoom.frmRentingRoom());
        }

        private void btnshowbooking_Click(object sender, EventArgs e)
        {
            openChildForm(new BookingRoom.frmBookingRoom());
        }

        private void btnrentingroom_Click(object sender, EventArgs e)
        {
            openChildForm(new RemiderRoom.frmReminderRoom());
        }

        private void frmMainF_Load(object sender, EventArgs e)
        {
            openChildForm(new RemiderRoom.frmReminderRoom());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnrenting_Click_1(object sender, EventArgs e)
        {
            //showSubMenu(panel1);
        }
    }
}
