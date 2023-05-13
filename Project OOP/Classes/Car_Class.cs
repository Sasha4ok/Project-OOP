using Project_OOP.Interfaces;

namespace Project_OOP.Classes
{

    public class CarClass : ICars
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Damage { get; set; }
        public int Price { get; set; }

        public CarClass(ICars car)
        {
            Model = car.Model;
            Brand = car.Brand;
            Year = car.Year;
            Color = car.Color;
            Damage = car.Damage;
            Price = car.Price;
        }
    }
}
