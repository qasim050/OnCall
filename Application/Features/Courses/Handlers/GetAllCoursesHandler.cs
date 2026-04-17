using MediatR;
using Application.Features.Courses.Queries;

namespace Application.Features.Courses.Handlers;

public class GetAllCoursesHandler : IRequestHandler<GetAllCoursesQuery, List<string>>
{
    public async Task<List<string>> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
    {
        // مؤقتًا داتا fake
        return new List<string>
        {
            "Course 1",
            "Course 2",
            "Course 3"
        };
    }
}