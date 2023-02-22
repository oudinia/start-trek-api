using System.Linq.Expressions;
using DotNetCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using stf.Domain;
using stf.Model;
using stf.DataAccess.Context;

namespace stf.DataAccess.Planets
{
    public sealed class PlanetRepository: EFRepository<Planet>, IPlanetRepository
    {
        public PlanetRepository(StarFleetDbContext context) : base(context) {}

        private static Expression<Func<Planet, PlanetModel>> Model
        {
            get
            {
                return planet => new PlanetModel
                    { Id = planet.PlanetId, Name = planet.Name, Description = planet.Description };
            }
        }

        public async Task<IEnumerable<PlanetModel>> ListModelAsync()
        {
            return await Queryable.Select(Model).ToListAsync();
        }
        public async Task<PlanetModel?> GetModelAsync(int id)
        {
            return await Queryable.Where(planet => planet.PlanetId == id).Select(Model).SingleOrDefaultAsync();
        }
    }
}
