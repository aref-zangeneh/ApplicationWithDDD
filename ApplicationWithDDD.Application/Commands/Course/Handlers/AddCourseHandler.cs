

using ApplicationWithDDD.Domain.Factories.CourseManagement;
using ApplicationWithDDD.Domain.Repositories.CourseManagement;
using ApplicationWithDDD.Shared.Abstraction.Commands;

namespace ApplicationWithDDD.Application.Commands.Course.Handlers
{
    public class AddCourseHandler : ICommandHandler<AddCourse>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICourseFactory _courseFactory;

        public AddCourseHandler(ICourseRepository courseRepository, ICourseFactory courseFactory)
        {
            _courseRepository = courseRepository;
            _courseFactory = courseFactory;
        }


        public async Task HandleAsync(AddCourse command)
        {
            var course = _courseFactory.Create(command.id, command.title, command.description, command.isFree, command.price, command.instructorId);

            await _courseRepository.AddAsync(course);
        }
    }
}
