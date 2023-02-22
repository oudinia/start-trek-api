using DotNetCore.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace stf.web.Controllers;

[ApiController]
public abstract class BaseController : ControllerBase
{
    protected IMediator Mediator => HttpContext.RequestServices.GetRequiredService<IMediator>();
}
