using QuanLySinhVien.DAL;

namespace QuanLySinhVien.BLL;

// Tầng nghiệp vụ: gọi DAL, xử lý logic rồi trả về cho GUI
public class StudentService
{
    private readonly StudentRepository _repo = new();

    public async Task<List<Student>> GetAllStudentsAsync()
    {
        return await _repo.GetAllAsync();
    }
}
