using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Courses.Queries;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CoursesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllCoursesQuery());
        return Ok(result);
    }
    [HttpPost]
public async Task<IActionResult> Create(CreateCourseCommand command)
{
    var result = await _mediator.Send(command);
    return Ok(result);
}
}