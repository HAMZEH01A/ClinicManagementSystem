namespace ClinicManagementSystem.Forms
{
    partial class FrmAppointments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle hdrStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlTop              = new System.Windows.Forms.Panel();
            this.lblPageTitle        = new System.Windows.Forms.Label();
            this.lblSearchLbl        = new System.Windows.Forms.Label();
            this.txtSearch           = new System.Windows.Forms.TextBox();
            this.lblStatusLbl        = new System.Windows.Forms.Label();
            this.cmbFilterStatus     = new System.Windows.Forms.ComboBox();
            this.chkFilterDate       = new System.Windows.Forms.CheckBox();
            this.dtpFilterDate       = new System.Windows.Forms.DateTimePicker();
            this.btnResetFilter      = new System.Windows.Forms.Button();
            this.btnBookAppointment  = new System.Windows.Forms.Button();
            this.btnCancelSelected   = new System.Windows.Forms.Button();
            this.btnRefresh          = new System.Windows.Forms.Button();
            this.lblCount            = new System.Windows.Forms.Label();

            this.dgvAppointments     = new System.Windows.Forms.DataGridView();
            this.colApptID           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctorName       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialty        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeSlot         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee              = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlBooking          = new System.Windows.Forms.Panel();
            this.lblBookingTitle     = new System.Windows.Forms.Label();
            this.lblPatientLbl       = new System.Windows.Forms.Label();
            this.cmbPatient          = new System.Windows.Forms.ComboBox();
            this.lblDoctorLbl        = new System.Windows.Forms.Label();
            this.cmbDoctor           = new System.Windows.Forms.ComboBox();
            this.lblDateLbl          = new System.Windows.Forms.Label();
            this.dtpAppointmentDate  = new System.Windows.Forms.DateTimePicker();
            this.lblTimeLbl          = new System.Windows.Forms.Label();
            this.cmbTimeSlot         = new System.Windows.Forms.ComboBox();
            this.lblStatusBookLbl    = new System.Windows.Forms.Label();
            this.cmbStatus           = new System.Windows.Forms.ComboBox();
            this.lblNotesLbl         = new System.Windows.Forms.Label();
            this.txtNotes            = new System.Windows.Forms.TextBox();
            this.btnConfirmBooking   = new System.Windows.Forms.Button();
            this.btnCancelBooking    = new System.Windows.Forms.Button();
            this.btnClearBooking     = new System.Windows.Forms.Button();

            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.pnlBooking.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 70;
            this.pnlTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPageTitle, this.lblSearchLbl, this.txtSearch,
                this.lblStatusLbl, this.cmbFilterStatus,
                this.chkFilterDate, this.dtpFilterDate,
                this.btnResetFilter, this.btnBookAppointment,
                this.btnCancelSelected, this.btnRefresh, this.lblCount
            });

            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPageTitle.Location = new System.Drawing.Point(12, 20);
            this.lblPageTitle.Text = "Appointments Booking & Cancellation";

            this.lblSearchLbl.AutoSize = true;
            this.lblSearchLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchLbl.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchLbl.Location = new System.Drawing.Point(310, 8);
            this.lblSearchLbl.Text = "Search:";

            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(312, 26);
            this.txtSearch.Size = new System.Drawing.Size(165, 25);
            this.txtSearch.PlaceholderText = "Patient or Doctor name...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblStatusLbl.AutoSize = true;
            this.lblStatusLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatusLbl.ForeColor = System.Drawing.Color.Gray;
            this.lblStatusLbl.Location = new System.Drawing.Point(484, 8);
            this.lblStatusLbl.Text = "Status:";

            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterStatus.Items.AddRange(new object[] {
                "All Statuses", "Scheduled", "Waiting", "Completed", "Cancelled" });
            this.cmbFilterStatus.SelectedIndex = 0;
            this.cmbFilterStatus.Location = new System.Drawing.Point(486, 26);
            this.cmbFilterStatus.Size = new System.Drawing.Size(120, 25);
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);

            this.chkFilterDate.AutoSize = true;
            this.chkFilterDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkFilterDate.Location = new System.Drawing.Point(614, 29);
            this.chkFilterDate.Text = "Date:";
            this.chkFilterDate.CheckedChanged += new System.EventHandler(this.chkFilterDate_CheckedChanged);

            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDate.Location = new System.Drawing.Point(658, 26);
            this.dtpFilterDate.Size = new System.Drawing.Size(105, 25);
            this.dtpFilterDate.Enabled = false;
            this.dtpFilterDate.ValueChanged += new System.EventHandler(this.dtpFilterDate_ValueChanged);

            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnResetFilter.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnResetFilter.Location = new System.Drawing.Point(770, 25);
            this.btnResetFilter.Size = new System.Drawing.Size(55, 27);
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            this.btnBookAppointment.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnBookAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAppointment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBookAppointment.ForeColor = System.Drawing.Color.White;
            this.btnBookAppointment.Location = new System.Drawing.Point(832, 24);
            this.btnBookAppointment.Size = new System.Drawing.Size(140, 29);
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.FlatAppearance.BorderSize = 0;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);

            this.btnCancelSelected.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCancelSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelSelected.ForeColor = System.Drawing.Color.White;
            this.btnCancelSelected.Location = new System.Drawing.Point(978, 24);
            this.btnCancelSelected.Size = new System.Drawing.Size(120, 29);
            this.btnCancelSelected.Text = "Cancel Selected";
            this.btnCancelSelected.FlatAppearance.BorderSize = 0;
            this.btnCancelSelected.Click += new System.EventHandler(this.btnCancelSelected_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1104, 24);
            this.btnRefresh.Size = new System.Drawing.Size(80, 29);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCount.Location = new System.Drawing.Point(1192, 28);
            this.lblCount.Size = new System.Drawing.Size(160, 20);
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCount.Text = "Total Appointments: 0";

            // dgvAppointments
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;

            hdrStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            hdrStyle.ForeColor = System.Drawing.Color.White;
            hdrStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.dgvAppointments.ColumnHeadersHeight = 36;
            this.dgvAppointments.EnableHeadersVisualStyles = false;

            altStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 252);
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = altStyle;
            this.dgvAppointments.RowTemplate.Height = 30;
            this.dgvAppointments.SelectionChanged += new System.EventHandler(this.dgvAppointments_SelectionChanged);

            this.colApptID.Name = "colApptID";           this.colApptID.HeaderText = "Appt. ID";       this.colApptID.FillWeight = 65;
            this.colPatientName.Name = "colPatientName"; this.colPatientName.HeaderText = "Patient Name";  this.colPatientName.FillWeight = 130;
            this.colDoctorName.Name = "colDoctorName";   this.colDoctorName.HeaderText = "Doctor Name";   this.colDoctorName.FillWeight = 130;
            this.colSpecialty.Name = "colSpecialty";     this.colSpecialty.HeaderText = "Specialty";      this.colSpecialty.FillWeight = 110;
            this.colDate.Name = "colDate";               this.colDate.HeaderText = "Date";                this.colDate.FillWeight = 80;
            this.colTimeSlot.Name = "colTimeSlot";       this.colTimeSlot.HeaderText = "Time Slot";       this.colTimeSlot.FillWeight = 70;
            this.colStatus.Name = "colStatus";           this.colStatus.HeaderText = "Status";            this.colStatus.FillWeight = 75;
            this.colFee.Name = "colFee";                 this.colFee.HeaderText = "Fee (EGP)";            this.colFee.FillWeight = 65;

            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colApptID, this.colPatientName, this.colDoctorName, this.colSpecialty,
                this.colDate, this.colTimeSlot, this.colStatus, this.colFee
            });

            // pnlBooking (Right Side Panel)
            this.pnlBooking.BackColor = System.Drawing.Color.White;
            this.pnlBooking.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBooking.Width = 320;
            this.pnlBooking.AutoScroll = true;
            this.pnlBooking.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);

            this.lblBookingTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBookingTitle.ForeColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.lblBookingTitle.Location = new System.Drawing.Point(16, 10);
            this.lblBookingTitle.Size = new System.Drawing.Size(285, 28);
            this.lblBookingTitle.Text = "Book / Edit Appointment";

            int y = 46;

            // Patient
            this.lblPatientLbl.Text = "Select Patient *";
            this.lblPatientLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPatientLbl.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblPatientLbl.Location = new System.Drawing.Point(16, y); this.lblPatientLbl.Size = new System.Drawing.Size(285, 18); y += 20;

            this.cmbPatient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.Items.AddRange(new object[] {
                "Ahmed Hassan El-Sayed", "Fatma Ibrahim Khalil", "Mohamed Ramadan Farouq",
                "Nour El-Din Abdallah", "Sara Mahmoud El-Hefny", "Khaled Mostafa El-Attar",
                "Rania Adel Hassan", "Omar Fathy Ibrahim", "Dina Samir Khalifa", "Walid Nasser El-Din"
            });
            this.cmbPatient.Location = new System.Drawing.Point(16, y); this.cmbPatient.Size = new System.Drawing.Size(285, 25); y += 34;

            // Doctor
            this.lblDoctorLbl.Text = "Select Doctor *";
            this.lblDoctorLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDoctorLbl.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblDoctorLbl.Location = new System.Drawing.Point(16, y); this.lblDoctorLbl.Size = new System.Drawing.Size(285, 18); y += 20;

            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.Items.AddRange(new object[] {
                "Dr. Tarek El-Gendy (Cardiology)", "Dr. Mona Abdel-Aziz (Pediatrics)",
                "Dr. Youssef Mansour (Orthopedics)", "Dr. Heba El-Shazly (Dermatology)",
                "Dr. Khaled Naguib (Internal Medicine)", "Dr. Amira Hassan (Neurology)",
                "Dr. Samy El-Sherif (Gynecology)", "Dr. Randa Fawzy (Ophthalmology)"
            });
            this.cmbDoctor.Location = new System.Drawing.Point(16, y); this.cmbDoctor.Size = new System.Drawing.Size(285, 25); y += 34;

            // Appointment Date
            this.lblDateLbl.Text = "Appointment Date *";
            this.lblDateLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDateLbl.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblDateLbl.Location = new System.Drawing.Point(16, y); this.lblDateLbl.Size = new System.Drawing.Size(285, 18); y += 20;

            this.dtpAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.MinDate = System.DateTime.Today;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(16, y); this.dtpAppointmentDate.Size = new System.Drawing.Size(285, 25); y += 34;

            // Time Slot
            this.lblTimeLbl.Text = "Time Slot *";
            this.lblTimeLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTimeLbl.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblTimeLbl.Location = new System.Drawing.Point(16, y); this.lblTimeLbl.Size = new System.Drawing.Size(285, 18); y += 20;

            this.cmbTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeSlot.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTimeSlot.Items.AddRange(new object[] {
                "09:00 AM", "09:30 AM", "10:00 AM", "11:00 AM", "01:00 PM", "02:30 PM", "04:00 PM" });
            this.cmbTimeSlot.SelectedIndex = 0;
            this.cmbTimeSlot.Location = new System.Drawing.Point(16, y); this.cmbTimeSlot.Size = new System.Drawing.Size(285, 25); y += 34;

            // Status
            this.lblStatusBookLbl.Text = "Appointment Status *";
            this.lblStatusBookLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusBookLbl.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblStatusBookLbl.Location = new System.Drawing.Point(16, y); this.lblStatusBookLbl.Size = new System.Drawing.Size(285, 18); y += 20;

            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbStatus.Items.AddRange(new object[] { "Scheduled", "Waiting", "Completed", "Cancelled" });
            this.cmbStatus.SelectedIndex = 0;
            this.cmbStatus.Location = new System.Drawing.Point(16, y); this.cmbStatus.Size = new System.Drawing.Size(285, 25); y += 34;

            // Notes
            this.lblNotesLbl.Text = "Reason for Visit / Notes";
            this.lblNotesLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNotesLbl.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblNotesLbl.Location = new System.Drawing.Point(16, y); this.lblNotesLbl.Size = new System.Drawing.Size(285, 18); y += 20;

            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNotes.Multiline = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Location = new System.Drawing.Point(16, y); this.txtNotes.Size = new System.Drawing.Size(285, 55); y += 65;

            // Confirm Booking
            this.btnConfirmBooking.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBooking.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmBooking.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBooking.Location = new System.Drawing.Point(16, y);
            this.btnConfirmBooking.Size = new System.Drawing.Size(165, 36);
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.FlatAppearance.BorderSize = 0;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);

            this.btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(186, y);
            this.btnCancelBooking.Size = new System.Drawing.Size(55, 36);
            this.btnCancelBooking.Text = "Cancel";
            this.btnCancelBooking.FlatAppearance.BorderSize = 0;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);

            this.btnClearBooking.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClearBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearBooking.ForeColor = System.Drawing.Color.White;
            this.btnClearBooking.Location = new System.Drawing.Point(246, y);
            this.btnClearBooking.Size = new System.Drawing.Size(55, 36);
            this.btnClearBooking.Text = "Clear";
            this.btnClearBooking.FlatAppearance.BorderSize = 0;
            this.btnClearBooking.Click += new System.EventHandler(this.btnClearBooking_Click);

            this.pnlBooking.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBookingTitle,
                this.lblPatientLbl, this.cmbPatient,
                this.lblDoctorLbl, this.cmbDoctor,
                this.lblDateLbl, this.dtpAppointmentDate,
                this.lblTimeLbl, this.cmbTimeSlot,
                this.lblStatusBookLbl, this.cmbStatus,
                this.lblNotesLbl, this.txtNotes,
                this.btnConfirmBooking, this.btnCancelBooking, this.btnClearBooking
            });

            // FrmAppointments
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1200, 580);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.pnlBooking);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmAppointments";
            this.Text = "Appointments Management";
            this.Load += new System.EventHandler(this.FrmAppointments_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.pnlBooking.ResumeLayout(false);
            this.pnlBooking.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSearchLbl;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatusLbl;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnCancelSelected;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCount;

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;

        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.Label lblBookingTitle;
        private System.Windows.Forms.Label lblPatientLbl;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDoctorLbl;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblDateLbl;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblTimeLbl;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.Label lblStatusBookLbl;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblNotesLbl;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnClearBooking;
    }
}
