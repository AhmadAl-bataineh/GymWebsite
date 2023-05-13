using GymWebsite.Models.SharedProp;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebsite.Models
{
    public class Schedule: CommonProp
    {
        public int ScheduleId { get; set; }
        public DateTime StartDate { get; set; }
        public  string? Day { get; set; }

        [ForeignKey("Trainer")]
        public int TrainerName { get; set; }
        public Trainer? Trainer { get; set; }
        [ForeignKey("SportList")]
        public string? SportName { get; set; }
        public SportList? SportList { get; set; }

    }
}
