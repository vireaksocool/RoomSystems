namespace RoomSystems.Connection
{
    partial class frmConnection
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
            this.gpb = new System.Windows.Forms.GroupBox();
            this.chbshow = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdbname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtservername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnconnect = new System.Windows.Forms.Button();
            this.gpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.chbshow);
            this.gpb.Controls.Add(this.txtpassword);
            this.gpb.Controls.Add(this.txtusername);
            this.gpb.Controls.Add(this.label4);
            this.gpb.Controls.Add(this.label5);
            this.gpb.Enabled = false;
            this.gpb.Location = new System.Drawing.Point(27, 138);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(388, 134);
            this.gpb.TabIndex = 15;
            this.gpb.TabStop = false;
            this.gpb.Text = "SQL Server Authentication";
            // 
            // chbshow
            // 
            this.chbshow.AutoSize = true;
            this.chbshow.Location = new System.Drawing.Point(148, 98);
            this.chbshow.Name = "chbshow";
            this.chbshow.Size = new System.Drawing.Size(123, 21);
            this.chbshow.TabIndex = 11;
            this.chbshow.Text = "ShowPassword";
            this.chbshow.UseVisualStyleBackColor = true;
            this.chbshow.CheckedChanged += new System.EventHandler(this.chbshow_CheckedChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(148, 67);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(218, 23);
            this.txtpassword.TabIndex = 10;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(148, 35);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(218, 23);
            this.txtusername.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "UserName:";
            // 
            // txtdbname
            // 
            this.txtdbname.Location = new System.Drawing.Point(175, 96);
            this.txtdbname.Margin = new System.Windows.Forms.Padding(2);
            this.txtdbname.Name = "txtdbname";
            this.txtdbname.Size = new System.Drawing.Size(240, 23);
            this.txtdbname.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ឈ្មោះDatabase";
            // 
            // txtservername
            // 
            this.txtservername.Location = new System.Drawing.Point(175, 64);
            this.txtservername.Margin = new System.Windows.Forms.Padding(2);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(240, 23);
            this.txtservername.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ឈ្មោះServer:";
            // 
            // cmdtype
            // 
            this.cmdtype.BackColor = System.Drawing.SystemColors.Window;
            this.cmdtype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdtype.FormattingEnabled = true;
            this.cmdtype.Items.AddRange(new object[] {
            "Window Authentication",
            "SQL Server Authentication"});
            this.cmdtype.Location = new System.Drawing.Point(175, 28);
            this.cmdtype.Margin = new System.Windows.Forms.Padding(2);
            this.cmdtype.Name = "cmdtype";
            this.cmdtype.Size = new System.Drawing.Size(240, 25);
            this.cmdtype.TabIndex = 10;
            this.cmdtype.SelectedIndexChanged += new System.EventHandler(this.cmdtype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Authentication:";
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(269, 278);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(146, 36);
            this.btnCanel.TabIndex = 17;
            this.btnCanel.Text = "Canel";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(52, 278);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(146, 36);
            this.btnconnect.TabIndex = 16;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 343);
            this.Controls.Add(this.gpb);
            this.Controls.Add(this.txtdbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtservername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdtype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnconnect);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConnection";
            this.Text = "frmConnection";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConnection_KeyDown);
            this.gpb.ResumeLayout(false);
            this.gpb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb;
        private System.Windows.Forms.CheckBox chbshow;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnconnect;
    }
}