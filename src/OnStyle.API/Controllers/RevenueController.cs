using Microsoft.AspNetCore.Mvc;
using OnStyle.Application.UseCases.Revenues.Register;
using OnStyle.Communication.Requests;

namespace OnStyle.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RevenueController : ControllerBase
{
    public IActionResult Register([FromBody] RequestRegisterRevenueJson request)
    {
        var useCase = new RegisterRevenueUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }
}
