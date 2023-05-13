
namespace Project_OOP.Interfaces
{
    using System;
    public interface ICars
    {
        // Variables
        public int Id { get; set; }
        public String Model { get; set; }
        public String Brand { get; set; }
        public String Year { get; set; }
        public String Color { get; set; }
        public String Damage { get; set; }
        public int Price { get; set; }

    }
}
