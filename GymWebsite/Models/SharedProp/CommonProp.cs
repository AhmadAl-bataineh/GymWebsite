using System.ComponentModel.DataAnnotations;

namespace GymWebsite.Models.SharedProp
{
    public class CommonProp
    {
        [Display(Name = "Creation Date")]
        public DateTime? CreationDate { get; set; }
        [Display(Name = "Is Pulished")]

      
        public bool IsDeleted { get; set; }
        [Display(Name = "Is Avilable")]

        public bool IsAvilable { get; set; }
        [Display(Name = "User")]

        public string? UserId { get; set; }




    }
}
