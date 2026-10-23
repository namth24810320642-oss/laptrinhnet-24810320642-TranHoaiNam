using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        private readonly BindingList<BookingModel> bookingList;
        private readonly BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();

            bookingList = new BindingList<BookingModel>();
            bindingSource = new BindingSource { DataSource = bookingList };

            // Gán dữ liệu cho bảng
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.DataSource = bindingSource;

            bindingSource.CurrentChanged += BindingSource_CurrentChanged;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            if (cboRoomType.Items.Count > 0) cboRoomType.SelectedIndex = 0;
            GenerateNewBookingId();
        }

        private void GenerateNewBookingId()
        {
            int nextId = bookingList.Count + 1;
            txtBookingId.Text = $"BK{nextId:D3}";
        }

        private bool ValidateData()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống!");
                isValid = false;
            }

            if (!Regex.IsMatch(txtIdentityCard.Text.Trim(), @"^(\d{9}|\d{12})$"))
            {
                errorProvider1.SetError(txtIdentityCard, "CCCD/CMND phải là 9 hoặc 12 chữ số!");
                isValid = false;
            }

            if (!decimal.TryParse(txtPricePerNight.Text.Trim(), out decimal price) || price <= 0)
            {
                errorProvider1.SetError(txtPricePerNight, "Giá phòng phải là số lớn hơn 0!");
                isValid = false;
            }

            return isValid;
        }

        private void BindingSource_CurrentChanged(object? sender, EventArgs e)
        {
            if (bindingSource.Current is BookingModel currentBooking)
            {
                txtBookingId.Text = currentBooking.BookingId;
                txtCustomerName.Text = currentBooking.CustomerName;
                txtIdentityCard.Text = currentBooking.IdentityCard;
                cboRoomType.SelectedItem = currentBooking.RoomType;
                dtpCheckIn.Value = currentBooking.CheckInDate;
                numDays.Value = currentBooking.Days;
                txtPricePerNight.Text = currentBooking.PricePerNight.ToString("G0");
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateData()) return;

            bookingList.Add(new BookingModel
            {
                BookingId = txtBookingId.Text,
                CustomerName = txtCustomerName.Text.Trim(),
                IdentityCard = txtIdentityCard.Text.Trim(),
                RoomType = cboRoomType.SelectedItem?.ToString() ?? "Standard",
                CheckInDate = dtpCheckIn.Value,
                Days = (int)numDays.Value,
                PricePerNight = decimal.Parse(txtPricePerNight.Text.Trim())
            });

            BtnRefresh_Click(this, EventArgs.Empty);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (bindingSource.Current == null || !ValidateData()) return;

            var current = (BookingModel)bindingSource.Current;
            current.CustomerName = txtCustomerName.Text.Trim();
            current.IdentityCard = txtIdentityCard.Text.Trim();
            current.RoomType = cboRoomType.SelectedItem?.ToString() ?? "Standard";
            current.CheckInDate = dtpCheckIn.Value;
            current.Days = (int)numDays.Value;
            current.PricePerNight = decimal.Parse(txtPricePerNight.Text.Trim());

            bindingSource.ResetCurrentItem();
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa lượt đặt phòng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                BtnRefresh_Click(this, EventArgs.Empty);
            }
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtCustomerName.Clear();
            txtIdentityCard.Clear();
            if (cboRoomType.Items.Count > 0) cboRoomType.SelectedIndex = 0;
            dtpCheckIn.Value = DateTime.Now;
            numDays.Value = 1;
            txtPricePerNight.Clear();
            GenerateNewBookingId();
            txtCustomerName.Focus();
        }
    }
}