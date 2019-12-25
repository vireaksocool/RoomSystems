using RoomSystems.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomSystems.Register
{
    public partial class frmview : Form
    {
        public frmview(CustomerView view
            )
        {
            InitializeComponent();
            this.lblname.Text = view.name;
            this.lblgender.Text = view.gender;
            this.lblage.Text = view.age.ToString();
            // Image
            byte[] raw = view.image;
            System.IO.MemoryStream memory = new System.IO.MemoryStream(raw);
            //picturebox.Image = Class.DO.ToImage(raw[]);
            this.pictureBox1.Image = Image.FromStream(memory);
            this.lblnation.Text = view.nation;
            this.lblregion.Text = view.region;
            this.lblidcad.Text = view.idcard;
            this.lblphone.Text = view.phone;
            this.lbladdress.Text = view.address;
            this.lblpassport.Text = view.passport;
        }

        private void frmview_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }
    }
}
