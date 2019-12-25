namespace RoomSystems.RentingRoom
{
    partial class frmRentingRoom
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
            this.លបToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.paneldetail = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Khmer CN Otaki", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.លមអតToolStripMenuItem,
            this.លបToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 56);
            // 
            // លមអតToolStripMenuItem
            // 
            this.លមអតToolStripMenuItem.Name = "លមអតToolStripMenuItem";
            this.លមអតToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.លមអតToolStripMenuItem.Text = "លម្អិត";
            this.លមអតToolStripMenuItem.Click += new System.EventHandler(this.លមអតToolStripMenuItem_Click);
            // 
            // លបToolStripMenuItem
            // 
            this.លបToolStripMenuItem.Name = "លបToolStripMenuItem";
            this.លបToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.លបToolStripMenuItem.Text = "ឈប់ជួល";
            this.លបToolStripMenuItem.Click += new System.EventHandler(this.លបToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 488);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ទិន្នន័យអ្នកកំពុងជួល";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomid,
            this.customerid,
            this.roomname,
            this.customername,
            this.phone,
            this.checkindate,
            this.checkoutdate,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(25, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer CN Otaki", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(593, 344);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_2);
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
            this.roomname.Width = 104;
            // 
            // customername
            // 
            this.customername.HeaderText = "អតិថិជន";
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            this.customername.Width = 104;
            // 
            // phone
            // 
            this.phone.HeaderText = "លេខទូរស័ព្ទ";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 104;
            // 
            // checkindate
            // 
            this.checkindate.HeaderText = "ថ្ងៃចាប់ផ្តើម";
            this.checkindate.Name = "checkindate";
            this.checkindate.ReadOnly = true;
            this.checkindate.Width = 104;
            // 
            // checkoutdate
            // 
            this.checkoutdate.HeaderText = "ថ្ងៃផុតកំណត់";
            this.checkoutdate.Name = "checkoutdate";
            this.checkoutdate.ReadOnly = true;
            this.checkoutdate.Width = 104;
            // 
            // status
            // 
            this.status.HeaderText = "សន្ថាភាព";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 104;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.paneldetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "លម្អិត";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // paneldetail
            // 
            this.paneldetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldetail.Location = new System.Drawing.Point(3, 3);
            this.paneldetail.Name = "paneldetail";
            this.paneldetail.Size = new System.Drawing.Size(636, 445);
            this.paneldetail.TabIndex = 0;
            // 
            // frmRentingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 488);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Khmer CN Otaki", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmRentingRoom";
            this.Text = "frmRentingRoom";
            this.Load += new System.EventHandler(this.frmRentingRoom_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem លមអតToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem លបToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomname;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel paneldetail;
    }
}