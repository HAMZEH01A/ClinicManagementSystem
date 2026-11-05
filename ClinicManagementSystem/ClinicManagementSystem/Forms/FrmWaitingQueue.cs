using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms
{
    public partial class FrmWaitingQueue : Form
    {
        public FrmWaitingQueue()
        {
            InitializeComponent();
        }

        private void FrmWaitingQueue_Load(object sender, EventArgs e)
        {
            LoadSampleQueue();
            RenderTicketPreview("A-101", "Mohamed Ramadan Farouq", "Dr. Tarek El-Gendy", "Room 2");
        }

        private void LoadSampleQueue()
        {
            dgvWaitingQueue.Rows.Clear();
            dgvWaitingQueue.Rows.Add("A-101", "Mohamed Ramadan Farouq",  "Dr. Tarek El-Gendy",   "08:52 AM", "~5 min",  "In Room");
            dgvWaitingQueue.Rows.Add("A-102", "Fatma Ibrahim Khalil",    "Dr. Mona Abdel-Aziz",  "09:05 AM", "~10 min", "Waiting");
            dgvWaitingQueue.Rows.Add("A-103", "Ahmed Hassan El-Sayed",   "Dr. Youssef Mansour",  "09:12 AM", "~20 min", "Waiting");
            dgvWaitingQueue.Rows.Add("A-104", "Nour El-Din Abdallah",    "Dr. Heba El-Shazly",   "09:18 AM", "~30 min", "Waiting");
            dgvWaitingQueue.Rows.Add("A-105", "Sara Mahmoud El-Hefny",   "Dr. Khaled Naguib",    "09:25 AM", "~40 min", "Waiting");
            dgvWaitingQueue.Rows.Add("A-098", "Walid Nasser El-Din",     "Dr. Amira Hassan",     "08:15 AM", "Done",    "Completed");
            dgvWaitingQueue.Rows.Add("A-099", "Rania Adel Hassan",       "Dr. Samy El-Sherif",   "08:30 AM", "Done",    "Completed");
            dgvWaitingQueue.Rows.Add("A-100", "Omar Fathy Ibrahim",      "Dr. Tarek El-Gendy",   "08:42 AM", "Done",    "Completed");
        }

        private void RenderTicketPreview(string ticketNo, string patient, string doctor, string room)
        {
            _ticketNo  = ticketNo;
            _patient   = patient;
            _doctor    = doctor;
            _room      = room;
            pnlTicketPreview.Invalidate();
        }

        private string _ticketNo = "A-101";
        private string _patient  = "Mohamed Ramadan Farouq";
        private string _doctor   = "Dr. Tarek El-Gendy";
        private string _room     = "Room 2";

        private void pnlTicketPreview_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle bounds = pnlTicketPreview.ClientRectangle;
            int pw = bounds.Width - 20;
            int ph = bounds.Height - 20;
            int px = 10, py = 10;

            // Ticket background
            using (var bgBrush = new SolidBrush(Color.White))
                g.FillRectangle(bgBrush, px, py, pw, ph);

            // Ticket border
            using (var borderPen = new System.Drawing.Pen(Color.FromArgb(22, 160, 133), 2))
                g.DrawRectangle(borderPen, px, py, pw, ph);

            // Header strip
            using (var headerBrush = new SolidBrush(Color.FromArgb(22, 160, 133)))
                g.FillRectangle(headerBrush, px + 2, py + 2, pw - 4, 40);

            // Header text
            using (var hFont = new Font("Segoe UI", 10F, FontStyle.Bold))
            using (var wBrush = new SolidBrush(Color.White))
            {
                g.DrawString("DOCTOR APPOINTMENT SYSTEM", hFont, wBrush,
                    new RectangleF(px + 2, py + 2, pw - 4, 40),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }

            // Dashed separator
            using (var dashPen = new System.Drawing.Pen(Color.FromArgb(200, 200, 200), 1))
            {
                dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(dashPen, px + 10, py + 50, px + pw - 10, py + 50);
            }

            // Ticket number
            using (var numFont = new Font("Segoe UI", 36F, FontStyle.Bold))
            using (var numBrush = new SolidBrush(Color.FromArgb(22, 160, 133)))
            {
                g.DrawString(_ticketNo, numFont, numBrush,
                    new RectangleF(px, py + 55, pw, 60),
                    new StringFormat { Alignment = StringAlignment.Center });
            }

            // Queue Ticket label
            using (var lblFont = new Font("Segoe UI", 8F))
            using (var grayBrush = new SolidBrush(Color.Gray))
            {
                g.DrawString("QUEUE TICKET", lblFont, grayBrush,
                    new RectangleF(px, py + 115, pw, 20),
                    new StringFormat { Alignment = StringAlignment.Center });
            }

            // Dashed separator 2
            using (var dashPen = new System.Drawing.Pen(Color.FromArgb(200, 200, 200), 1))
            {
                dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(dashPen, px + 10, py + 140, px + pw - 10, py + 140);
            }

            // Patient / Doctor details
            int infoY = py + 150;
            DrawTicketRow(g, "Patient :", _patient, px + 15, infoY); infoY += 28;
            DrawTicketRow(g, "Doctor  :", _doctor,  px + 15, infoY); infoY += 28;
            DrawTicketRow(g, "Room    :", _room,    px + 15, infoY); infoY += 28;
            DrawTicketRow(g, "Date    :", DateTime.Now.ToString("dd MMM yyyy  hh:mm tt"), px + 15, infoY);

            // Dashed separator 3
            using (var dashPen = new System.Drawing.Pen(Color.FromArgb(200, 200, 200), 1))
            {
                dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(dashPen, px + 10, py + ph - 42, px + pw - 10, py + ph - 42);
            }

            // Footer
            using (var fFont = new Font("Segoe UI", 7.5F, FontStyle.Italic))
            using (var grayBrush = new SolidBrush(Color.Gray))
            {
                g.DrawString("Please wait for your ticket number to be called.", fFont, grayBrush,
                    new RectangleF(px, py + ph - 36, pw, 30),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void DrawTicketRow(Graphics g, string label, string value, int x, int y)
        {
            using (var labelFont = new Font("Segoe UI", 8.5F, FontStyle.Bold))
            using (var valueFont = new Font("Segoe UI", 8.5F))
            using (var darkBrush = new SolidBrush(Color.FromArgb(44, 62, 80)))
            {
                g.DrawString(label, labelFont, darkBrush, x, y);
                g.DrawString(value, valueFont, darkBrush, x + 68, y);
            }
        }

        private void dgvWaitingQueue_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWaitingQueue.CurrentRow == null || dgvWaitingQueue.CurrentRow.Index < 0) return;
            DataGridViewRow row = dgvWaitingQueue.CurrentRow;

            string ticket  = row.Cells["colTicket"].Value?.ToString()  ?? "A-100";
            string patient = row.Cells["colPatient"].Value?.ToString()  ?? "";
            string doctor  = row.Cells["colDoctor"].Value?.ToString()   ?? "";
            RenderTicketPreview(ticket, patient, doctor, "Room 2");
        }

        private void btnCallNext_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWaitingQueue.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["colQueueStatus"].Value?.ToString() == "Waiting")
                {
                    string ticket  = row.Cells["colTicket"].Value?.ToString()  ?? "";
                    string patient = row.Cells["colPatient"].Value?.ToString()  ?? "";
                    MessageBox.Show($"Calling patient: {patient}\nTicket: {ticket}\n\nPlease proceed to the consultation room.",
                        "Next Patient Called", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    row.Cells["colQueueStatus"].Value = "In Room";
                    string doctor = row.Cells["colDoctor"].Value?.ToString() ?? "";
                    RenderTicketPreview(ticket, patient, doctor, "Room 2");
                    lblInConsultation.Text = $"In Consultation: {patient}";
                    return;
                }
            }
            MessageBox.Show("No more waiting patients in the queue.", "Queue Empty",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMarkInRoom_Click(object sender, EventArgs e)
        {
            if (dgvWaitingQueue.CurrentRow == null) return;
            dgvWaitingQueue.CurrentRow.Cells["colQueueStatus"].Value = "In Room";
            UpdateSummaryCards();
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (dgvWaitingQueue.CurrentRow == null) return;
            dgvWaitingQueue.CurrentRow.Cells["colQueueStatus"].Value = "Completed";
            UpdateSummaryCards();
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            if (dgvWaitingQueue.CurrentRow == null)
            {
                MessageBox.Show("Please select a row first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string doc = dgvWaitingQueue.CurrentRow.Cells["colDoctor"].Value?.ToString() ?? "Doctor";
            MessageBox.Show($"Notification dispatched to {doc}'s workstation.",
                "Notification Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateSummaryCards()
        {
            int waiting = 0, inRoom = 0, completed = 0;
            foreach (DataGridViewRow row in dgvWaitingQueue.Rows)
            {
                if (row.IsNewRow) continue;
                string s = row.Cells["colQueueStatus"].Value?.ToString() ?? "";
                if (s == "Waiting")   waiting++;
                if (s == "In Room")   inRoom++;
                if (s == "Completed") completed++;
            }
            lblWaitingCount.Text    = $"{waiting} Patients";
            lblCompletedCount.Text  = $"{completed} Patients";
        }
    }
}
