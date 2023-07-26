using StudentService.Models;

namespace StudentService.Services
{
    public class StudentRepository : List<Models.Student>, IStudentRepository
    {
        private readonly static List<Models.Student> _students = StudentsSeed();

        private static List<Student> StudentsSeed()
        {
            var result = new List<Models.Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Jes Aldrin Rabanal",
                    School = "STI College Caloocan"
                },
                new Student
                {
                    Id = 2,
                    Name = "Bill Gates",
                    School = "Harvard College"
                },
                new Student
                {
                    Id = 3,
                    Name = "Steve Jobs",
                    School = "Reed College"
                }
            };
            return result;
        }

        public Student Get(int id)
        {
            return _students[id];
        }

        public List<Student> GetAll()
        {
            return _students;
        }
    }
}
