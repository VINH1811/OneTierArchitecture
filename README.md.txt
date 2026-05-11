# TodoApp - Console Management System

Một ứng dụng quản lý công việc (Todo List) chạy trên nền tảng Console, được xây dựng bằng **C# .NET 9.0** và sử dụng **Entity Framework Core** để quản lý dữ liệu bền vững trên **SQL Server**.

## 👥 Thông tin nhóm phát triển
**Tên nhóm:** Nhóm WL
**Thành viên:**
* **Nguyễn Văn Vinh**
* **Đỗ Văn Vinh**
* **Bạch Ngọc Lương**

---

## 🚀 Công nghệ sử dụng
* **Ngôn ngữ:** C# (.NET 9.0)
* **ORM:** Entity Framework Core 9.0
* **Database:** Microsoft SQL Server
* **Kiến trúc:** 3-Layer Architecture (UI - Service - Repository)
* **Mô hình thiết kế:** C4 Model cho tài liệu kiến trúc

## ✨ Tính năng chính
* **Xem danh sách:** Hiển thị toàn bộ công việc hiện có trong Database.
* **Thêm mới:** Tạo công việc mới với trạng thái mặc định là chưa hoàn thành.
* **Cập nhật:** Thay đổi nội dung tiêu đề công việc.
* **Đánh dấu hoàn thành:** Chuyển đổi trạng thái (Toggle) giữa hoàn thành và chưa hoàn thành.
* **Xóa:** Loại bỏ công việc khỏi hệ thống.

## 🏗 Kiến trúc hệ thống (C4 Model)

Dự án được thiết kế theo tiêu chuẩn C4 Model để đảm bảo tính minh bạch và dễ dàng mở rộng.

### 1. Cấp độ Ngữ cảnh (System Context)
Mô tả sự tương tác giữa Người dùng và Hệ thống Todo với SQL Server.
![System Context](images/context.png)

### 2. Cấp độ Container
Chi tiết về môi trường thực thi .NET 9.0 bên trong ứng dụng.
![Container Diagram](images/container.png)

### 3. Cấp độ Thành phần (Component)
Chi tiết các lớp xử lý bên trong như `TodoUI`, `TodoService`, `TodoRepository` và `AppDbContext`.
![Component Diagram](c4model.png)

## 🛠 Hướng dẫn cài đặt

1.  **Clone dự án:**
    ```bash
    git clone [https://github.com/your-username/TodoApp.git](https://github.com/your-username/TodoApp.git)
    ```
2.  **Cấu hình chuỗi kết nối:**
    Mở file `AppDbContext.cs` và thay đổi `Server=...` phù hợp với Instance SQL Server của bạn:
    ```csharp
    optionsBuilder.UseSqlServer("Server=ANHVINH;Database=LAB1SA;Integrated security=True;TrustServerCertificate=True;");
    ```
3.  **Khởi tạo Database (Migration):**
    Mở *Package Manager Console* trong Visual Studio và chạy:
    ```powershell
    Add-Migration InitialCreate
    Update-Database
    ```
4.  **Chạy ứng dụng:** Nhấn `F5` hoặc `dotnet run`.

## 📂 Cấu trúc thư mục
* `Models/`: Chứa thực thể `Todo.cs`.
* `Data/`: Chứa `AppDbContext.cs` cấu hình EF Core.
* `Repositories/`: Lớp thao tác trực tiếp với Database.
* `Services/`: Lớp xử lý logic nghiệp vụ.
* `UI/`: Giao diện dòng lệnh (Console).

---
*Dự án được thực hiện bởi sinh viên Khoa Công nghệ thông tin - Trường Đại học Đại Nam.*