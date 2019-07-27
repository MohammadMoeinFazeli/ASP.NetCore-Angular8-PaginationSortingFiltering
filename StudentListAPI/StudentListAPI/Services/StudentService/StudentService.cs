using System.Linq;
using StudentListAPI.Config.PagginationConfig;
using StudentListAPI.DataBase;
using StudentListAPI.DataBase.Entities;

namespace StudentListAPI.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private IQueryable<Student> _students;

        public StudentService(AppDbContext dbContext)
        {
            _students = dbContext.Students;
        }

        public void FilterAll(string term)
        {
            _students = _students.Where(std => std.Name.Contains(term) || std.Family.Contains(term));
        }

        public void Sort(string filed, string sortDirection)
        {
            switch (filed)
            {
                case "name" when sortDirection == "desc":
                    _students = _students.OrderByDescending(x => x.Name);
                    break;
                case "name" when sortDirection == "asc":
                    _students = _students.OrderBy(x => x.Name);
                    break;
                case "family" when sortDirection == "desc":
                    _students = _students.OrderByDescending(x => x.Family);
                    break;
                case "family" when sortDirection == "asc":
                    _students = _students.OrderBy(x => x.Family);
                    break;
            }
        }

        public PagedResult<Student> GetStudents(int page, int pageSize)
        {
            return _students.GetPaged(page, pageSize);
        }
    }
}