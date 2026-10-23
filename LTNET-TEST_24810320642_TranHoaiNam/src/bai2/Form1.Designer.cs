using System.Drawing;
using System.Windows.Forms;

namespace bai2
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

            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsOpen = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();

            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTotalEmployees = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalSalary = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();

            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnSelectAvatar = new System.Windows.Forms.Button();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblBaseSalary = new System.Windows.Forms.Label();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HỒ SƠ NHÂN SỰ & THÔNG TIN LƯƠNG";

            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuTask});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(900, 24);
            this.menuStrip.TabIndex = 0;

            // menuFile
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenCsv,
            this.menuSaveCsv,
            new System.Windows.Forms.ToolStripSeparator(),
            this.menuExit});
            this.menuFile.Text = "File";

            this.menuOpenCsv.Text = "Mở file CSV";
            this.menuSaveCsv.Text = "Lưu file CSV";
            this.menuExit.Text = "Thoát";

            // menuTask
            this.menuTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuDelete});
            this.menuTask.Text = "Tác vụ";

            this.menuAdd.Text = "Thêm";
            this.menuDelete.Text = "Xóa";

            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpen,
            this.tsSave,
            new System.Windows.Forms.ToolStripSeparator(),
            this.tsAdd});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(900, 25);
            this.toolStrip.TabIndex = 1;

            this.tsOpen.Text = "Mở File CSV";
            this.tsSave.Text = "Lưu File CSV";
            this.tsAdd.Text = "Thêm Mới";

            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalEmployees,
            this.lblTotalSalary,
            this.lblCurrentTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 618);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(900, 22);
            this.statusStrip.TabIndex = 2;

            this.lblTotalEmployees.Text = "Tổng nhân viên: 0  |  ";
            this.lblTotalSalary.Text = "Tổng quỹ lương: 0 VNĐ  |  ";
            this.lblCurrentTime.Text = "00:00:00 01/01/2026";

            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.picAvatar);
            this.gbDetail.Controls.Add(this.btnSelectAvatar);
            this.gbDetail.Controls.Add(this.lblEmployeeId);
            this.gbDetail.Controls.Add(this.txtEmployeeId);
            this.gbDetail.Controls.Add(this.lblFullName);
            this.gbDetail.Controls.Add(this.txtFullName);
            this.gbDetail.Controls.Add(this.lblPosition);
            this.gbDetail.Controls.Add(this.cboPosition);
            this.gbDetail.Controls.Add(this.lblBaseSalary);
            this.gbDetail.Controls.Add(this.txtBaseSalary);
            this.gbDetail.Controls.Add(this.btnAdd);
            this.gbDetail.Controls.Add(this.btnDelete);
            this.gbDetail.Controls.Add(this.btnRefresh);
            this.gbDetail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDetail.Location = new System.Drawing.Point(12, 55);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(876, 195);
            this.gbDetail.TabIndex = 3;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Chi Tiết Nhân Viên";

            // picAvatar & btnSelectAvatar
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(15, 25);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(120, 125);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnSelectAvatar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectAvatar.Location = new System.Drawing.Point(15, 156);
            this.btnSelectAvatar.Name = "btnSelectAvatar";
            this.btnSelectAvatar.Size = new System.Drawing.Size(120, 26);
            this.btnSelectAvatar.Text = "Chọn ảnh";

            // Labels & TextBoxes
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeId.Location = new System.Drawing.Point(155, 30);
            this.lblEmployeeId.Text = "Mã NV:";

            this.txtEmployeeId.BackColor = System.Drawing.Color.LightGray;
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeId.Location = new System.Drawing.Point(235, 27);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(150, 23);

            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.Location = new System.Drawing.Point(415, 30);
            this.lblFullName.Text = "Họ và Tên:";

            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.Location = new System.Drawing.Point(505, 27);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(345, 23);

            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(155, 75);
            this.lblPosition.Text = "Chức Vụ:";

            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] { "Nhân viên", "Trưởng phòng", "Phó phòng", "Giám đốc" });
            this.cboPosition.Location = new System.Drawing.Point(235, 72);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(150, 23);

            this.lblBaseSalary.AutoSize = true;
            this.lblBaseSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaseSalary.Location = new System.Drawing.Point(415, 75);
            this.lblBaseSalary.Text = "Lương CB:";

            this.txtBaseSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBaseSalary.Location = new System.Drawing.Point(505, 72);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(345, 23);

            // Buttons
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(505, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 32);
            this.btnAdd.Text = "Thêm Mới";

            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(625, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.Text = "Xóa";

            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(750, 125);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.Text = "Làm Mới";

            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvEmployees.Location = new System.Drawing.Point(12, 260);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(876, 350);
            this.dgvEmployees.TabIndex = 4;

            // 
            // Add Controls to Form
            // 
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);

            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip = null!;
        private ToolStripMenuItem menuFile = null!;
        private ToolStripMenuItem menuOpenCsv = null!;
        private ToolStripMenuItem menuSaveCsv = null!;
        private ToolStripMenuItem menuExit = null!;
        private ToolStripMenuItem menuTask = null!;
        private ToolStripMenuItem menuAdd = null!;
        private ToolStripMenuItem menuDelete = null!;

        private ToolStrip toolStrip = null!;
        private ToolStripButton tsOpen = null!;
        private ToolStripButton tsSave = null!;
        private ToolStripButton tsAdd = null!;

        private StatusStrip statusStrip = null!;
        private ToolStripStatusLabel lblTotalEmployees = null!;
        private ToolStripStatusLabel lblTotalSalary = null!;
        private ToolStripStatusLabel lblCurrentTime = null!;

        private GroupBox gbDetail = null!;
        private PictureBox picAvatar = null!;
        private Button btnSelectAvatar = null!;
        private Label lblEmployeeId = null!;
        private TextBox txtEmployeeId = null!;
        private Label lblFullName = null!;
        private TextBox txtFullName = null!;
        private Label lblPosition = null!;
        private ComboBox cboPosition = null!;
        private Label lblBaseSalary = null!;
        private TextBox txtBaseSalary = null!;

        private Button btnAdd = null!;
        private Button btnDelete = null!;
        private Button btnRefresh = null!;

        private DataGridView dgvEmployees = null!;
        private ErrorProvider errorProvider1 = null!;
    }
}