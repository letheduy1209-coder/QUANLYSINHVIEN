namespace QuanLySinhVien.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public int StudentId { get; set; } // Mã sinh viên
        public int CourseId { get; set; }  // Mã khóa học
    }
}