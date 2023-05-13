using GymWebsite.Models.SharedProp;
using System.ComponentModel.DataAnnotations;

namespace GymWebsite.Models
{
    public class OurServisess : CommonProp
    {
        [Display(Name = "Servises Id")]
        public int Id { get; set; }
        [Display(Name = "Servises Title")]
        [Required(ErrorMessage ="Enter Title")]

        public string? ServisesTitle { get; set; }
        [Display(Name = "Servises Url")]
        [Required(ErrorMessage = "Servises Url")]
        public string? ServisesUrl { get; set; }
        public int PerantId { get; set; }
        public string? ServisesImg { get; set; }




    }
}
