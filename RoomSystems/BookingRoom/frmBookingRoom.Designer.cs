namespace RoomSystems.BookingRoom
{
    partial class frmBookingRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.លមអតToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ឈបកកToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roombookingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneybooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneldetail = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.លមអតToolStripMenuItem,
            this.ឈបកកToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            // 
            // លមអតToolStripMenuItem
            // 
            this.លមអតToolStripMenuItem.Name = "លមអតToolStripMenuItem";
            this.លមអតToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.លមអតToolStripMenuItem.Text = "លម្អិត";
            this.លមអតToolStripMenuItem.Click += new System.EventHandler(this.លមអតToolStripMenuItem_Click);
            // 
            // ឈបកកToolStripMenuItem
            // 
            this.ឈបកកToolStripMenuItem.Name = "ឈបកកToolStripMenuItem";
            this.ឈបកកToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ឈបកកToolStripMenuItem.Text = "ឈប់កក់";
            this.ឈបកកToolStripMenuItem.Click += new System.EventHandler(this.ឈបកកToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 491);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ទិន្នន័យការបន្ទប់";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.paneldetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(698, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "លម្អិត";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roombookingid,
            this.roomid,
            this.customerid,
            this.roomname,
            this.customername,
            this.phone,
            this.startdate,
            this.expiredate,
            this.moneybooking,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(8, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer CN Otaki", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(682, 373);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            // 
            // roombookingid
            // 
            this.roombookingid.HeaderText = "អត្ថលេខ";
            this.roombookingid.Name = "roombookingid";
            this.roombookingid.ReadOnly = true;
            this.roombookingid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roombookingid.Visible = false;
            // 
            // roomid
            // 
            this.roomid.HeaderText = "RoomID";
            this.roomid.Name = "roomid";
            this.roomid.ReadOnly = true;
            this.roomid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomid.Visible = false;
            // 
            // customerid
            // 
            this.customerid.HeaderText = "CustomerID";
            this.customerid.Name = "customerid";
            this.customerid.ReadOnly = true;
            this.customerid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerid.Visible = false;
            // 
            // roomname
            // 
            this.roomname.HeaderText = "បន្ទប់";
            this.roomname.Name = "roomname";
            this.roomname.ReadOnly = true;
            // 
            // customername
            // 
            this.customername.HeaderText = "អតិថិជន";
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "លេខទូរស័ព្ទ";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // startdate
            // 
            this.startdate.HeaderText = "ថ្ងៃចាប់ផ្តើម";
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            // 
            // expiredate
            // 
            this.expiredate.HeaderText = "ថ្ងៃផុតកំណត់";
            this.expiredate.Name = "expiredate";
            this.expiredate.ReadOnly = true;
            // 
            // moneybooking
            // 
            this.moneybooking.HeaderText = "ចំនួនទឹកប្រាក់";
            this.moneybooking.Name = "moneybooking";
            this.moneybooking.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "សន្ថាភាព";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // paneldetail
            // 
            this.paneldetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldetail.Location = new System.Drawing.Point(3, 3);
            this.paneldetail.Name = "paneldetail";
            this.paneldetail.Size = new System.Drawing.Size(692, 448);
            this.paneldetail.TabIndex = 0;
            // 
            // frmBookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 491);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Khmer CN Otaki", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmBookingRoom";
            this.Text = "frmBookingRoom";
            this.Load += new System.EventHandler(this.frmBookingRoom_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem លមអតToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ឈបកកToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roombookingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomname;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneybooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel paneldetail;
    }
}