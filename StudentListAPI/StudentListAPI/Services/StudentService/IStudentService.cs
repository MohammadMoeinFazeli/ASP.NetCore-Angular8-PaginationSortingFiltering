using StudentListAPI.Config.PagginationConfig;
using StudentListAPI.DataBase.Entities;

namespace StudentListAPI.Services.StudentService
{
    public interface IStudentService
    {
        void FilterAll(string term);
        void Sort(string filed, string sortDirection);
        PagedResult<Student> GetStudents(int page, int pageSize);
    }
}
