using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using GymWebsite.Models.SharedProp;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebsite.Models
{
    public class SportList : CommonProp
    {
        public int SportListId { get; set; }
        [Required]
        [Display(Name = "Sport Name")]
        public string? SportName { get; set; }
        [Required]
        [Display(Name = "Sport Description")]
        [DataType(DataType.MultilineText)]
        public string? SportDesc { get; set; }
        [Required]
        [Display(Name = "Sport Price")]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "Sport Image")]
        public string? Img { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "Start Time")]
        public TimeSpan StartTime { get; set; }
        public string? Duration { get; set; }
        public int? Rate { get; set; }
        public Venus Venu { get; set; }
        public enum Venus { GroupTraining , PrivateTraining , SelfTraining ,SpecializedTraining }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public Trainer? Trainer { get; set; }

    }
}
