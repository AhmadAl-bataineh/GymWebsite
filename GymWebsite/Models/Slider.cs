using GymWebsite.Models.SharedProp;
using System.ComponentModel.DataAnnotations;

namespace GymWebsite.Models
{
    public class Slider : CommonProp
    {
        [Display (Name = "Slider Id")]
        public int SliderId { get; set; }
        [Display(Name = "Slider Title")]
        [Required(ErrorMessage ="Enter Title")]
        public string? SliderTitle { get; set; }
        [Display(Name = "Slider Sub Title")]
        [Required(ErrorMessage = "Enter Sub Title")]
        public string? SliderSubTitle { get; set;}
        [Display(Name = "Slider Images")]
        [Required(ErrorMessage = "Enter Images")]
        public string? SliderImg { get; set; }
        
        public string? Textbtn { get; set;}
    }
}
