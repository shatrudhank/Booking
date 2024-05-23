using Booking.Api.Master.Models;
using Booking.Api.Master.Repository.Entity;
using Booking.Api.Master.Repository.IRepository;
using Booking.Api.Master.Services.IService;
using System.Diagnostics.Metrics;

namespace Booking.Api.Master.Services
{
    public class CountryService : ICountryService
    {
        private IRepository<Country> _repository;
        public CountryService(IRepository<Country> repository)
        {
            this._repository = repository;
        }

        public CountryModel Add(CountryModel countryModel)
        {
            Country country = new Country()
            {
                Id = countryModel.Id,
                Name = countryModel.Name,
                Code=countryModel.Code
            };

            _repository.Add(country);

            countryModel.Id = country.Id;
            return countryModel;
        }

        public CountryModel Get(int id)
        {
            Country country = _repository.Get(id);
            return new CountryModel()
            {
                Id = country.Id,
                Name = country.Name ?? string.Empty,
                Code = country.Code
            };
        }

        public IList<CountryModel> GetCountries()
        {
            IList<CountryModel> countryList = new List<CountryModel>();
            foreach (Country country in this._repository.GetAll())
            {
                countryList.Add(new CountryModel()
                {
                    Id = country.Id,
                    Name = country.Name??string.Empty,
                    Code= country.Code
                });
            }
            return countryList;
        }

        public int Remove(int id)
        {
            Country country = _repository.Get(id);
            return _repository.Remove(country);
        }

        public CountryModel Update(CountryModel countryModel)
        {
            Country country = _repository.Get(countryModel.Id);

            country.Name = countryModel.Name;
            _repository.Update(country);

            return countryModel;
        }
    }
}
