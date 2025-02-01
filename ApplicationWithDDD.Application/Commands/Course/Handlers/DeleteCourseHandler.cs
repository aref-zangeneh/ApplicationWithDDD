

using ApplicationWithDDD.Application.Exceptions;
using ApplicationWithDDD.Domain.Repositories.CourseManagement;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.Course.Handlers
{
    public class DeleteCourseHandler : ICommandHandler<DeleteCourse>
    {
        private readonly ICourseRepository _courseRepository;

        public DeleteCourseHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task HandleAsync(DeleteCourse command)
        {
            var course = await _courseRepository.GetAsync(command.Id);

            if (course == null)
            {
                throw new CourseNotFoundException();
            }
            await _courseRepository.DeleteAsync(course.Id);
        }
    }
}
