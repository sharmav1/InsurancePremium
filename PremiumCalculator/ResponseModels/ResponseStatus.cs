namespace PremiumCalculator.Api.ResponseModels
{
    /// <summary>
    /// Bespoke response payload. In real application we might create a generic payload
    /// </summary>
    public class ResponsePayload
    {
        public ResponseStatus Status { get; set; } = new ResponseStatus();
        public double MonthlyPremium { get; set; }
    }

    public class ResponseStatus
    {
        public int Code { get; set; }
        public ResponseType Type { get; set; }
        public string Message { get; set; } = "";

    }

    public enum ResponseType
    { 
        Success = 0,
        BusinessException = 1,
        SystemException = 2
    }

}
