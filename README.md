# Demo Web Quản Lý Người Dùng

## Giới thiệu
Đây là ứng dụng web demo dùng để quản lý thông tin người dùng.  
Ứng dụng cho phép thực hiện các chức năng CRUD (Thêm, Sửa, Xóa, Hiển thị danh sách người dùng).

---

## Công nghệ sử dụng
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap

---

## Chức năng
Hệ thống bao gồm các chức năng chính:

- Hiển thị danh sách người dùng
- Thêm người dùng mới
- Chỉnh sửa thông tin người dùng
- Xóa người dùng
- Xem chi tiết người dùng

---

## Thông tin người dùng
Hệ thống quản lý các trường thông tin sau:

- Mã (Id)
- Họ tên
- Ngày sinh
- Email
- Điện thoại
- Địa chỉ

---

## Cách chạy project :

### 1. Clone source code


### 2. Mở project bằng Visual Studio

### 3. Cấu hình chuỗi kết nối database

Mở file: appsettings.json
Sửa connection string:


"ConnectionStrings": {
"DefaultConnection": "Server=.;Database=UserManagement;Trusted_Connection=True;"
}


### 4. Tạo database

Mở **Package Manager Console** và chạy:
Update-Database


### 5. Chạy project

Nhấn **F5** để chạy project.

## Demo giao diện
<img width="1914" height="869" alt="image" src="https://github.com/user-attachments/assets/6141a677-bae1-4e02-9190-193df575d87a" />


