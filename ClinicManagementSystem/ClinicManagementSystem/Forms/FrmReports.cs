using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = 0;
            LoadKPICards();
            LoadSampleReportData();
            pnlChartCanvas.Invalidate();
        }

        // ── KPI Cards ─────────────────────────────────────────────────────────
        private void LoadKPICards()
        {
            lblKpiApptValue.Text     = "148";
            lblKpiRevenueValue.Text  = "62,500 EGP";
            lblKpiSpecValue.Text     = "Cardiology";
            lblKpiAttendValue.Text   = "89%";
        }

        // ── Sample Report Table ───────────────────────────────────────────────
        private void LoadSampleReportData()
        {
            dgvReport.Rows.Clear();
            dgvReport.Rows.Add("Dr. Tarek El-Gendy",   "Cardiology",        "38 Appts", "19,000 EGP");
            dgvReport.Rows.Add("Dr. Mona Abdel-Aziz",  "Pediatrics",        "32 Appts", "11,200 EGP");
            dgvReport.Rows.Add("Dr. Youssef Mansour",  "Orthopedics",       "27 Appts", "16,200 EGP");
            dgvReport.Rows.Add("Dr. Heba El-Shazly",   "Dermatology",       "24 Appts",  "9,600 EGP");
            dgvReport.Rows.Add("Dr. Khaled Naguib",    "Internal Medicine", "21 Appts",  "9,450 EGP");
            dgvReport.Rows.Add("Dr. Amira Hassan",     "Neurology",         "6 Appts",   "3,000 EGP");
        }

        // ── GDI+ Bar Chart ────────────────────────────────────────────────────
        private void pnlChartCanvas_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle bounds = pnlChartCanvas.ClientRectangle;
            g.Clear(Color.White);

            // Chart title
            using (var titleFont = new Font("Segoe UI", 10F, FontStyle.Bold))
            using (var darkBrush = new SolidBrush(Color.FromArgb(44, 62, 80)))
                g.DrawString("Appointments by Specialty (This Month)", titleFont, darkBrush, 10, 10);

            // Data
            string[] labels = { "Cardiology", "Pediatrics", "Orthopedics", "Dermatology", "Internal Med.", "Neurology" };
            int[]    values = { 38, 32, 27, 24, 21, 6 };
            Color[]  colors = {
                Color.FromArgb(22, 160, 133), Color.FromArgb(41, 128, 185),
                Color.FromArgb(142, 68, 173), Color.FromArgb(230, 126, 34),
                Color.FromArgb(39, 174, 96),  Color.FromArgb(192, 57, 43)
            };

            int maxVal    = 45;
            int chartLeft = 20;
            int chartTop  = 40;
            int chartH    = bounds.Height - 80;
            int barW      = 48;
            int gap       = 20;
            int totalW    = labels.Length * (barW + gap);

            // Y-axis grid lines
            using (var gridPen = new System.Drawing.Pen(Color.FromArgb(220, 220, 220), 1))
            using (var grayFont = new Font("Segoe UI", 7F))
            using (var grayBrush = new SolidBrush(Color.Gray))
            {
                for (int v = 0; v <= maxVal; v += 10)
                {
                    int yGrid = chartTop + chartH - (int)((double)v / maxVal * chartH);
                    g.DrawLine(gridPen, chartLeft, yGrid, chartLeft + totalW + 20, yGrid);
                    g.DrawString(v.ToString(), grayFont, grayBrush, chartLeft - 20, yGrid - 7);
                }
            }

            // Bars + labels
            for (int i = 0; i < labels.Length; i++)
            {
                int barH   = (int)((double)values[i] / maxVal * chartH);
                int barX   = chartLeft + i * (barW + gap);
                int barY   = chartTop + chartH - barH;

                // Shadow
                using (var shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                    g.FillRectangle(shadowBrush, barX + 2, barY + 2, barW, barH);

                // Bar
                using (var barBrush = new SolidBrush(colors[i]))
                    g.FillRectangle(barBrush, barX, barY, barW, barH);

                // Value text on bar
                using (var valFont = new Font("Segoe UI", 8.5F, FontStyle.Bold))
                using (var wBrush  = new SolidBrush(Color.White))
                {
                    if (barH > 20)
                        g.DrawString(values[i].ToString(), valFont, wBrush,
                            new RectangleF(barX, barY + 4, barW, 20),
                            new StringFormat { Alignment = StringAlignment.Center });
                }

                // X-axis label
                using (var lblFont = new Font("Segoe UI", 7.5F))
                using (var darkBrush = new SolidBrush(Color.FromArgb(44, 62, 80)))
                {
                    g.DrawString(labels[i], lblFont, darkBrush,
                        new RectangleF(barX - 5, chartTop + chartH + 5, barW + 10, 30),
                        new StringFormat { Alignment = StringAlignment.Center });
                }
            }

            // Axis lines
            using (var axisPen = new System.Drawing.Pen(Color.FromArgb(100, 100, 100), 1.5F))
            {
                g.DrawLine(axisPen, chartLeft, chartTop, chartLeft, chartTop + chartH);
                g.DrawLine(axisPen, chartLeft, chartTop + chartH, chartLeft + totalW + 20, chartTop + chartH);
            }
        }

        // ── Buttons ───────────────────────────────────────────────────────────
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadSampleReportData();
            pnlChartCanvas.Invalidate();
            MessageBox.Show(
                $"Report Generated!\n\nType    : {cmbReportType.SelectedItem}\nFrom    : {dtpFrom.Value:dd MMM yyyy}\nTo      : {dtpTo.Value:dd MMM yyyy}\n\nData is loaded from mock clinic records.\n[Live DB queries will be active in Phase 2.]",
                "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export / Print Summary feature will be fully implemented in Phase 2 (file I/O + PDF/CSV export).\n\nGUI preview is complete for the design stage submission.",
                "Export (GUI Preview)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
