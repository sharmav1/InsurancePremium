using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Api.Helpers;
using PremiumCalculator.Api.ResponseModels;
using PremiumCalculator.Core.Customers;
using System.Net;


namespace PremiumCalculator.Api.Controllers
{
    /// <summary>
    /// Main controller to manage and return monthly premium
    /// </summary>
    [Route("api/v1/premium")]
    [ApiController]
    public class PremiumController : ControllerBase
    {
        private readonly IGetCustomerMonthlyPremium _customerMonthlyPremium;
        public PremiumController(IGetCustomerMonthlyPremium customerMonthlyPremium)
        {
            _customerMonthlyPremium = customerMonthlyPremium;
        }
        
        /// <summary>
        /// get api to return monthly premium based on occupation, age, and sum insured
        /// </summary>
        /// <param name="occupationId"></param>
        /// <param name="age"></param>
        /// <param name="sumInsured"></param>
        /// <returns></returns>
        // GET api/<MonthlyPremiumController>/5
        [HttpGet("{occupationId}/getmonthly")]
        public ResponsePayload Get(int occupationId, int age, double sumInsured)
        {
            ResponsePayload result = new ResponsePayload();
            try
            {
                // Validate Incoming Data
                if (!Validator.ValidateInput(occupationId, age, sumInsured))
                {
                    result.Status.Code = (int)HttpStatusCode.BadRequest;
                    result.Status.Message = "Input validation error";
                    result.Status.Type = ResponseType.SystemException;
                    result.MonthlyPremium = 0;
                    return result;
                }
                var premium = _customerMonthlyPremium.Execute(occupationId: occupationId, age: age, sumInsured: sumInsured); ;
                result.MonthlyPremium = premium;
                result.Status.Code = (int)HttpStatusCode.OK;
                result.Status.Message = "Premium calculated successfully";
                result.Status.Type = ResponseType.Success;
                
                return result;
            }
            catch (Exception ex)
            {
                //log exception
                string message = (!string.IsNullOrEmpty(ex.Message))
                    ? ex.Message : string.Empty;

                result.Status.Code = 500;
                result.Status.Message = message;
                result.Status.Type = ResponseType.SystemException;
                return result;
            }
            
        }

    }
}
