using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Api.DTO;
using PremiumCalculator.Core.Occupations;

namespace PremiumCalculator.Api.Controllers
{
    /// <summary>
    /// Controller to manage Occupation 
    /// </summary>
    [Route("api/v1/occupations")]
    [ApiController]
    public class OccupationController : ControllerBase
    {
        private readonly IOccupationQuery _occupationQuery;
        public OccupationController(IOccupationQuery occupationQuery)
        {
            _occupationQuery = occupationQuery;
        }

        /// <summary>
        /// Fetches list of Occupations 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Occupations> Get()
        {
            List<Occupations> occupations = _occupationQuery.Execute().Select(x => new Occupations { 
                Id = x.Id,
                Description = x.Description
            }).ToList();
            return occupations;
        }

    }
}
