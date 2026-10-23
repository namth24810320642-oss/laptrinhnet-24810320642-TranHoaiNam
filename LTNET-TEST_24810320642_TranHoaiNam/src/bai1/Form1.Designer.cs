using System.Drawing;
using System.Windows.Forms;

namespace bai1
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

            this.gbInput = new System.Windows.Forms.GroupBox();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPricePerNight = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.colBookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentityCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPricePerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐẶT PHÒNG KHÁCH SẠN";

            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.lblBookingId);
            this.gbInput.Controls.Add(this.txtBookingId);
            this.gbInput.Controls.Add(this.lblCustomerName);
            this.gbInput.Controls.Add(this.txtCustomerName);
            this.gbInput.Controls.Add(this.lblIdentityCard);
            this.gbInput.Controls.Add(this.txtIdentityCard);
            this.gbInput.Controls.Add(this.lblRoomType);
            this.gbInput.Controls.Add(this.cboRoomType);
            this.gbInput.Controls.Add(this.lblCheckIn);
            this.gbInput.Controls.Add(this.dtpCheckIn);
            this.gbInput.Controls.Add(this.lblDays);
            this.gbInput.Controls.Add(this.numDays);
            this.gbInput.Controls.Add(this.lblPrice);
            this.gbInput.Controls.Add(this.txtPricePerNight);
            this.gbInput.Controls.Add(this.btnAdd);
            this.gbInput.Controls.Add(this.btnUpdate);
            this.gbInput.Controls.Add(this.btnDelete);
            this.gbInput.Controls.Add(this.btnRefresh);
            this.gbInput.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(836, 185);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Thông Tin Đặt Phòng";

            // lblBookingId & txtBookingId
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookingId.Location = new System.Drawing.Point(20, 32);
            this.lblBookingId.Text = "Mã Đặt:";

            this.txtBookingId.BackColor = System.Drawing.Color.LightGray;
            this.txtBookingId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBookingId.Location = new System.Drawing.Point(105, 29);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(140, 23);

            // lblCustomerName & txtCustomerName
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerName.Location = new System.Drawing.Point(275, 32);
            this.lblCustomerName.Text = "Tên Khách:";

            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerName.Location = new System.Drawing.Point(360, 29);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(190, 23);

            // lblIdentityCard & txtIdentityCard
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentityCard.Location = new System.Drawing.Point(575, 32);
            this.lblIdentityCard.Text = "Số CCCD:";

            this.txtIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdentityCard.Location = new System.Drawing.Point(645, 29);
            this.txtIdentityCard.MaxLength = 12;
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(160, 23);

            // lblRoomType & cboRoomType
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomType.Location = new System.Drawing.Point(20, 72);
            this.lblRoomType.Text = "Loại Phòng:";

            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "VIP" });
            this.cboRoomType.Location = new System.Drawing.Point(105, 69);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(140, 23);

            // lblCheckIn & dtpCheckIn
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckIn.Location = new System.Drawing.Point(275, 72);
            this.lblCheckIn.Text = "Ngày Nhận:";

            this.dtpCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(360, 69);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(190, 23);

            // lblDays & numDays
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDays.Location = new System.Drawing.Point(575, 72);
            this.lblDays.Text = "Số Đêm:";

            this.numDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numDays.Location = new System.Drawing.Point(645, 69);
            this.numDays.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            this.numDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(160, 23);
            this.numDays.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblPrice & txtPricePerNight
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(20, 112);
            this.lblPrice.Text = "Giá/Đêm:";

            this.txtPricePerNight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPricePerNight.Location = new System.Drawing.Point(105, 109);
            this.txtPricePerNight.Name = "txtPricePerNight";
            this.txtPricePerNight.Size = new System.Drawing.Size(140, 23);

            // Buttons
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(275, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 32);
            this.btnAdd.Text = "Thêm Đặt Phòng";

            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(410, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.Text = "Cập Nhật";

            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(515, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.Text = "Xóa";

            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(620, 138);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 32);
            this.btnRefresh.Text = "Làm Mới";

            // 
            // dgvBookings (CẤU HÌNH CỘT TRỰC TIẾP DẠNG DESIGNER)
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBookings.Location = new System.Drawing.Point(12, 210);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(836, 350);
            this.dgvBookings.TabIndex = 1;

            // Khai báo cột cho DataGridView
            this.colBookingId.DataPropertyName = "BookingId";
            this.colBookingId.HeaderText = "Mã Đặt";
            this.colBookingId.Name = "colBookingId";
            this.colBookingId.ReadOnly = true;

            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "Tên Khách";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;

            this.colIdentityCard.DataPropertyName = "IdentityCard";
            this.colIdentityCard.HeaderText = "CCCD";
            this.colIdentityCard.Name = "colIdentityCard";
            this.colIdentityCard.ReadOnly = true;

            this.colRoomType.DataPropertyName = "RoomType";
            this.colRoomType.HeaderText = "Loại Phòng";
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;

            this.colCheckInDate.DataPropertyName = "CheckInDate";
            this.colCheckInDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colCheckInDate.HeaderText = "Ngày Nhận";
            this.colCheckInDate.Name = "colCheckInDate";
            this.colCheckInDate.ReadOnly = true;

            this.colDays.DataPropertyName = "Days";
            this.colDays.HeaderText = "Số Đêm";
            this.colDays.Name = "colDays";
            this.colDays.ReadOnly = true;

            this.colPricePerNight.DataPropertyName = "PricePerNight";
            this.colPricePerNight.DefaultCellStyle.Format = "N0";
            this.colPricePerNight.HeaderText = "Giá/Đêm";
            this.colPricePerNight.Name = "colPricePerNight";
            this.colPricePerNight.ReadOnly = true;

            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBookingId,
                this.colCustomerName,
                this.colIdentityCard,
                this.colRoomType,
                this.colCheckInDate,
                this.colDays,
                this.colPricePerNight
            });

            // 
            // Add Controls to Form
            // 
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.dgvBookings);

            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInput = null!;
        private Label lblBookingId = null!;
        private TextBox txtBookingId = null!;
        private Label lblCustomerName = null!;
        private TextBox txtCustomerName = null!;
        private Label lblIdentityCard = null!;
        private TextBox txtIdentityCard = null!;
        private Label lblRoomType = null!;
        private ComboBox cboRoomType = null!;
        private Label lblCheckIn = null!;
        private DateTimePicker dtpCheckIn = null!;
        private Label lblDays = null!;
        private NumericUpDown numDays = null!;
        private Label lblPrice = null!;
        private TextBox txtPricePerNight = null!;

        private Button btnAdd = null!;
        private Button btnUpdate = null!;
        private Button btnDelete = null!;
        private Button btnRefresh = null!;

        private DataGridView dgvBookings = null!;
        private DataGridViewTextBoxColumn colBookingId = null!;
        private DataGridViewTextBoxColumn colCustomerName = null!;
        private DataGridViewTextBoxColumn colIdentityCard = null!;
        private DataGridViewTextBoxColumn colRoomType = null!;
        private DataGridViewTextBoxColumn colCheckInDate = null!;
        private DataGridViewTextBoxColumn colDays = null!;
        private DataGridViewTextBoxColumn colPricePerNight = null!;

        private ErrorProvider errorProvider1 = null!;
    }
}