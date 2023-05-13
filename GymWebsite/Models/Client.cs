using GymWebsite.Models.SharedProp;

namespace GymWebsite.Models
{
    public class Client : CommonProp
    {
        public int ClientId { get; set; }
        public string? ClientName { get; set; }
        public string? ClientPosition { get; set; }
        public string? AfterImage { get; set; }
        public string? BeforeImage { get; set; }

    }
}
