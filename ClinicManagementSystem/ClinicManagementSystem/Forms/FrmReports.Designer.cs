namespace ClinicManagementSystem.Forms
{
    partial class FrmReports
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

            // ── Declarations ──────────────────────────────────────────────────
            this.pnlTop             = new System.Windows.Forms.Panel();
            this.lblPageTitle       = new System.Windows.Forms.Label();
            this.lblFromLbl         = new System.Windows.Forms.Label();
            this.dtpFrom            = new System.Windows.Forms.DateTimePicker();
            this.lblToLbl           = new System.Windows.Forms.Label();
            this.dtpTo              = new System.Windows.Forms.DateTimePicker();
            this.lblReportTypeLbl   = new System.Windows.Forms.Label();
            this.cmbReportType      = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport  = new System.Windows.Forms.Button();
            this.btnExport          = new System.Windows.Forms.Button();

            this.pnlKPICards        = new System.Windows.Forms.Panel();
            this.pnlKpiAppt         = new System.Windows.Forms.Panel();
            this.lblKpiApptIcon     = new System.Windows.Forms.Label();
            this.lblKpiApptTitle    = new System.Windows.Forms.Label();
            this.lblKpiApptValue    = new System.Windows.Forms.Label();
            this.pnlKpiRevenue      = new System.Windows.Forms.Panel();
            this.lblKpiRevIcon      = new System.Windows.Forms.Label();
            this.lblKpiRevTitle     = new System.Windows.Forms.Label();
            this.lblKpiRevenueValue = new System.Windows.Forms.Label();
            this.pnlKpiSpec         = new System.Windows.Forms.Panel();
            this.lblKpiSpecIcon     = new System.Windows.Forms.Label();
            this.lblKpiSpecTitle    = new System.Windows.Forms.Label();
            this.lblKpiSpecValue    = new System.Windows.Forms.Label();
            this.pnlKpiAttend       = new System.Windows.Forms.Panel();
            this.lblKpiAttendIcon   = new System.Windows.Forms.Label();
            this.lblKpiAttendTitle  = new System.Windows.Forms.Label();
            this.lblKpiAttendValue  = new System.Windows.Forms.Label();

            this.pnlContent         = new System.Windows.Forms.Panel();
            this.pnlChartCanvas     = new System.Windows.Forms.Panel();
            this.lblChartTitle      = new System.Windows.Forms.Label();

            this.dgvReport          = new System.Windows.Forms.DataGridView();
            this.colRptDoctor       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRptSpecialty    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRptAppts        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRptRevenue      = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlTop.SuspendLayout();
            this.pnlKPICards.SuspendLayout();
            this.pnlKpiAppt.SuspendLayout();
            this.pnlKpiRevenue.SuspendLayout();
            this.pnlKpiSpec.SuspendLayout();
            this.pnlKpiAttend.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();

            // ── pnlTop ────────────────────────────────────────────────────────
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 70;
            this.pnlTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPageTitle, this.lblFromLbl, this.dtpFrom,
                this.lblToLbl, this.dtpTo, this.lblReportTypeLbl,
                this.cmbReportType, this.btnGenerateReport, this.btnExport
            });

            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPageTitle.Location = new System.Drawing.Point(12, 20);
            this.lblPageTitle.Text = "📈 Reports & Clinic Statistics";

            this.lblFromLbl.AutoSize = true;
            this.lblFromLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFromLbl.ForeColor = System.Drawing.Color.Gray;
            this.lblFromLbl.Location = new System.Drawing.Point(310, 8);
            this.lblFromLbl.Text = "From:";

            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(312, 26);
            this.dtpFrom.Size = new System.Drawing.Size(105, 25);
            this.dtpFrom.Value = System.DateTime.Today.AddMonths(-1);

            this.lblToLbl.AutoSize = true;
            this.lblToLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblToLbl.ForeColor = System.Drawing.Color.Gray;
            this.lblToLbl.Location = new System.Drawing.Point(424, 8);
            this.lblToLbl.Text = "To:";

            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(426, 26);
            this.dtpTo.Size = new System.Drawing.Size(105, 25);
            this.dtpTo.Value = System.DateTime.Today;

            this.lblReportTypeLbl.AutoSize = true;
            this.lblReportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblReportTypeLbl.ForeColor = System.Drawing.Color.Gray;
            this.lblReportTypeLbl.Location = new System.Drawing.Point(540, 8);
            this.lblReportTypeLbl.Text = "Report Type:";

            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbReportType.Items.AddRange(new object[] {
                "Appointments by Specialty", "Daily Revenue (EGP)",
                "Doctor Workload", "Cancellation Rate"
            });
            this.cmbReportType.Location = new System.Drawing.Point(542, 26);
            this.cmbReportType.Size = new System.Drawing.Size(185, 25);

            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(735, 24);
            this.btnGenerateReport.Size = new System.Drawing.Size(140, 29);
            this.btnGenerateReport.Text = "📊 Generate Report";
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);

            this.btnExport.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(882, 24);
            this.btnExport.Size = new System.Drawing.Size(145, 29);
            this.btnExport.Text = "📄 Export / Print Summary";
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // ── KPI Cards Row ─────────────────────────────────────────────────
            this.pnlKPICards.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlKPICards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKPICards.Height = 90;
            this.pnlKPICards.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlKPICards.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlKpiAppt, this.pnlKpiRevenue, this.pnlKpiSpec, this.pnlKpiAttend
            });

            // Helper: build one KPI card
            System.Action<System.Windows.Forms.Panel, System.Windows.Forms.Label, System.Windows.Forms.Label, System.Windows.Forms.Label,
                          string, string, string, System.Drawing.Color, int> buildCard =
            (panel, iconLbl, titleLbl, valLbl, icon, title, val, valColor, xPos) =>
            {
                panel.BackColor = System.Drawing.Color.White;
                panel.Location = new System.Drawing.Point(xPos, 10);
                panel.Size = new System.Drawing.Size(220, 68);

                iconLbl.Font = new System.Drawing.Font("Segoe UI", 20F);
                iconLbl.Location = new System.Drawing.Point(10, 8);
                iconLbl.Size = new System.Drawing.Size(45, 40);
                iconLbl.Text = icon;

                titleLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
                titleLbl.ForeColor = System.Drawing.Color.Gray;
                titleLbl.Location = new System.Drawing.Point(60, 8);
                titleLbl.Size = new System.Drawing.Size(155, 18);
                titleLbl.Text = title;

                valLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
                valLbl.ForeColor = valColor;
                valLbl.Location = new System.Drawing.Point(60, 28);
                valLbl.Size = new System.Drawing.Size(155, 32);
                valLbl.Text = val;

                panel.Controls.AddRange(new System.Windows.Forms.Control[] { iconLbl, titleLbl, valLbl });
            };

            buildCard(this.pnlKpiAppt,     this.lblKpiApptIcon,  this.lblKpiApptTitle,  this.lblKpiApptValue,
                      "📅", "TOTAL APPTS (THIS MONTH)", "148",         System.Drawing.Color.FromArgb(22, 160, 133),  16);
            buildCard(this.pnlKpiRevenue,  this.lblKpiRevIcon,   this.lblKpiRevTitle,   this.lblKpiRevenueValue,
                      "💰", "TOTAL CLINIC REVENUE",    "62,500 EGP",  System.Drawing.Color.FromArgb(39, 174, 96),   252);
            buildCard(this.pnlKpiSpec,     this.lblKpiSpecIcon,  this.lblKpiSpecTitle,  this.lblKpiSpecValue,
                      "🏆", "MOST VISITED SPECIALTY",  "Cardiology",  System.Drawing.Color.FromArgb(142, 68, 173),  488);
            buildCard(this.pnlKpiAttend,   this.lblKpiAttendIcon, this.lblKpiAttendTitle, this.lblKpiAttendValue,
                      "📊", "ATTENDANCE RATE",         "89%",         System.Drawing.Color.FromArgb(41, 128, 185),  724);

            // ── Content Panel (chart + grid side by side) ─────────────────────
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlContent.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlChartCanvas, this.dgvReport
            });

            // Chart Panel
            this.pnlChartCanvas.BackColor = System.Drawing.Color.White;
            this.pnlChartCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Bottom));
            this.pnlChartCanvas.Location = new System.Drawing.Point(12, 8);
            this.pnlChartCanvas.Size = new System.Drawing.Size(590, 350);
            this.pnlChartCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChartCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChartCanvas_Paint);

            // Report DataGridView
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Bottom));
            this.dgvReport.Location = new System.Drawing.Point(614, 8);
            this.dgvReport.Size = new System.Drawing.Size(555, 350);

            hdrStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            hdrStyle.ForeColor = System.Drawing.Color.White;
            hdrStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvReport.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.dgvReport.ColumnHeadersHeight = 36;
            this.dgvReport.EnableHeadersVisualStyles = false;

            altStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 252);
            this.dgvReport.AlternatingRowsDefaultCellStyle = altStyle;
            this.dgvReport.RowTemplate.Height = 30;

            this.colRptDoctor.Name = "colRptDoctor";     this.colRptDoctor.HeaderText = "Doctor Name";   this.colRptDoctor.FillWeight = 140;
            this.colRptSpecialty.Name = "colRptSpecialty"; this.colRptSpecialty.HeaderText = "Specialty"; this.colRptSpecialty.FillWeight = 120;
            this.colRptAppts.Name = "colRptAppts";       this.colRptAppts.HeaderText = "Appointments";   this.colRptAppts.FillWeight = 85;
            this.colRptRevenue.Name = "colRptRevenue";   this.colRptRevenue.HeaderText = "Total Revenue"; this.colRptRevenue.FillWeight = 100;

            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colRptDoctor, this.colRptSpecialty, this.colRptAppts, this.colRptRevenue
            });

            // ── FrmReports ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1200, 580);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlKPICards);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmReports";
            this.Text = "Reports & Statistics";
            this.Load += new System.EventHandler(this.FrmReports_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlKPICards.ResumeLayout(false);
            this.pnlKpiAppt.ResumeLayout(false);
            this.pnlKpiRevenue.ResumeLayout(false);
            this.pnlKpiSpec.ResumeLayout(false);
            this.pnlKpiAttend.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Control Declarations ──────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblFromLbl;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblToLbl;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblReportTypeLbl;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExport;

        private System.Windows.Forms.Panel pnlKPICards;
        private System.Windows.Forms.Panel pnlKpiAppt;
        private System.Windows.Forms.Label lblKpiApptIcon;
        private System.Windows.Forms.Label lblKpiApptTitle;
        private System.Windows.Forms.Label lblKpiApptValue;
        private System.Windows.Forms.Panel pnlKpiRevenue;
        private System.Windows.Forms.Label lblKpiRevIcon;
        private System.Windows.Forms.Label lblKpiRevTitle;
        private System.Windows.Forms.Label lblKpiRevenueValue;
        private System.Windows.Forms.Panel pnlKpiSpec;
        private System.Windows.Forms.Label lblKpiSpecIcon;
        private System.Windows.Forms.Label lblKpiSpecTitle;
        private System.Windows.Forms.Label lblKpiSpecValue;
        private System.Windows.Forms.Panel pnlKpiAttend;
        private System.Windows.Forms.Label lblKpiAttendIcon;
        private System.Windows.Forms.Label lblKpiAttendTitle;
        private System.Windows.Forms.Label lblKpiAttendValue;

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlChartCanvas;
        private System.Windows.Forms.Label lblChartTitle;

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRptDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRptSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRptAppts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRptRevenue;
    }
}
