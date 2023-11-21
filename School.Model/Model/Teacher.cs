using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.Model
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(9)]
        public string? TZ { get; set; }
        [MaxLength(20)]
        public string? FirstName { get; set; }
        [MaxLength(20)]
        public string? LastName { get; set; }
        public int Experience { get; set; }
        public int? SubjectId { get; set; }
        [NotMapped]
        public int Age { get; set; }
        [RegularExpression("^(07(\\d ?){9})", ErrorMessage = "Invalid Phone Number")]
        public int Phone { get; set; }
        [RegularExpression("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$", ErrorMessage = "Invalid EMail")]
        public string EMail { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject SubjectForTeacher { get; set; }
    }
}
