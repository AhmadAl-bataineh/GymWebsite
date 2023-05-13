using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GymWebsite.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        [Required]
        [Display(Name = "Trainer Name")]
        public string? TrainerName { get; set; }
        [Required]
        public string? TrainerImg { get; set; }   
        [Display(Name = "His championships")]
        public string? Hischampionships { get; set; }
        [Display(Name = "Years Of Experience")]
        public decimal? ExperienceYears { get; set; }
        public string? FB { get; set; }
        public string? Tw { get; set; }
        public string? LinkedIn { get; set; }
    }
}
