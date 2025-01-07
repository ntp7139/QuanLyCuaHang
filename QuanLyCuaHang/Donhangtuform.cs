using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace QuanLyCuaHang
{
    public partial class Donhangtuform : Form
    {
        public Donhangtuform()
        {
            InitializeComponent();
        }

        private void lb__Click(object sender, EventArgs e)
        {

        }
        public void Load_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "Select * from ordersform ";
            DataTable dt = connection.ExcuteQuery(query);
            dtgv_ordersform.AutoGenerateColumns = true;
            dtgv_ordersform.RowHeadersVisible = false;
            dtgv_ordersform.DataSource = dt;
        }

        private void btn_Xuathoadon_Click(object sender, EventArgs e)
        {
            int ID_donhang = Convert.ToInt32(tb_Madonhang.Text);
            ordersform orders = new ordersform(ID_donhang);
            CreateInvoiceWord(orders);
        }
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
        private void CreateInvoiceWord(ordersform hoaDon)
        {
            // Đường dẫn lưu file Word
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"HoaDonForm_{hoaDon.ID}.docx");

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
                table.Append(CreateSingleLineRow("Mã đơn hàng online:", hoaDon.ID.ToString()));
                table.Append(CreateSingleLineRow("Ngày đặt hàng:", hoaDon.date));
                table.Append(CreateSingleLineRow("Tên sản phẩm:", hoaDon.Product));
                table.Append(CreateSingleLineRow("Tên khách hàng:", hoaDon.customerName));
                table.Append(CreateSingleLineRow("Số lượng:", hoaDon.quantity.ToString()));
                table.Append(CreateSingleLineRow("Địa chỉ:", hoaDon.address.ToString()));
                table.Append(CreateSingleLineRow("Số điện thoại:", $"{hoaDon.phoneNumber}"));
                table.Append(CreateSingleLineRow("Hình thức thanh toán:", hoaDon.paymentMethod));
                table.Append(CreateSingleLineRow("Đơn vị vận chuyển:", hoaDon.Delivery));

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

        private void btn_Laythongitn_Click(object sender, EventArgs e)
        {
            RunSSISPackage();
        }
        private void RunSSISPackage()
        {
            // Kết nối đến SQL Server
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-HH7KDOL\\SQLEXPRESS; Database=PTTKHT; Trusted_Connection=True;"))
            {
                connection.Open();

                // Tạo Command để gọi Stored Procedure
                using (SqlCommand command = new SqlCommand("EXEC [SSISDB].[catalog].[start_execution] @execution_id", connection))
                {
                    // Thêm các tham số nếu cần
                    //command.Parameters.AddWithValue("@execution_id", your_execution_id);

                    // Thực thi Stored Procedure
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
