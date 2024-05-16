using Booking.Api.Master.Repository.Entity;
using Booking.Api.Master.Repository.IRepository;

namespace Booking.Api.Master.Repository.Repository
{

    public class CountryRepository : IRepository<Country>
    {
        private AdminDbContext _dbContext;
        public CountryRepository(AdminDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public int Add(Country country)
        {
            this._dbContext.Add(country);
            return this._dbContext.SaveChanges();
        }

        public int Remove(Country country)
        {
            this._dbContext.Remove(country);
            return this._dbContext.SaveChanges();
        }

        public Country Get(int id)
        {
            return this._dbContext.Countries.Where(x => x.Id == id).First();
        }

        public IList<Country> GetAll()
        {
            return this._dbContext.Countries.ToList();
        }

        public int Update(Country country)
        {
            this._dbContext.Update(country);
            return this._dbContext.SaveChanges();
        }
    }
}
