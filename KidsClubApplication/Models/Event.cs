using System.ComponentModel.DataAnnotations;

namespace KidsClubApplication.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        [Required]
        [Display(Name = "Event Image Path")]
        public string? EImagePath { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string? EventTitle { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string? EventDescription { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        [Display(Name = "Event Date Time")]
        public DateTime EventDateTime { get; set; }

    }
}
