using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APP7.Models
{
    public class Employee
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public Guid Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string? FirstName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string? LastName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string? Email { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string? PhoneNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string? Position { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string? Department { get; set; }
    }
}

