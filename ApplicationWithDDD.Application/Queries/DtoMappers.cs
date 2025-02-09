

using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Application.Models.CourseManagement;
using ApplicationWithDDD.Application.Models.UserManagement;

namespace ApplicationWithDDD.Application.Queries
{
    internal static class DtoMappers
    {
        public static UserDto ToDto(this UserReadModel user)
        {
            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                IsConfirmed = user.IsConfirmed,
                Password = user.Password,
                Username = user.Username
            };
        }

        public static CourseDto ToDto(this CourseReadModel course)
        {
            return new CourseDto
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Desctription,
                InstructorId = course.InstructorId,
                IsFree = course.IsFree,
                Price = course.Price
            };
        }
    }
}
