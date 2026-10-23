using System.Drawing;
using System.Windows.Forms;

namespace bai4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.gbCriteria = new System.Windows.Forms.GroupBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.pgbStatus = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();

            this.dgvReportData = new System.Windows.Forms.DataGridView();

            this.gbCriteria.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 620);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG ĐIỀU KHIỂN TỔNG HỢP BÁO CÁO KHO HÀNG";

            // 
            // gbCriteria
            // 
            this.gbCriteria.Controls.Add(this.lblWarehouse);
            this.gbCriteria.Controls.Add(this.cboWarehouse);
            this.gbCriteria.Controls.Add(this.lblFromDate);
            this.gbCriteria.Controls.Add(this.dtpFromDate);
            this.gbCriteria.Controls.Add(this.lblToDate);
            this.gbCriteria.Controls.Add(this.dtpToDate);
            this.gbCriteria.Controls.Add(this.btnAnalytics);
            this.gbCriteria.Controls.Add(this.btnCancel);
            this.gbCriteria.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCriteria.Location = new System.Drawing.Point(12, 12);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(856, 100);
            this.gbCriteria.TabIndex = 0;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "Tiêu Chí Báo Cáo";

            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarehouse.Location = new System.Drawing.Point(15, 32);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(62, 15);
            this.lblWarehouse.Text = "Kho Hàng:";

            // 
            // cboWarehouse
            // 
            this.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarehouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Items.AddRange(new object[] { "Kho Tổng", "Kho Miền Bắc", "Kho Miền Nam", "Kho Linh Kiện" });
            this.cboWarehouse.Location = new System.Drawing.Point(85, 28);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(150, 23);

            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFromDate.Location = new System.Drawing.Point(250, 32);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(54, 15);
            this.lblFromDate.Text = "Từ Ngày:";

            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(310, 28);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 23);

            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToDate.Location = new System.Drawing.Point(455, 32);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(61, 15);
            this.lblToDate.Text = "Đến Ngày:";

            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(520, 28);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 23);

            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalytics.Location = new System.Drawing.Point(670, 24);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(165, 30);
            this.btnAnalytics.Text = "Thống Kê Kho";

            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(670, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 28);
            this.btnCancel.Text = "Hủy Tác Vụ";

            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.pgbStatus);
            this.gbStatus.Controls.Add(this.lblPercent);
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbStatus.Location = new System.Drawing.Point(12, 120);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(856, 70);
            this.gbStatus.TabIndex = 1;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Trạng Thái Tiến Trình Xử Lý";

            // 
            // pgbStatus
            // 
            this.pgbStatus.Location = new System.Drawing.Point(15, 28);
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(760, 25);

            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPercent.Location = new System.Drawing.Point(785, 31);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(26, 17);
            this.lblPercent.Text = "0%";

            // 
            // dgvReportData
            // 
            this.dgvReportData.AllowUserToAddRows = false;
            this.dgvReportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReportData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvReportData.Location = new System.Drawing.Point(12, 200);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.ReadOnly = true;
            this.dgvReportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportData.Size = new System.Drawing.Size(856, 405);
            this.dgvReportData.TabIndex = 2;

            // 
            // Add Controls to Form
            // 
            this.Controls.Add(this.gbCriteria);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.dgvReportData);

            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCriteria = null!;
        private Label lblWarehouse = null!;
        private ComboBox cboWarehouse = null!;
        private Label lblFromDate = null!;
        private DateTimePicker dtpFromDate = null!;
        private Label lblToDate = null!;
        private DateTimePicker dtpToDate = null!;
        private Button btnAnalytics = null!;
        private Button btnCancel = null!;

        private GroupBox gbStatus = null!;
        private ProgressBar pgbStatus = null!;
        private Label lblPercent = null!;

        private DataGridView dgvReportData = null!;
    }
}