using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms
{
    public partial class FrmAppointments : Form
    {
        public FrmAppointments()
        {
            InitializeComponent();
        }

        private void FrmAppointments_Load(object sender, EventArgs e)
        {
            LoadSampleData();
        }

        // ── Sample Data ───────────────────────────────────────────────────────
        private void LoadSampleData()
        {
            dgvAppointments.Rows.Clear();
            dgvAppointments.Rows.Add("APT-001", "Ahmed Hassan El-Sayed",    "Dr. Tarek El-Gendy",     "Cardiology",        "2026-11-05", "09:00 AM", "Completed",  "500 EGP");
            dgvAppointments.Rows.Add("APT-002", "Fatma Ibrahim Khalil",     "Dr. Mona Abdel-Aziz",   "Pediatrics",        "2026-11-05", "09:30 AM", "Scheduled",  "350 EGP");
            dgvAppointments.Rows.Add("APT-003", "Mohamed Ramadan Farouq",  "Dr. Youssef Mansour",   "Orthopedics",       "2026-11-05", "10:00 AM", "Waiting",    "600 EGP");
            dgvAppointments.Rows.Add("APT-004", "Nour El-Din Abdallah",    "Dr. Heba El-Shazly",    "Dermatology",       "2026-11-05", "11:00 AM", "Scheduled",  "400 EGP");
            dgvAppointments.Rows.Add("APT-005", "Sara Mahmoud El-Hefny",   "Dr. Khaled Naguib",     "Internal Medicine", "2026-11-06", "01:00 PM", "Cancelled",  "450 EGP");
            dgvAppointments.Rows.Add("APT-006", "Khaled Mostafa El-Attar", "Dr. Tarek El-Gendy",     "Cardiology",        "2026-11-06", "02:30 PM", "Scheduled",  "500 EGP");
            lblCount.Text = "Total Appointments: 6";
        }

        // ── Filter / Search ───────────────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dtpFilterDate_ValueChanged(object sender, EventArgs e)
        {
            if (chkFilterDate.Checked) ApplyFilter();
        }

        private void chkFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilterDate.Enabled = chkFilterDate.Checked;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string keyword    = txtSearch.Text.Trim().ToLower();
            string statusFilt = cmbFilterStatus.SelectedIndex > 0
                ? cmbFilterStatus.SelectedItem.ToString().ToLower() : "";
            string dateFilt   = chkFilterDate.Checked
                ? dtpFilterDate.Value.ToString("yyyy-MM-dd") : "";

            int visible = 0;
            foreach (DataGridViewRow row in dgvAppointments.Rows)
            {
                if (row.IsNewRow) continue;
                bool show = true;

                if (!string.IsNullOrEmpty(keyword))
                {
                    string patient = row.Cells["colPatientName"].Value?.ToString().ToLower() ?? "";
                    string doctor  = row.Cells["colDoctorName"].Value?.ToString().ToLower() ?? "";
                    if (!patient.Contains(keyword) && !doctor.Contains(keyword))
                        show = false;
                }
                if (show && !string.IsNullOrEmpty(statusFilt))
                {
                    string status = row.Cells["colStatus"].Value?.ToString().ToLower() ?? "";
                    if (!status.Contains(statusFilt)) show = false;
                }
                if (show && !string.IsNullOrEmpty(dateFilt))
                {
                    string date = row.Cells["colDate"].Value?.ToString() ?? "";
                    if (!date.Contains(dateFilt)) show = false;
                }
                row.Visible = show;
                if (show) visible++;
            }
            lblCount.Text = $"Total Appointments: {visible}";
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterStatus.SelectedIndex = 0;
            chkFilterDate.Checked = false;
            dtpFilterDate.Value = DateTime.Today;
            LoadSampleData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSampleData();
        }

        // ── Grid Selection ────────────────────────────────────────────────────
        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null || dgvAppointments.CurrentRow.Index < 0)
                return;

            DataGridViewRow row = dgvAppointments.CurrentRow;

            // Populate booking panel with selected row
            string patientName = row.Cells["colPatientName"].Value?.ToString() ?? "";
            int pIdx = cmbPatient.FindStringExact(patientName);
            if (pIdx >= 0) cmbPatient.SelectedIndex = pIdx;

            string docName = row.Cells["colDoctorName"].Value?.ToString() ?? "";
            int dIdx = cmbDoctor.FindStringExact(docName);
            if (dIdx >= 0) cmbDoctor.SelectedIndex = dIdx;

            if (DateTime.TryParse(row.Cells["colDate"].Value?.ToString(), out DateTime d))
                dtpAppointmentDate.Value = d;

            string slot = row.Cells["colTimeSlot"].Value?.ToString() ?? "";
            int sIdx = cmbTimeSlot.FindStringExact(slot);
            if (sIdx >= 0) cmbTimeSlot.SelectedIndex = sIdx;

            string status = row.Cells["colStatus"].Value?.ToString() ?? "";
            int stIdx = cmbStatus.FindStringExact(status);
            if (stIdx >= 0) cmbStatus.SelectedIndex = stIdx;

            lblBookingTitle.Text = "✏ Edit Appointment";
            btnConfirmBooking.Text = "Update Appointment";
        }

        // ── Booking Panel Buttons ─────────────────────────────────────────────
        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            ClearBookingPanel();
            lblBookingTitle.Text = "📅 Book New Appointment";
            btnConfirmBooking.Text = "Confirm Booking";
            cmbPatient.Focus();
        }

        private void btnCancelSelected_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;
            var dr = MessageBox.Show("Cancel this appointment?", "Confirm Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                dgvAppointments.CurrentRow.Cells["colStatus"].Value = "Cancelled";
                MessageBox.Show("Appointment marked as Cancelled.", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedIndex < 0 || cmbDoctor.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Patient and a Doctor.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(
                $"Appointment booked!\n\nPatient : {cmbPatient.SelectedItem}\nDoctor  : {cmbDoctor.SelectedItem}\nDate    : {dtpAppointmentDate.Value:yyyy-MM-dd}\nSlot    : {cmbTimeSlot.SelectedItem}\nStatus  : {cmbStatus.SelectedItem}",
                "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearBookingPanel();
            LoadSampleData();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            ClearBookingPanel();
        }

        private void btnClearBooking_Click(object sender, EventArgs e)
        {
            ClearBookingPanel();
        }

        private void ClearBookingPanel()
        {
            cmbPatient.SelectedIndex = -1;
            cmbDoctor.SelectedIndex  = -1;
            dtpAppointmentDate.Value = DateTime.Today;
            cmbTimeSlot.SelectedIndex = 0;
            cmbStatus.SelectedIndex   = 0;
            txtNotes.Clear();
            lblBookingTitle.Text = "📅 Book / Edit Appointment";
            btnConfirmBooking.Text = "Confirm Booking";
            dgvAppointments.ClearSelection();
        }
    }
}
