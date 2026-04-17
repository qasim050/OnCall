using Application.Features.Courses.Commands;
using Infrastructure.Data;
using MediatR;
using Domain.Entities;

namespace Application.Features.Courses.Handlers;

public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, int>
{
    private readonly AppDbContext _context;

    public CreateCourseHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = new Course
        {
            Title = request.Title,
            Description = request.Description
        };

        _context.Courses.Add(course);
        await _context.SaveChangesAsync(cancellationToken);

        return course.Id;
    }
}