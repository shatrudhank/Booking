using Booking.Api.Master.Models;

namespace Booking.Api.Master.Services.IService
{
    public interface ICountryService
    {
        IList<CountryModel> GetCountries();
        CountryModel Add(CountryModel country);
        CountryModel Update(CountryModel country);
        int Remove(int id);
        CountryModel Get(int id);

    }
}
