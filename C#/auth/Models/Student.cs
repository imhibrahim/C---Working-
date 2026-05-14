using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace auth.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Name insert ")]
        [StringLength(10,MinimumLength =3,ErrorMessage ="min 3 max 10")]
        [Column("Username",TypeName ="varchar(100)")]
        public string name { get; set; }

        [Required(ErrorMessage ="mail insert ")]
        [EmailAddress]
        [Column("Usermail", TypeName = "varchar(100)")]
        public string mail { get; set; }

        [Required]
        [Column("Userpassword", TypeName = "varchar(100)")]
        public string password { get; set; }
        [Required]
        [Column("Usernumber", TypeName = "varchar(100)")]
        public int? number { get; set; }
        public string standerd { get; set; }

    }
}
