using QuanLySinhVien.BLL;

namespace QuanLySinhVien.GUI;

// Tầng giao diện: chỉ gọi BLL, không dùng DbContext trực tiếp
public partial class Form1 : Form
{
    private readonly StudentService _service = new();

    public Form1()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object? sender, EventArgs e)
    {
        await TaiDanhSach();
    }

    private async Task TaiDanhSach()
    {
        try
        {
            var danhSach = await _service.GetAllStudentsAsync();
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = danhSach;
            lblTrangThai.Text = $"Đã tải {danhSach.Count} sinh viên.";
            lblTrangThai.ForeColor = Color.DarkGreen;
        }
        catch (Exception ex)
        {
            lblTrangThai.Text = "Lỗi: " + ex.Message;
            lblTrangThai.ForeColor = Color.Red;
        }
    }
}
