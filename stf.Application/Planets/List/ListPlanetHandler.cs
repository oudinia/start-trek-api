using System.Collections;
using DotNetCore.Mediator;
using DotNetCore.Results;
using stf.Model;
using stf.DataAccess.Planets;

namespace stf.Application.Planets.List;

    public sealed record ListPlanetHandler : IHandler<ListPlanetRequest, IEnumerable<PlanetModel>>
    {
        private readonly IPlanetRepository _planetRepository;
        
        public ListPlanetHandler(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public async Task<Result<IEnumerable<PlanetModel>>> HandleAsync(ListPlanetRequest request)
        {
            var planets = await _planetRepository.ListModelAsync();
            return Result<IEnumerable<PlanetModel>>.Success(planets);
        }
    }

