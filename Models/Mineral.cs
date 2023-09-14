using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace titanitedb.Models
{
    public class Mineral
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid id { get; set; }

        [Required]
        public string createdBy { get; set; }

        [Required]
        public DateTime createdDate { get; set; }

        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
    }
}