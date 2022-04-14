using System.ComponentModel.DataAnnotations;

namespace Commander.Models{
    public class Command{
        
        [Key] // don't need to do it
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}