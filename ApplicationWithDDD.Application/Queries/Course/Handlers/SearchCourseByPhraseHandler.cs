

using ApplicationWithDDD.Application.DTOs;
using ApplicationWithDDD.Shared.Abstraction.Queries;

namespace ApplicationWithDDD.Application.Queries.Course.Handlers
{
    public class SearchCourseByPhraseHandler : IQueryHandler<SearchCourseByPhrase, IEnumerable<CourseDto>>
    {
        public Task<IEnumerable<CourseDto>> HandleAsync(SearchCourseByPhrase query)
        {
            throw new NotImplementedException();
        }
    }
}
