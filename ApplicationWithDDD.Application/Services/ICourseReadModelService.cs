

namespace ApplicationWithDDD.Application.Services
{
    public interface ICourseReadModelService
    {
        Task<bool> IsCourseExistsByName(string courseName);
    }
}
