using TeacherService.Models;
using TeacherService.Services;

namespace TeacherService.Services
{
    public class TeacherRepository : List<Models.Teacher>, ITeacherRepository
    {
        private readonly static List<Models.Teacher> _teachers = TeachersSeed();

        private static List<Teacher> TeachersSeed()
        {
            var result = new List<Models.Teacher>()
            {
                new Teacher
                {
                    Id = 1,
                    Name = "John Ace Manlapat",
                    School = "STI College Caloocan"
                },
                new Teacher
                {
                    Id = 2,
                    Name = "Harry Lewis",
                    School = "Harvard College"
                },
                new Teacher
                {
                    Id = 3,
                    Name = "Robert Palladino",
                    School = "Reed College"
                }
            };
            return result;
        }

        public Teacher Get(int id)
        {
            return _teachers[id];
        }

        public List<Teacher> GetAll()
        {
            return _teachers.ToList();
        }
    }
}
