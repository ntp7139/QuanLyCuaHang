﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    // Class Khách hàng
    public class KhachHang
    {
        private int id;
        private string ten;
        private string email;
        private string soDienThoai;
        private string diaChi;
        private DateTime ngayDangKy;

        public void DisplayInfo()
        {
            // Hiển thị thông tin khách hàng
        }

        public void UpdateInfo()
        {
            // Cập nhật thông tin khách hàng
        }

        public void DisplayOrderDetails()
        {
            // Hiển thị chi tiết đơn hàng
        }

        public void MakeOrder()
        {
            // Tạo đơn hàng mới
        }

        public void MakeFeedback()
        {
            // Đánh giá sản phẩm
        }
    }

    // Class Người bán
    public class NguoiBan
    {
        public int id;
        private string ten;
        private string email;
        private string soDienThoai;
        private string diaChi;
        private DateTime ngayThamGia;

        public bool SignIn(string Taikhoan,string Matkhau)
        {
            // Đăng nhập
            Connection connection = new Connection();
            if (!connection.Check_ID_Sellers(Taikhoan))
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (connection.Check_Sellers(Taikhoan,Matkhau))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Thông tin mật khẩu sai!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            
        }

        public void SignOut()
        {
            // Đăng xuất
        }

        public void Register()
        {
            // Đăng ký tài khoản người bán
        }

        public void SearchProduct()
        {
            // Tìm kiếm sản phẩm
        }

        public void SearchFeedback()
        {
            // Tìm kiếm phản hồi
        }

        public void ConfirmOrder()
        {
            // Xác nhận đơn hàng
        }

        public void MakeReceipt()
        {
            // Tạo biên nhận
        }

        public void UpdateProductInfo()
        {
            // Cập nhật thông tin sản phẩm
        }

        public void MakeReport()
        {
            // Tạo báo cáo
        }
    }

    // Class Sản phẩm
    public class SanPham
    {
        private int id;
        private int idNguoiBan;
        private string ten;
        private string moTa;
        private decimal gia;
        private int soLuongTon;
        private string hinhAnh;

        public void AddNewProduct()
        {
            // Thêm sản phẩm mới
        }

        public void EditProduct()
        {
            // Chỉnh sửa sản phẩm
        }

        public void UpdateProduct()
        {
            // Cập nhật số lượng sản phẩm
        }

        public void Display()
        {
            // Hiển thị thông tin sản phẩm
        }
    }

    // Class Đơn hàng
    public class DonHang
    {
        private int id;
        private DateTime ngayDatHang;
        private int idNguoiMua;
        private string trangThai;

        public void Add()
        {
            // Thêm đơn hàng mới
        }

        public void Update()
        {
            // Cập nhật thông tin đơn hàng
        }

        public void GetStatus()
        {
            // Lấy trạng thái đơn hàng
        }

        public void Display()
        {
            // Hiển thị thông tin đơn hàng
        }
    }

    // Class Chi tiết đơn hàng
    public class ChiTietDonHang
    {
        private int id;
        private int idDonHang;
        private int idSanPham;
        private int soLuong;
        private decimal gia;

        public void Display()
        {
            // Hiển thị chi tiết đơn hàng
        }

        public void UpdateInfo()
        {
            // Cập nhật thông tin chi tiết đơn hàng
        }

        public void AddInfo()
        {
            // Thêm thông tin chi tiết đơn hàng
        }

        public void GetStatus()
        {
            // Lấy trạng thái
        }

        public void GetBill()
        {
            // Lấy hóa đơn
        }
    }

    // Class Giỏ hàng
    public class GioHang
    {
        private int id;
        private string idKhachHang;
        private string idSanPham;
        private int soLuong;
        private DateTime ngayThem;

        public void AddProduct()
        {
            // Thêm sản phẩm vào giỏ
        }

        public void EditProduct()
        {
            // Sửa sản phẩm trong giỏ
        }

        public void DeleteProduct()
        {
            // Xóa sản phẩm khỏi giỏ
        }

        public void UpdateNumberProduct()
        {
            // Cập nhật số lượng sản phẩm
        }

        public void Display()
        {
            // Hiển thị giỏ hàng
        }
    }

    // Class Tin nhắn
    public class TinNhan
    {
        private int id;
        private int idNguoiGui;
        private int idNguoiNhan;
        private string noiDung;
        private DateTime thoiGianGui;

        public void Add()
        {
            // Thêm tin nhắn mới
        }

        public void Update()
        {
            // Cập nhật tin nhắn
        }

        public void Delete()
        {
            // Xóa tin nhắn
        }

        public void Display()
        {
            // Hiển thị tin nhắn
        }

        public void GetContent()
        {
            // Lấy nội dung tin nhắn
        }
    }
}
