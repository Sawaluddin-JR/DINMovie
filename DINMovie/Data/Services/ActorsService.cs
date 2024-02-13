using DINMovie.Data.Base;
using DINMovie.Models;

namespace DINMovie.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
