using DotNetCore.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using stf.Application.Planets.List;
using stf.Model;

namespace stf.web.Controllers;
[ApiController]
[Route("api/planets")]
public sealed class PlanetController : BaseController
{
    [HttpGet]
    public IActionResult List()
    {
        return Mediator.HandleAsync<ListPlanetRequest, IEnumerable<PlanetModel>>(new ListPlanetRequest()).ApiResult();
    }
}