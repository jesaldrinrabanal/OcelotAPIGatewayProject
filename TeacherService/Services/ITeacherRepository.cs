namespace TeacherService.Services
{
    public interface ITeacherRepository
    {
        List<Models.Teacher> GetAll();
        Models.Teacher Get(int id);
    }
}
