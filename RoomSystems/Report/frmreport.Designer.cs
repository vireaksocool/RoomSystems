namespace RoomSystems.Report
{
    partial class frmreport
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
            this.dataSet11 = new RoomSystems.DataSet1();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableAdapterManager1 = new RoomSystems.DataSet1TableAdapters.TableAdapterManager();
            this.customerTableAdapter1 = new RoomSystems.DataSet1TableAdapters.customerTableAdapter();
            this.rents_roomTableAdapter1 = new RoomSystems.DataSet1TableAdapters.rents_roomTableAdapter();
            this.roomsTableAdapter1 = new RoomSystems.DataSet1TableAdapters.RoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(904, 495);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.customerTableAdapter = this.customerTableAdapter1;
            this.tableAdapterManager1.rents_roomTableAdapter = this.rents_roomTableAdapter1;
            this.tableAdapterManager1.RoomsTableAdapter = this.roomsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = RoomSystems.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // rents_roomTableAdapter1
            // 
            this.rents_roomTableAdapter1.ClearBeforeFill = true;
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // frmreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 495);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Khmer CN Otaki", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmreport";
            this.Text = "frmreport";
            this.Load += new System.EventHandler(this.frmreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DataSet1TableAdapters.customerTableAdapter customerTableAdapter1;
        private DataSet1TableAdapters.rents_roomTableAdapter rents_roomTableAdapter1;
        private DataSet1TableAdapters.RoomsTableAdapter roomsTableAdapter1;
    }
}