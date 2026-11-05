namespace ClinicManagementSystem.Forms
{
    partial class FrmWaitingQueue
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

            this.pnlSummaryCards    = new System.Windows.Forms.Panel();
            this.pnlCardWaiting     = new System.Windows.Forms.Panel();
            this.lblWaitingIcon     = new System.Windows.Forms.Label();
            this.lblWaitingTitle    = new System.Windows.Forms.Label();
            this.lblWaitingCount    = new System.Windows.Forms.Label();
            this.pnlCardInConsult   = new System.Windows.Forms.Panel();
            this.lblConsultIcon     = new System.Windows.Forms.Label();
            this.lblConsultTitle    = new System.Windows.Forms.Label();
            this.lblInConsultation  = new System.Windows.Forms.Label();
            this.pnlCardCompleted   = new System.Windows.Forms.Panel();
            this.lblCompletedIcon   = new System.Windows.Forms.Label();
            this.lblCompletedTitle  = new System.Windows.Forms.Label();
            this.lblCompletedCount  = new System.Windows.Forms.Label();

            this.pnlTop             = new System.Windows.Forms.Panel();
            this.lblPageTitle       = new System.Windows.Forms.Label();
            this.btnCallNext        = new System.Windows.Forms.Button();
            this.btnMarkInRoom      = new System.Windows.Forms.Button();
            this.btnMarkCompleted   = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();

            this.dgvWaitingQueue    = new System.Windows.Forms.DataGridView();
            this.colTicket          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrivalTime     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstWait         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQueueStatus     = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlRight           = new System.Windows.Forms.Panel();
            this.lblTicketHeader    = new System.Windows.Forms.Label();
            this.pnlTicketPreview   = new System.Windows.Forms.Panel();

            this.pnlSummaryCards.SuspendLayout();
            this.pnlCardWaiting.SuspendLayout();
            this.pnlCardInConsult.SuspendLayout();
            this.pnlCardCompleted.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingQueue)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // Summary Cards Panel
            this.pnlSummaryCards.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlSummaryCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummaryCards.Height = 95;
            this.pnlSummaryCards.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlSummaryCards.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlCardWaiting, this.pnlCardInConsult, this.pnlCardCompleted
            });

            // Card: Currently Waiting
            this.pnlCardWaiting.BackColor = System.Drawing.Color.White;
            this.pnlCardWaiting.Location = new System.Drawing.Point(16, 10);
            this.pnlCardWaiting.Size = new System.Drawing.Size(220, 72);
            this.pnlCardWaiting.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblWaitingIcon, this.lblWaitingTitle, this.lblWaitingCount
            });

            this.lblWaitingIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWaitingIcon.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblWaitingIcon.Location = new System.Drawing.Point(10, 15);
            this.lblWaitingIcon.Size = new System.Drawing.Size(45, 40);
            this.lblWaitingIcon.Text = "WAIT";

            this.lblWaitingTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblWaitingTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblWaitingTitle.Location = new System.Drawing.Point(60, 10);
            this.lblWaitingTitle.Size = new System.Drawing.Size(150, 18);
            this.lblWaitingTitle.Text = "CURRENTLY WAITING";

            this.lblWaitingCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWaitingCount.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblWaitingCount.Location = new System.Drawing.Point(60, 30);
            this.lblWaitingCount.Size = new System.Drawing.Size(150, 30);
            this.lblWaitingCount.Text = "4 Patients";

            // Card: In Consultation
            this.pnlCardInConsult.BackColor = System.Drawing.Color.White;
            this.pnlCardInConsult.Location = new System.Drawing.Point(252, 10);
            this.pnlCardInConsult.Size = new System.Drawing.Size(290, 72);
            this.pnlCardInConsult.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblConsultIcon, this.lblConsultTitle, this.lblInConsultation
            });

            this.lblConsultIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblConsultIcon.ForeColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.lblConsultIcon.Location = new System.Drawing.Point(10, 15);
            this.lblConsultIcon.Size = new System.Drawing.Size(45, 40);
            this.lblConsultIcon.Text = "DOC";

            this.lblConsultTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblConsultTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblConsultTitle.Location = new System.Drawing.Point(60, 10);
            this.lblConsultTitle.Size = new System.Drawing.Size(220, 18);
            this.lblConsultTitle.Text = "IN CONSULTATION";

            this.lblInConsultation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInConsultation.ForeColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.lblInConsultation.Location = new System.Drawing.Point(60, 30);
            this.lblInConsultation.Size = new System.Drawing.Size(220, 30);
            this.lblInConsultation.Text = "Dr. Tarek El-Gendy - Room 2";

            // Card: Completed Today
            this.pnlCardCompleted.BackColor = System.Drawing.Color.White;
            this.pnlCardCompleted.Location = new System.Drawing.Point(558, 10);
            this.pnlCardCompleted.Size = new System.Drawing.Size(220, 72);
            this.pnlCardCompleted.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCompletedIcon, this.lblCompletedTitle, this.lblCompletedCount
            });

            this.lblCompletedIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompletedIcon.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblCompletedIcon.Location = new System.Drawing.Point(10, 15);
            this.lblCompletedIcon.Size = new System.Drawing.Size(45, 40);
            this.lblCompletedIcon.Text = "DONE";

            this.lblCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCompletedTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblCompletedTitle.Location = new System.Drawing.Point(60, 10);
            this.lblCompletedTitle.Size = new System.Drawing.Size(150, 18);
            this.lblCompletedTitle.Text = "COMPLETED TODAY";

            this.lblCompletedCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCompletedCount.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblCompletedCount.Location = new System.Drawing.Point(60, 30);
            this.lblCompletedCount.Size = new System.Drawing.Size(150, 30);
            this.lblCompletedCount.Text = "12 Patients";

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 60;
            this.pnlTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPageTitle, this.btnCallNext, this.btnMarkInRoom,
                this.btnMarkCompleted, this.btnSendNotification
            });

            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPageTitle.Location = new System.Drawing.Point(12, 18);
            this.lblPageTitle.Text = "Live Waiting Room Queue";

            this.btnCallNext.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnCallNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCallNext.ForeColor = System.Drawing.Color.White;
            this.btnCallNext.Location = new System.Drawing.Point(310, 15);
            this.btnCallNext.Size = new System.Drawing.Size(140, 30);
            this.btnCallNext.Text = "Call Next Patient";
            this.btnCallNext.FlatAppearance.BorderSize = 0;
            this.btnCallNext.Click += new System.EventHandler(this.btnCallNext_Click);

            this.btnMarkInRoom.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnMarkInRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkInRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkInRoom.ForeColor = System.Drawing.Color.White;
            this.btnMarkInRoom.Location = new System.Drawing.Point(458, 15);
            this.btnMarkInRoom.Size = new System.Drawing.Size(135, 30);
            this.btnMarkInRoom.Text = "Mark In Consultation";
            this.btnMarkInRoom.FlatAppearance.BorderSize = 0;
            this.btnMarkInRoom.Click += new System.EventHandler(this.btnMarkInRoom_Click);

            this.btnMarkCompleted.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnMarkCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkCompleted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkCompleted.ForeColor = System.Drawing.Color.White;
            this.btnMarkCompleted.Location = new System.Drawing.Point(600, 15);
            this.btnMarkCompleted.Size = new System.Drawing.Size(130, 30);
            this.btnMarkCompleted.Text = "Mark Completed";
            this.btnMarkCompleted.FlatAppearance.BorderSize = 0;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);

            this.btnSendNotification.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnSendNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendNotification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSendNotification.ForeColor = System.Drawing.Color.White;
            this.btnSendNotification.Location = new System.Drawing.Point(737, 15);
            this.btnSendNotification.Size = new System.Drawing.Size(185, 30);
            this.btnSendNotification.Text = "Send Notification to Doctor";
            this.btnSendNotification.FlatAppearance.BorderSize = 0;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);

            // dgvWaitingQueue
            this.dgvWaitingQueue.AllowUserToAddRows = false;
            this.dgvWaitingQueue.AllowUserToDeleteRows = false;
            this.dgvWaitingQueue.ReadOnly = true;
            this.dgvWaitingQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaitingQueue.MultiSelect = false;
            this.dgvWaitingQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWaitingQueue.BackgroundColor = System.Drawing.Color.White;
            this.dgvWaitingQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWaitingQueue.RowHeadersVisible = false;
            this.dgvWaitingQueue.Dock = System.Windows.Forms.DockStyle.Fill;

            hdrStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            hdrStyle.ForeColor = System.Drawing.Color.White;
            hdrStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvWaitingQueue.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.dgvWaitingQueue.ColumnHeadersHeight = 36;
            this.dgvWaitingQueue.EnableHeadersVisualStyles = false;

            altStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 252);
            this.dgvWaitingQueue.AlternatingRowsDefaultCellStyle = altStyle;
            this.dgvWaitingQueue.RowTemplate.Height = 30;
            this.dgvWaitingQueue.SelectionChanged += new System.EventHandler(this.dgvWaitingQueue_SelectionChanged);

            this.colTicket.Name = "colTicket";           this.colTicket.HeaderText = "Ticket #";         this.colTicket.FillWeight = 65;
            this.colPatient.Name = "colPatient";         this.colPatient.HeaderText = "Patient Name";     this.colPatient.FillWeight = 150;
            this.colDoctor.Name = "colDoctor";           this.colDoctor.HeaderText = "Assigned Doctor";   this.colDoctor.FillWeight = 140;
            this.colArrivalTime.Name = "colArrivalTime"; this.colArrivalTime.HeaderText = "Arrival Time";  this.colArrivalTime.FillWeight = 80;
            this.colEstWait.Name = "colEstWait";         this.colEstWait.HeaderText = "Est. Wait";         this.colEstWait.FillWeight = 65;
            this.colQueueStatus.Name = "colQueueStatus"; this.colQueueStatus.HeaderText = "Queue Status";  this.colQueueStatus.FillWeight = 90;

            this.dgvWaitingQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTicket, this.colPatient, this.colDoctor,
                this.colArrivalTime, this.colEstWait, this.colQueueStatus
            });

            // Right Panel
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Width = 310;
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTicketHeader, this.pnlTicketPreview
            });

            this.lblTicketHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTicketHeader.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTicketHeader.Location = new System.Drawing.Point(12, 12);
            this.lblTicketHeader.Size = new System.Drawing.Size(286, 24);
            this.lblTicketHeader.Text = "Queue Ticket Preview";

            this.pnlTicketPreview.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlTicketPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTicketPreview.Location = new System.Drawing.Point(12, 42);
            this.pnlTicketPreview.Size = new System.Drawing.Size(284, 400);
            this.pnlTicketPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTicketPreview_Paint);

            // FrmWaitingQueue
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1200, 580);
            this.Controls.Add(this.dgvWaitingQueue);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSummaryCards);
            this.Name = "FrmWaitingQueue";
            this.Text = "Waiting Room Queue";
            this.Load += new System.EventHandler(this.FrmWaitingQueue_Load);

            this.pnlSummaryCards.ResumeLayout(false);
            this.pnlCardWaiting.ResumeLayout(false);
            this.pnlCardInConsult.ResumeLayout(false);
            this.pnlCardCompleted.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingQueue)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSummaryCards;
        private System.Windows.Forms.Panel pnlCardWaiting;
        private System.Windows.Forms.Label lblWaitingIcon;
        private System.Windows.Forms.Label lblWaitingTitle;
        private System.Windows.Forms.Label lblWaitingCount;
        private System.Windows.Forms.Panel pnlCardInConsult;
        private System.Windows.Forms.Label lblConsultIcon;
        private System.Windows.Forms.Label lblConsultTitle;
        private System.Windows.Forms.Label lblInConsultation;
        private System.Windows.Forms.Panel pnlCardCompleted;
        private System.Windows.Forms.Label lblCompletedIcon;
        private System.Windows.Forms.Label lblCompletedTitle;
        private System.Windows.Forms.Label lblCompletedCount;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnCallNext;
        private System.Windows.Forms.Button btnMarkInRoom;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnSendNotification;

        private System.Windows.Forms.DataGridView dgvWaitingQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstWait;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueueStatus;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTicketHeader;
        private System.Windows.Forms.Panel pnlTicketPreview;
    }
}
