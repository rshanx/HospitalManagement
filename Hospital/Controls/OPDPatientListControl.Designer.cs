﻿namespace Hospital.Controls
{
    partial class OPDPatientListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOPDHistoryProcedure = new System.Windows.Forms.ToolStripButton();
            this.tsbOPDInvestigationProcedure = new System.Windows.Forms.ToolStripButton();
            this.tsbOPDTreatmentProcedure = new System.Windows.Forms.ToolStripButton();
            this.tsbOPDPrescription = new System.Windows.Forms.ToolStripButton();
            this.tsbAppointment = new System.Windows.Forms.ToolStripButton();
            this.tsbAppointmentReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsp2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.cmbPatientStatus = new System.Windows.Forms.ToolStripComboBox();
            this.tslDateFrom = new System.Windows.Forms.ToolStripLabel();
            this.tslDateTo = new System.Windows.Forms.ToolStripLabel();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tspToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeight = 24;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumber,
            this.clmPatientName,
            this.clmGender,
            this.clmContactNo,
            this.clmAge,
            this.clmCity,
            this.clmNote,
            this.clmFill});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 46);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1343, 521);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 16;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Patient No";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmPatientName
            // 
            this.clmPatientName.HeaderText = "Patient Name";
            this.clmPatientName.Name = "clmPatientName";
            this.clmPatientName.ReadOnly = true;
            this.clmPatientName.Width = 200;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "Gender";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            this.clmGender.Width = 70;
            // 
            // clmContactNo
            // 
            this.clmContactNo.FillWeight = 120F;
            this.clmContactNo.HeaderText = "Contact No";
            this.clmContactNo.Name = "clmContactNo";
            this.clmContactNo.ReadOnly = true;
            // 
            // clmAge
            // 
            this.clmAge.HeaderText = "Age";
            this.clmAge.Name = "clmAge";
            this.clmAge.ReadOnly = true;
            this.clmAge.Width = 70;
            // 
            // clmCity
            // 
            this.clmCity.HeaderText = "City";
            this.clmCity.Name = "clmCity";
            this.clmCity.ReadOnly = true;
            // 
            // clmNote
            // 
            this.clmNote.HeaderText = "Note";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            this.clmNote.Width = 200;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Hospital.Properties.Resources.Add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 20);
            this.tsbAdd.Text = "&Add";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::Hospital.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 20);
            this.tsbOpen.Text = "&Open";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbOPDHistoryProcedure
            // 
            this.tsbOPDHistoryProcedure.Image = global::Hospital.Properties.Resources.Attachment;
            this.tsbOPDHistoryProcedure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOPDHistoryProcedure.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsbOPDHistoryProcedure.Name = "tsbOPDHistoryProcedure";
            this.tsbOPDHistoryProcedure.Size = new System.Drawing.Size(122, 20);
            this.tsbOPDHistoryProcedure.Text = "&History Procedure";
            this.tsbOPDHistoryProcedure.Click += new System.EventHandler(this.tsbOPDHistoryProcedure_Click);
            // 
            // tsbOPDInvestigationProcedure
            // 
            this.tsbOPDInvestigationProcedure.Image = global::Hospital.Properties.Resources.Attachment;
            this.tsbOPDInvestigationProcedure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOPDInvestigationProcedure.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsbOPDInvestigationProcedure.Name = "tsbOPDInvestigationProcedure";
            this.tsbOPDInvestigationProcedure.Size = new System.Drawing.Size(152, 20);
            this.tsbOPDInvestigationProcedure.Text = "&Investigation Procedure";
            this.tsbOPDInvestigationProcedure.Click += new System.EventHandler(this.tsbOPDInvestigationProcedure_Click);
            // 
            // tsbOPDTreatmentProcedure
            // 
            this.tsbOPDTreatmentProcedure.Image = global::Hospital.Properties.Resources.Attachment;
            this.tsbOPDTreatmentProcedure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOPDTreatmentProcedure.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsbOPDTreatmentProcedure.Name = "tsbOPDTreatmentProcedure";
            this.tsbOPDTreatmentProcedure.Size = new System.Drawing.Size(139, 20);
            this.tsbOPDTreatmentProcedure.Text = "&Treatment Procedure";
            this.tsbOPDTreatmentProcedure.Click += new System.EventHandler(this.tsbOPDTreatmentProcedure_Click);
            // 
            // tsbOPDPrescription
            // 
            this.tsbOPDPrescription.Image = global::Hospital.Properties.Resources.Attachment;
            this.tsbOPDPrescription.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOPDPrescription.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsbOPDPrescription.Name = "tsbOPDPrescription";
            this.tsbOPDPrescription.Size = new System.Drawing.Size(90, 20);
            this.tsbOPDPrescription.Text = "&Prescription";
            this.tsbOPDPrescription.Click += new System.EventHandler(this.tsbOPDPrescription_Click);
            // 
            // tsbAppointment
            // 
            this.tsbAppointment.Image = global::Hospital.Properties.Resources.Attachment;
            this.tsbAppointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAppointment.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsbAppointment.Name = "tsbAppointment";
            this.tsbAppointment.Size = new System.Drawing.Size(98, 20);
            this.tsbAppointment.Text = "&Appointment";
            this.tsbAppointment.Click += new System.EventHandler(this.tsbAppointment_Click);
            // 
            // tsbAppointmentReport
            // 
            this.tsbAppointmentReport.Image = global::Hospital.Properties.Resources.Attachment;
            this.tsbAppointmentReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAppointmentReport.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsbAppointmentReport.Name = "tsbAppointmentReport";
            this.tsbAppointmentReport.Size = new System.Drawing.Size(136, 20);
            this.tsbAppointmentReport.Text = "&Appointment Report";
            this.tsbAppointmentReport.Click += new System.EventHandler(this.tsbAppointmentReport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tslSearch
            // 
            this.tslSearch.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(51, 15);
            this.tslSearch.Text = "&Search : ";
            // 
            // tstSearch
            // 
            this.tstSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.Size = new System.Drawing.Size(100, 23);
            // 
            // tsp2
            // 
            this.tsp2.Name = "tsp2";
            this.tsp2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = global::Hospital.Properties.Resources.Find;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.MergeIndex = 0;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(42, 20);
            this.tsbSearch.Text = "&Go";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::Hospital.Properties.Resources.Cancel;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 20);
            this.tsbClose.Text = "&Close";
            // 
            // tspToolbar
            // 
            this.tspToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripSeparator2,
            this.tsbOpen,
            this.toolStripSeparator3,
            this.tsbOPDHistoryProcedure,
            this.tsbOPDInvestigationProcedure,
            this.tsbOPDTreatmentProcedure,
            this.tsbOPDPrescription,
            this.tsbAppointment,
            this.tsbAppointmentReport,
            this.cmbPatientStatus,
            this.tsp2,
            this.tslDateFrom,
            this.tslDateTo,
            this.toolStripSeparator1,
            this.tslSearch,
            this.tstSearch,
            this.tsbSearch,
            this.tsbClose});
            this.tspToolbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspToolbar.Location = new System.Drawing.Point(0, 0);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.tspToolbar.Size = new System.Drawing.Size(1343, 46);
            this.tspToolbar.Stretch = true;
            this.tspToolbar.TabIndex = 12;
            this.tspToolbar.Text = "toolStrip1";
            // 
            // cmbPatientStatus
            // 
            this.cmbPatientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientStatus.Items.AddRange(new object[] {
            "Current"});
            this.cmbPatientStatus.Name = "cmbPatientStatus";
            this.cmbPatientStatus.Size = new System.Drawing.Size(75, 23);
            this.cmbPatientStatus.SelectedIndexChanged += new System.EventHandler(this.cmbPatientStatus_SelectedIndexChanged);
            // 
            // tslDateFrom
            // 
            this.tslDateFrom.Margin = new System.Windows.Forms.Padding(1, 3, 100, 2);
            this.tslDateFrom.Name = "tslDateFrom";
            this.tslDateFrom.Size = new System.Drawing.Size(65, 15);
            this.tslDateFrom.Text = "DateFrom :";
            // 
            // tslDateTo
            // 
            this.tslDateTo.Margin = new System.Windows.Forms.Padding(1, 3, 3, 2);
            this.tslDateTo.Name = "tslDateTo";
            this.tslDateTo.Size = new System.Drawing.Size(51, 15);
            this.tslDateTo.Text = "DateTo :";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Checked = false;
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(1184, 4);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = true;
            this.dtpDateTo.Size = new System.Drawing.Size(99, 21);
            this.dtpDateTo.TabIndex = 15;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Checked = false;
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(1020, 3);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowCheckBox = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(103, 21);
            this.dtpDateFrom.TabIndex = 14;
            // 
            // OPDPatientListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.tspToolbar);
            this.Name = "OPDPatientListControl";
            this.Size = new System.Drawing.Size(1343, 567);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbOPDHistoryProcedure;
        private System.Windows.Forms.ToolStripButton tsbOPDInvestigationProcedure;
        private System.Windows.Forms.ToolStripButton tsbOPDTreatmentProcedure;
        private System.Windows.Forms.ToolStripButton tsbOPDPrescription;
        private System.Windows.Forms.ToolStripButton tsbAppointment;
        private System.Windows.Forms.ToolStripButton tsbAppointmentReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripSeparator tsp2;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripLabel tslDateFrom;
        private System.Windows.Forms.ToolStripLabel tslDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.ToolStripComboBox cmbPatientStatus;
    }
}
