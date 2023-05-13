using GymWebsite.Models.SharedProp;

namespace GymWebsite.Models
{
    public class Payment : CommonProp
    {
        public Guid PaymentId { get; set; }
        public string? InvoiceId { get; set; }
        public decimal? Total { get; set; }
        public bool IsSuccess { get; set; }
    }
}
