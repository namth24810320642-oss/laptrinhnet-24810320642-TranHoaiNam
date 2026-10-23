# BÁO CÁO BÀI TẬP / ĐỒ ÁN

## THÔNG TIN SINH VIÊN
- Họ và tên:Trần Hoài Nam
- Mã số sinh viên:24810320642
- Lớp học phần:Lập trình .NET
- Mã lớp:D19QTANM1
- Link Repository: https://github.com/namth24810320642-oss/laptrinhnet-24810320642-TranHoaiNam.git

## II. DANH SÁCH BÀI TẬP HOÀN THÀNH & TỰ ĐÁNH GIÁ

| Bài tập | Tiêu đề bài tập | Trạng thái | Mức độ hoàn thành (%) |
| :---: | :--- | :---: | :---: |
| **Bài 1** | Quản lý Đặt phòng Khách sạn (CRUD & Data Binding) | Hoàn thành | 100% |
| **Bài 2** | Quản lý Hồ sơ Nhân sự & Lương - HR & Payroll (File CSV & Timer) | Hoàn thành | 100% |
| **Bài 3** | Hệ thống Quản lý Trường học & Đào tạo (Kiến trúc MDI Container) | Hoàn thành | 100% |
| **Bài 4** | Bảng điều khiển Tổng hợp Báo cáo Kho hàng (Async/Await & Cancellation) | Hoàn thành | 100% |
| **Bài 5** | Mô phỏng Giám sát Cảnh báo IoT Real-time (Cross-Thread Safety & `Invoke`) | Hoàn thành | 100% |

---

### Đánh giá chi tiết kỹ thuật đạt được:
- **Kiến trúc & Designer**: Tách biệt 100% giữa giao diện (`Designer.cs`) và logic xử lý (`.cs`), hỗ trợ hiển thị giao diện trực quan trực tiếp trên Visual Studio Designer trước khi run (Design-time visibility).
- **Tính chuẩn xác dữ liệu**: Áp dụng C# 9.0/10.0+ (`BindingList<T>`, `BindingSource`, Regex validation, xử lý Nullable an toàn).
- **Hiệu năng & Bất đồng bộ**: Sử dụng `async/await`, `Task.Run` kết hợp `CancellationTokenSource` giúp giao diện luôn mượt mà (không bị đơ/Not Responding).
- **An toàn đa luồng (Thread Safety)**: Đảm bảo quy tắc `this.InvokeRequired` / `this.Invoke` khi cập nhật UI từ Background Thread ở ứng dụng Real-time.
## III. MINH HỌA GIAO DIỆN & KỸ THUẬT NỔI BẬT

### 1. Phân tách Kiến trúc Giao diện & Logic (Clean Architecture)
* **Tính năng**: Tách biệt hoàn toàn phần khai báo giao diện (`Form1.Designer.cs`) và logic xử lý nghiệp vụ (`Form1.cs`).
* **Ưu điểm**:
  * Giúp Visual Studio Designer đọc và vẽ giao diện trực quan 100% ngay trên màn hình thiết kế (Design-time visibility) mà không cần bấm **F5**.
  * Cấu hình cột `DataGridView` trực tiếp trong file `.Designer.cs` giúp hiển thị tiêu đề và kẻ ô bảng rõ ràng trước khi chạy chương trình.
  * Giữ file code chính (`Form1.cs`) vô cùng tinh gọn, dễ bảo trì và mở rộng.

---

### 2. Xử lý Dữ liệu & Ràng buộc (Data Binding & Validation)
* **Áp dụng tại**: Bài 1 (Quản lý Đặt phòng) & Bài 2 (Quản lý Nhân sự).
* **Kỹ thuật**:
  * Sử dụng `BindingList<T>` kết hợp `BindingSource` để đồng bộ hóa dữ liệu 2 chiều tự động giữa danh sách đối tượng và các Control nhập liệu/bảng biểu.
  * Sử dụng `ErrorProvider` kết hợp **Regular Expressions (Regex)** để kiểm tra tính hợp lệ của dữ liệu đầu vào (CCCD/CMND 9 hoặc 12 số, Giá phòng/Lương cơ bản $> 0$, Tên không để trống).
  * Đọc/Ghi dữ liệu định dạng **CSV** theo chuỗi mã hóa **UTF-8** hỗ trợ hiển thị tiếng Việt có dấu chuẩn xác.

---

### 3. Kiến trúc Đa cửa sổ MDI (Multiple Document Interface)
* **Áp dụng tại**: Bài 3 (Quản lý Trường học & Đào tạo).
* **Kỹ thuật**:
  * Thiết lập `IsMdiContainer = true` trên Form chính để quản lý tập trung các Form con (`FrmStudentList`, `FrmCourseList`).
  * Xử lý thuật toán **ngăn ngừa mở trùng Form con**: Khi người dùng nhấn chọn Menu, hệ thống tự động quét danh sách `MdiChildren`, nếu Form đã tồn tại sẽ thực hiện `Activate()` đưa lên trước thay vì khởi tạo mới.
  * Tổ chức sắp xếp cửa sổ linh hoạt theo các chế độ: `Cascade` (Xếp tầng), `TileHorizontal` (Xếp ngang), `TileVertical` (Xếp dọc) và chức năng đóng tất cả cửa sổ con.

---

### 4. Lập trình Bất đồng bộ & Hủy tác vụ (Async/Await & Cancellation)
* **Áp dụng tại**: Bài 4 (Báo cáo Kho hàng).
* **Kỹ thuật**:
  * Sử dụng `await Task.Run(...)` đẩy các tác vụ nặng (quét dữ liệu kho giả lập 4.5 giây) xuống **Background Thread**, đảm bảo **UI Thread** luôn mượt mà (không rơi vào trạng thái *Not Responding* khi thao tác phóng to, thu nhỏ, kéo rê Form).
  * Sử dụng `IProgress<T>` để truyền tiến độ phần trăm ($0\% - 100\%$) từ luồng ngầm về cập nhật thanh `ProgressBar` và `Label` giao diện một cách mượt mà.
  * Tích hợp `CancellationTokenSource` cho phép ngắt tiến trình chạy ngầm ngay lập tức khi nhấn nút **[Hủy Tác Vụ]**.

---

### 5. An toàn Đa luồng Real-time (Cross-Thread Safety & `Invoke`)
* **Áp dụng tại**: Bài 5 (Mô phỏng IoT Real-time).
* **Kỹ thuật**:
  * Khởi chạy vòng lặp thu thập dữ liệu tự động định kỳ 2 giây/lần bằng `Task.Run` chạy ngầm.
  * Tuân thủ nghiêm ngặt quy tắc an toàn luồng trong WinForms bằng cách kiểm tra `this.InvokeRequired` và thực thi `this.Invoke(new Action(...))` để chuyển ngữ cảnh cập nhật UI về đúng luồng chính.
  * Loại bỏ triệt để ngoại lệ nguy hiểm `InvalidOperationException: Cross-thread operation not valid` khi ứng dụng Debug dưới Visual Studio.
## KẾT QUẢ THỰC HÀNH
# Bài1

<img width="841" height="588" alt="bai1" src="https://github.com/user-attachments/assets/7f9778e1-4f5d-42b3-9f88-ad585aa0fbd0" />

# Bài2

<img width="903" height="673" alt="bai2" src="https://github.com/user-attachments/assets/bd7a7250-6ab0-4635-a702-349fd8c31ad1" />

# Bài3

<img width="996" height="732" alt="bai3" src="https://github.com/user-attachments/assets/50b87e62-286d-4d31-a3f1-9d5e9d1e24c2" />

# Bài 4

<img width="876" height="652" alt="bai4" src="https://github.com/user-attachments/assets/0504160d-3bd7-4735-9d3d-0476d1f36909" />

# Bài 5

<img width="800" height="615" alt="bai5" src="https://github.com/user-attachments/assets/e2b06434-076e-4194-9ef4-d513aa0bf0a7" />










