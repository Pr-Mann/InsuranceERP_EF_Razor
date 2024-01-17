using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceERP_EF_Razor.Models
{
    public class Policy
    {
        [Key]
        public Guid PolicyId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PolicyNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string HolderName { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateOnly EffectiveDate { get; set; }

        [Required]
        [Column(TypeName = "decimal (5,2)")]
        public double Premium { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(10000)]
        public string Comment { get; set; }
    }
}
