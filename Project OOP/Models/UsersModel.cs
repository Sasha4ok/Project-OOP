namespace Project_OOP.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UsersModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public String Login { get; set; }

        [StringLength(20)]
        [Required]
        public String Password { get; set; }

        [StringLength(20)]
        [Required]
        public String Name { get; set; }

        [StringLength(100)]
        [Required]
        public String Surname { get; set; }

        [StringLength(20)]
        [Required]
        public String Email { get; set; }

        [StringLength(20)]
        [Required]
        public String Phone { get; set; }

    }
}
