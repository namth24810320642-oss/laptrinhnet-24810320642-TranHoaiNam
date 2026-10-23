using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai3
{
    public partial class FrmStudentList : Form
    {
        private Label lblTitle = null!;
        private DataGridView dgvStudents = null!;

        public FrmStudentList()
        {
            InitializeComponentCustom();
            LoadDataSample();
        }

        private void InitializeComponentCustom()
        {
            this.lblTitle = new Label();
            this.dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(680, 420);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Sách Sinh Viên";

            // lblTitle
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(680, 45);
            this.lblTitle.Text = "DANH SÁCH SINH VIÊN";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // dgvStudents
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = Color.WhiteSmoke;
            this.dgvStudents.Dock = DockStyle.Fill;
            this.dgvStudents.Location = new Point(0, 45);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new Size(680, 375);

            // Add Controls
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblTitle);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
        }

        private void LoadDataSample()
        {
            dgvStudents.Columns.Clear();
            dgvStudents.Columns.Add("StudentId", "Mã SV");
            dgvStudents.Columns.Add("FullName", "Họ và Tên");
            dgvStudents.Columns.Add("Class", "Lớp Học");

            dgvStudents.Rows.Add("SV001", "Nguyễn Văn A", "CNTT-K62");
            dgvStudents.Rows.Add("SV002", "Trần Thị B", "KTPM-K62");
            dgvStudents.Rows.Add("SV003", "Lê Hoàng C", "HTTT-K62");
        }
    }
}