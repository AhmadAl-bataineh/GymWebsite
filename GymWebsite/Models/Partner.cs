using GymWebsite.Models.SharedProp;
using System.ComponentModel.DataAnnotations;

namespace GymWebsite.Models
{
    public class Partner : CommonProp
    {
        public int PartnerId { get; set; }
        [Required]
        public int PartnerPosition { get; set; }
        [Required]
         
        public string? PartnerName { get; set; }
        [Required]
        public string? PartnerImg { get; set; }
    }
}
