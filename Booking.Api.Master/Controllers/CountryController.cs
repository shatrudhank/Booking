using Booking.Api.Master.Models;
using Booking.Api.Master.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Api.Master.Controllers
{
    [ApiController]
    public class CountryController : ControllerBase
    {
        private ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            this._countryService = countryService;
        }


        [HttpGet]
        [Route("api/country/getCountryList")]
        public IActionResult GetCountryList()
        {
            return Ok(this._countryService.GetCountries());
        }

        [HttpPost]
        [Route("api/country/add")]
        public IActionResult CreateCountry([FromBody] CountryModel countryModel)
        {
            return Ok(this._countryService.Add(countryModel));
        }
    }
}
