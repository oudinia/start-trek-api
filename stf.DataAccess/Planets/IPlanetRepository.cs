using DotNetCore.Repositories;
using stf.Domain;
using stf.Model;

namespace stf.DataAccess.Planets;

public interface IPlanetRepository: IRepository<Planet>
{
    Task<PlanetModel?> GetModelAsync(int id);
    Task<IEnumerable<PlanetModel>> ListModelAsync();
}