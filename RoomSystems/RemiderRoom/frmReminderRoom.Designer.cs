namespace RoomSystems.RemiderRoom
{
    partial class frmReminderRoom
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
            this.បនតកជលToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ឈបជលToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelcnrenting = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.បនតកជលToolStripMenuItem,
            this.ឈបជលToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // បនតកជលToolStripMenuItem
            // 
            this.បនតកជលToolStripMenuItem.Name = "បនតកជលToolStripMenuItem";
            this.បនតកជលToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.បនតកជលToolStripMenuItem.Text = "បន្តកាជួល";
            this.បនតកជលToolStripMenuItem.Click += new System.EventHandler(this.បនតកជលToolStripMenuItem_Click);
            // 
            // ឈបជលToolStripMenuItem
            // 
            this.ឈបជលToolStripMenuItem.Name = "ឈបជលToolStripMenuItem";
            this.ឈបជលToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ឈបជលToolStripMenuItem.Text = "ឈប់ជួល";
            this.ឈបជលToolStripMenuItem.Click += new System.EventHandler(this.ឈបជលToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "រំលឹក";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer CN Otaki", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "រំលឹកបន្ទប់";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentid,
            this.roomid,
            this.custid,
            this.roomname,
            this.customername,
            this.phone,
            this.checkindate,
            this.checkoutdate});
            this.dataGridView1.Location = new System.Drawing.Point(9, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer CN Otaki", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(649, 300);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // rentid
            // 
            this.rentid.HeaderText = "rentid";
            this.rentid.Name = "rentid";
            this.rentid.ReadOnly = true;
            this.rentid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rentid.Visible = false;
            // 
            // roomid
            // 
            this.roomid.HeaderText = "roomid";
            this.roomid.Name = "roomid";
            this.roomid.ReadOnly = true;
            this.roomid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomid.Visible = false;
            // 
            // custid
            // 
            this.custid.HeaderText = "customerid";
            this.custid.Name = "custid";
            this.custid.ReadOnly = true;
            this.custid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.custid.Visible = false;
            // 
            // roomname
            // 
            this.roomname.HeaderText = "បន្ទប់";
            this.roomname.Name = "roomname";
            this.roomname.ReadOnly = true;
            // 
            // customername
            // 
            this.customername.HeaderText = "ឈ្មោះ";
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "ទូរស័ព្ទ";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // checkindate
            // 
            this.checkindate.HeaderText = "ថ្វៃចូល";
            this.checkindate.Name = "checkindate";
            this.checkindate.ReadOnly = true;
            // 
            // checkoutdate
            // 
            this.checkoutdate.HeaderText = "ថ្ងៃចេញ";
            this.checkoutdate.Name = "checkoutdate";
            this.checkoutdate.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelcnrenting);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "បន្តជួល";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelcnrenting
            // 
            this.panelcnrenting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcnrenting.Location = new System.Drawing.Point(3, 3);
            this.panelcnrenting.Name = "panelcnrenting";
            this.panelcnrenting.Size = new System.Drawing.Size(661, 392);
            this.panelcnrenting.TabIndex = 0;
            // 
            // frmReminderRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 435);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Khmer CN Otaki", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmReminderRoom";
            this.Text = "frmReminderRoom";
            this.Load += new System.EventHandler(this.frmReminderRoom_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem បនតកជលToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ឈបជលToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn custid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomname;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutdate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelcnrenting;
    }
}