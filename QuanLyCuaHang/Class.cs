using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Windows.Forms;
using System.Data;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

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
        public string QuyenTruyCap;
        public void Load_Seller()
        {
            Connection connection = new Connection();
            string query = $"Select * from nguoiban where manguoiban = '{id.ToString()}'";
            DataTable dataTable = new DataTable();
            dataTable = connection.ExcuteQuery(query);
            DataRow dataRow = dataTable.Rows[0];
            this.id = Convert.ToInt32(dataRow["Manguoiban"]);
            this.ten = dataRow["Tennguoiban"].ToString();
            this.email = dataRow["Email"].ToString();
            this.soDienThoai = dataRow["SoDienThoai"].ToString();
            this.diaChi = dataRow["DiaChi"].ToString();
            this.ngayThamGia = (DateTime)dataRow["NgayThamGia"];
            this.QuyenTruyCap = dataRow["QuyenTruyCap"].ToString();
        }
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

        public bool Register(string Name,string ID,string Matkhau,string Matkhaucheck,string Email)
        {
            // Đăng ký tài khoản người bán
            Connection connection = new Connection();
            if (connection.Check_ID_Sellers(ID))
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                if (Matkhau != Matkhaucheck)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    DateTime ngayHienTai = DateTime.Now;
                    DateTime chiNgay = ngayHienTai.Date; // Lấy phần ngày, giờ sẽ là 00:00:00
                    string ngayDinhDang = chiNgay.ToString("yyyy-MM-dd");
                    string query = $"Insert into nguoiban(manguoiban,tennguoiban,matkhau,email,NgayThamGia) values('{ID}','{Name}','{Matkhau}','{Email}','{ngayDinhDang}')";
                    try
                    {
                        connection.ExcuteNonQuery(query);
                        return true;
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return false;

                    }
                }
            }
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

        public SanPham()
        {
            
        }
        public SanPham(int id,int idNguoiBan,string ten,string moTa,decimal Gia,int soluongTon,string Hinhanh)
        {
            this.id = id;
            this.idNguoiBan = idNguoiBan;
            this.ten = ten;
            this.moTa = moTa;
            this.gia = Gia;
            this.soLuongTon = soluongTon;
            this.hinhAnh = Hinhanh;

        }
        public void Load_SanPham(string ID) 
        { 
            
            Connection connection = new Connection();
            string query = $"Select * from sanpham where masanpham = '{ID.ToString()}'";
            DataTable dataTable = new DataTable();
            dataTable = connection.ExcuteQuery(query);
            DataRow dataRow = dataTable.Rows[0];
            this.id = Convert.ToInt32(dataRow["Manguoiban"]);
            this.ten = dataRow["Tensanpham"].ToString();
            this.idNguoiBan =Convert.ToInt32( dataRow["Manguoiban"]);
            this.moTa = dataRow["mota"].ToString();
            this.gia = Convert.ToDecimal(dataRow["gia"]);
            this.soLuongTon = Convert.ToInt32(dataRow["soluongton"]);
            this.hinhAnh = dataRow["hinhanh"].ToString();

        }
        public void AddNewProduct()
        {


            // Thêm sản phẩm mới
            Connection connection = new Connection();
            if (!connection.Check_ID_SanPham(this.id.ToString()))
            {
                string query = $"insert into sanpham values('{this.id}','{this.idNguoiBan}','{this.ten}'" +
                    $",'{this.moTa}','{this.gia}','{this.soLuongTon}','{this.hinhAnh}')";
                connection.ExcuteNonQuery(query);
            }
            else
            {
                MessageBox.Show("Đã tồn tại mã sản phẩm!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        public void EditProduct()
        {
            // Chỉnh sửa sản phẩm
            Connection connection = new Connection();
            string query = $"Update sanpham " +
                           $" set tensanpham ='{ten}', mota = '{moTa}',gia={gia},soluongton ={soLuongTon},hinhanh='{hinhAnh}'" +
                           $" where masanpham = '{id}'";
            connection.ExcuteNonQuery(query);
            MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void DeleteProduct(string ID)
        {
            // Xóa sản phẩm
            Connection connection = new Connection();
            if (!connection.Check_ID_SanPham(ID))
            {
                MessageBox.Show("Không tồn tại mã sản phẩm","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            {
                string query = $"Delete from sanpham where masanpham = '{ID}'";
                connection.ExcuteNonQuery(query);

                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Display()
        {
            // Hiển thị thông tin sản phẩm
        }
    }

    // Class Đơn hàng
    public class DonHang
    {
        public int id_donhang;
        public int id_khachhang;
        public int id_masanpham;
        public int so_luong;
        public DateTime ngayDatHang;
        public string trangThai;
        public decimal Gia;
        public string Hinhthucthanhtoan;
        public string Donvivanchuyen;
        
        public DonHang() { }
        public DonHang(string id_khachhang,string id_masanpham,int so_luong,decimal Gia, string thanhtoan,string vanchuyen) 
        {
           // this.id_donhang = Convert.ToInt32(id_donhang);
            this.id_khachhang = Convert.ToInt32(id_khachhang);
            this.id_masanpham = Convert.ToInt32(id_masanpham);
            this.so_luong = so_luong;
            this.trangThai = "Đang xử lí";
            this.Gia = Gia;
            this.Hinhthucthanhtoan = thanhtoan;
            this.Donvivanchuyen = vanchuyen;
            DateTime ngayHienTai = DateTime.Now;
            DateTime chiNgay = ngayHienTai.Date; // Lấy phần ngày, giờ sẽ là 00:00:00
            string ngayDinhDang = chiNgay.ToString("yyyy-MM-dd");
            this.ngayDatHang = ngayHienTai;

        }

        public void Load(string ID_Donhang)
        {
            Connection connection = new Connection();
            string query = $"SELECT * from donhang where Madonhang = '{ID_Donhang}'";
            DataTable dt = connection.ExcuteQuery(query);
            DataRow dr = dt.Rows[0];
            this.id_donhang = Convert.ToInt32(ID_Donhang);
            this.id_khachhang = Convert.ToInt32(dr["Makhachhang"]);
            this.id_masanpham = Convert.ToInt32(dr["MaSanPham"]);
            this.so_luong = Convert.ToInt32(dr["SoLuong"]);
            this.trangThai = dr["TrangThai"].ToString();
            this.Gia = Convert.ToDecimal(dr["TongTien"]);
            this.Hinhthucthanhtoan = dr["Hinhthucthanhtoan"].ToString();
            this.Donvivanchuyen = dr["Donvivanchuyen"].ToString();
            this.ngayDatHang = (DateTime)dr["Ngaydathang"];
        }
        public void Add()
        {
            DateTime ngayHienTai = DateTime.Now;
            DateTime chiNgay = ngayHienTai.Date;
            string ngay = chiNgay.ToString("yyyy-MM-dd");
            string query = $"Insert into donhang(MaKhachHang,MaSanPham, SoLuong, HinhThucThanhToan, DonViVanChuyen, NgayDatHang, TongTien, TrangThai) " +
                $" VALUES('{id_khachhang}','{id_masanpham}','{so_luong}','{Hinhthucthanhtoan}','{Donvivanchuyen}','{ngay}','{Gia}','{trangThai}')";
            Connection connection = new Connection();
            connection.ExcuteNonQuery(query);
           
            // Thêm đơn hàng mới
        }

        public void Update()
        {
            // Cập nhật thông tin đơn hàng
               string query = $"UPDATE donhang " +
                    $"SET MaKhachHang = '{id_khachhang}', " +
                    $"MaSanPham = '{id_masanpham}', " +
                    $"SoLuong = '{so_luong}', " +
                    $"HinhThucThanhToan = '{Hinhthucthanhtoan}', " +
                    $"DonViVanChuyen = '{Donvivanchuyen}', " +
                    $"NgayDatHang = '{ngayDatHang.ToString("yyyy-MM-dd")}', " +
                    $"TongTien = '{Gia}', " +
                    $"TrangThai = '{trangThai}' " +
                    $"WHERE MaDonHang = {id_donhang};";
            Connection connection = new Connection();
            connection.ExcuteNonQuery(query);
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
    public class ordersform
    {
        public int ID;
        public string Product;
        public int quantity;
        public string   paymentMethod;
         public string   customerName;
        public string email;
        public string address;
        public string date;
        public string phoneNumber;
        public decimal Gia;
        public string Delivery;
        public string TinhTrang;
        public ordersform(int ID)
        {
            this.ID = ID;
            Connection connection = new Connection();
            string query = $"select * from ordersform where id = '{ID}'";
            DataTable dt = connection.ExcuteQuery(query);
            DataRow dr = dt.Rows[0];
            this.Product = dr["product"].ToString();
            this.quantity = Convert.ToInt32(dr["quantity"].ToString());
            this.paymentMethod = dr["paymentMethod"].ToString();
            this.customerName = dr["customerName"].ToString();
            this.email = dr["email"].ToString();
            this.address = dr["address"].ToString();   
            this.phoneNumber = dr["phoneNumber"].ToString();
            this.TinhTrang = dr["trangthai"].ToString();
            DateTime ngay = DateTime.Now;
            this.date = ngay.ToString();
            string query1 = $"Select * from sanpham where tensanpham = '{Product}'";
           dt = connection.ExcuteQuery(query1);
            dr = dt.Rows[0];
            string Gia_string = dr["gia"].ToString();
            decimal Gia_sanpham = Convert.ToDecimal(Gia_string);
            this.Gia = Gia_sanpham * this.quantity;
            string[] value = { "FedEx", "DHL", "Việt Nam Post" };
            Random random = new Random();
            this.Delivery = value[random.Next(value.Length)];
            
        }
        public void Update()
        {
            Connection connection = new Connection();
            string query = $"Update ordersform set trangthai = 'Đã xác nhận ' where id = '{this.ID}';";
            connection.ExcuteNonQuery(query);
        }
    }
}
