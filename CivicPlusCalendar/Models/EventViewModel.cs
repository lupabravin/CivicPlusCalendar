using System.ComponentModel.DataAnnotations;

namespace CivicPlusCalendar.Models
{
    public class EventViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string EndDate { get; set; }
    }
}
