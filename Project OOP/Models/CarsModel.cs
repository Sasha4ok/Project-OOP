using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project_OOP.Interfaces;

namespace Project_OOP.Models
{
    public class CarsModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public String Model { get; set; }

        [StringLength(20)]
        [Required]
        public String Brand { get; set; }

        [StringLength(20)]
        [Required]
        public String Year { get; set; }

        [StringLength(20)]
        [Required]
        public String Color { get; set; }

        [StringLength(20)]
        [Required]
        public String Damage { get; set; }

        [Required]
        public int Price { get; set; }

        public bool Rent { get; set; }

        public ICollection<ApplicationModel> Application { get; set; }

        public void Update(ICars car)
        {
            this.Model = car.Model;
            this.Brand = car.Brand;
            this.Year = car.Year;
            this.Color = car.Color;
            this.Damage = car.Damage;
            this.Price = car.Price;
        }
    }
}