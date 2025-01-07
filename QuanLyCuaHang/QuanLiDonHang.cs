using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

using DocumentFormat.OpenXml.Packaging;

using DocumentFormat.OpenXml;

namespace QuanLyCuaHang
{
    public partial class QuanLiDonHang : Form
    {
        private JustificationValues JustificationValues = JustificationValues.Left;
        private DonHang donhang = new DonHang();
        public QuanLiDonHang()
        {
            InitializeComponent();
        }

        private void QuanLiDonHang_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "SELECT * from donhang";
            DataTable dt = connection.ExcuteQuery(query);
            DtgV_QLDH.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DtgV_QLDH.RowHeadersVisible = false;
            DtgV_QLDH.DataSource = dt;  
        }

        private void DtgV_QLDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
                if(tb_Madonhang.Enabled == false)
            {
                tb_Madonhang.Enabled = true;
            }
            else
            {
                Connection connection = new Connection();
                string query = $"Delete from donhang Where madonhang = '{tb_Madonhang.Text}'";
                connection.ExcuteNonQuery(query);
                tb_Madonhang.Clear();
                MessageBox.Show("Đã xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Madonhang.Enabled = false;
                QuanLiDonHang_Load(sender, e);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(tb_Makhachhang.Text  != "" && tb_ngaydathang.Text != "" && tb_Soluong.Text != "" && tb_masanpham.Text != "" && tb_Gia.Text != "" && lB_hinhthucthanhtoan.SelectedItem != null && lb_donvivanchuyen.SelectedItem != null)
            {
                string thanhtoan = "PayPal", vanchuyen = "Credit Card";
                thanhtoan = lB_hinhthucthanhtoan.SelectedItem.ToString();
                vanchuyen = lb_donvivanchuyen.SelectedItem.ToString();
                Decimal Gia = Convert.ToDecimal(tb_Gia.Text);
                DonHang donHang = new DonHang(tb_Makhachhang.Text,tb_masanpham.Text,Convert.ToInt32(tb_Soluong.Text),Gia,thanhtoan,vanchuyen);
                donHang.Add();
                QuanLiDonHang_Load(sender, e);
                MessageBox.Show("Thêm đơn hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Makhachhang.Clear();
                tb_masanpham.Clear();
                tb_Soluong.Clear();
                
            } else
            {
                MessageBox.Show("Hãy nhập đủ thông tin đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update_gia(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Connection connection = new Connection();
                    string query = $"Select * from sanpham where masanpham = '{tb_masanpham.Text}' ";
                    DataTable dt = connection.ExcuteQuery(query);
                    DataRow dr = dt.Rows[0];
                    string gia = dr["Gia"].ToString();
                    Decimal Gia_sanpham = Convert.ToDecimal(gia);
                    int So_luong = Convert.ToInt32(tb_Soluong.Text);
                    Decimal GiaCa = Gia_sanpham * So_luong;
                    tb_Gia.Text = GiaCa.ToString();
                    DateTime ngayHienTai = DateTime.Now;
                    DateTime chiNgay = ngayHienTai.Date; // Lấy phần ngày, giờ sẽ là 00:00:00
                    string ngayDinhDang = chiNgay.ToString("yyyy-MM-dd");
                    tb_ngaydathang.Text = ngayDinhDang;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Upload(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DonHang don = new DonHang();
                donhang.Load(tb_Madonhang.Text);
                don.Load(tb_Madonhang.Text);
                tb_Makhachhang.Text = don.id_khachhang.ToString();
                tb_masanpham.Text = don.id_masanpham.ToString();
                tb_Soluong.Text = don.so_luong.ToString();
                lB_hinhthucthanhtoan.SelectedItem = don.Hinhthucthanhtoan;
                lb_donvivanchuyen.SelectedItem = don.Donvivanchuyen;
                tb_Gia.Text = don.Gia.ToString();
                tb_ngaydathang.Text = don.ngayDatHang.ToString();
               
            }
        }

        private void btn_xuathoadon_Click(object sender, EventArgs e)
        {
            if (tb_Madonhang.Enabled == false)
            {
                tb_Madonhang.Enabled = true;
            }
            else
            {
                if (CreateInvoiceWord(donhang))
                {
                    donhang.trangThai = "Chờ xác nhận! ";
                    donhang.Update();
                    QuanLiDonHang_Load(sender, e);
                }

            }
        }
        //render cái form thành bitmap
        private Bitmap CaptureFormToBitmap()
        {
            // Chụp hình ảnh form
            Rectangle bounds = this.Bounds;
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);

            // Vẽ form vào hình ảnh bitmap
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, bounds.Size);
            }

            return bitmap;
        }
        private bool CreateInvoiceWord(DonHang hoaDon)
        {
            bool Ans = false;
            // Đường dẫn lưu file Word
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"HoaDon_{hoaDon.id_donhang}.docx");

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                // Tạo Main Document Part
                MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // 1. Tiêu đề hóa đơn
                Paragraph title = new Paragraph(new Run(new Text("HÓA ĐƠN BÁN HÀNG")));
                title.ParagraphProperties = new ParagraphProperties(new Justification { Val = JustificationValues.Center });
                RunProperties titleRunProperties = new RunProperties();
                titleRunProperties.Append(new Bold(), new FontSize { Val = "28" });
                title.GetFirstChild<Run>().RunProperties = titleRunProperties;
                body.Append(title);

                // 2. Tạo bảng để chứa các thông tin
                Table table = new Table();

                // Tạo viền nét đứt cho bảng
                TableProperties tblProperties = new TableProperties(
                    new TableBorders(
                        new TopBorder { Val = BorderValues.Dashed, Size = 12 },
                        new BottomBorder { Val = BorderValues.Dashed, Size = 12 },
                        new LeftBorder { Val = BorderValues.Dashed, Size = 12 },
                        new RightBorder { Val = BorderValues.Dashed, Size = 12 },
                        new InsideHorizontalBorder { Val = BorderValues.Dashed, Size = 6 },
                        new InsideVerticalBorder { Val = BorderValues.Dashed, Size = 6 }
                    ));
                table.AppendChild(tblProperties);

                // Thêm các thông tin đơn hàng vào bảng
                table.Append(CreateSingleLineRow("Mã đơn hàng:", hoaDon.id_donhang.ToString()));
                table.Append(CreateSingleLineRow("Ngày đặt hàng:", hoaDon.ngayDatHang.ToString("dd/MM/yyyy")));
                table.Append(CreateSingleLineRow("Trạng thái:", hoaDon.trangThai));
                table.Append(CreateSingleLineRow("Mã khách hàng:", hoaDon.id_khachhang.ToString()));
                table.Append(CreateSingleLineRow("Mã sản phẩm:", hoaDon.id_masanpham.ToString()));
                table.Append(CreateSingleLineRow("Số lượng:", hoaDon.so_luong.ToString()));
                table.Append(CreateSingleLineRow("Giá:", $"{hoaDon.Gia:C}"));
                table.Append(CreateSingleLineRow("Hình thức thanh toán:", hoaDon.Hinhthucthanhtoan));
                table.Append(CreateSingleLineRow("Đơn vị vận chuyển:", hoaDon.Donvivanchuyen));

                // Thêm bảng vào tài liệu
                body.Append(table);

                // 3. Thông tin "Tổng tiền"
                Paragraph totalParagraph = CreateParagraph($"Tổng tiền: {hoaDon.Gia:C}", isBold: true);
                totalParagraph.ParagraphProperties = new ParagraphProperties(new Justification { Val = JustificationValues.Right });
                body.Append(totalParagraph);

                // 4. Dòng cảm ơn
                Paragraph thankYou = CreateParagraph("Cảm ơn quý khách!", isItalic: true);
                thankYou.ParagraphProperties = new ParagraphProperties(new Justification { Val = JustificationValues.Center });
                body.Append(thankYou);

                // Lưu tài liệu
                mainPart.Document.Save();
            }

            // Thông báo hoàn thành
            
            MessageBox.Show($"Hóa đơn đã được xuất ra file Word tại: {filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Ans = true;
            return Ans;
        }

        // Hàm tạo hàng trong bảng với văn bản hiển thị trên một dòng
        private TableRow CreateSingleLineRow(string label, string value)
        {
            TableRow row = new TableRow();

            // Ô chứa nhãn và giá trị trên cùng một dòng
            TableCell cell = new TableCell();
            Paragraph paragraph = new Paragraph();

            // Tạo một Run cho nhãn
            Run labelRun = new Run(new Text(label + " ")); // Chèn dấu cách sau nhãn

            // Tạo một Run cho giá trị
            Run valueRun = new Run(new Text(value));

            // Định dạng chữ cho nhãn (Bold)
            RunProperties labelProperties = new RunProperties(new Bold());
            labelRun.RunProperties = labelProperties;

            // Thêm cả nhãn và giá trị vào cùng một Paragraph
            paragraph.Append(labelRun);
            paragraph.Append(valueRun);

            // Tạo TableCellProperties để thay đổi kích thước
            TableCellProperties cellProps = new TableCellProperties();
            // Thiết lập chiều rộng cố định cho ô
            cellProps.Append(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "5000" }); // 5000 Dxa là độ rộng của ô

            // Thêm thuộc tính chiều rộng vào ô
            cell.Append(paragraph);
            cell.Append(cellProps);

            row.Append(cell);
            return row;
        }

        // Hàm tạo đoạn văn
        private Paragraph CreateParagraph(string text, bool isBold = false, bool isItalic = false)
        {
            Run run = new Run(new Text(text));
            RunProperties runProperties = new RunProperties();
            if (isBold) runProperties.Append(new Bold());
            if (isItalic) runProperties.Append(new Italic());
            run.RunProperties = runProperties;
            return new Paragraph(run);
        }


    }
}
