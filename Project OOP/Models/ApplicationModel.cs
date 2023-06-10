using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_OOP.Models
{
    public class ApplicationModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public String Status { get; set; }

        [StringLength(200)]
        public String Notes { get; set; }

        public DateTime? LeaserTerm { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }

        public UsersModel UserModel { get; set; }
        public CarsModel CarModel { get; set; }
    }
}