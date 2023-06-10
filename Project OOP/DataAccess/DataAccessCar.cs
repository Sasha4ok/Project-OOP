using System.Linq;

namespace Project_OOP.Linq
{
    using System;
    using Contexts;
    using Interfaces;
    using Models;
    using System.Collections.Generic;

    public class ControllerCars : ICars
    {
        private static ApplicationContext _db = new ApplicationContext();

        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Damage { get; set; }
        public int Price { get; set; }
        public bool Rent { get; set; }

        public void AddCar(ICars car)
        {

            CarsModel newCarModel = new CarsModel();

            newCarModel.Model = car.Model;
            newCarModel.Brand = car.Brand;
            newCarModel.Year = car.Year;
            newCarModel.Color = car.Color;
            newCarModel.Price = car.Price;
            newCarModel.Rent = false;

            _db.CarDataBase.Add(newCarModel);
            _db.SaveChanges();
        }

        public void DeleteCar(int idCar)
        {
            CarsModel carModel = _db.CarDataBase.FirstOrDefault(c => c.Id == idCar);
            if (carModel != null)
            {
                _db.CarDataBase.Remove(carModel);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Такої машини не найдено");
            }
        }

        public void UpdateCar(int idCar, ICars car)
        {
            CarsModel carDb = _db.CarDataBase.FirstOrDefault(c => c.Id == idCar);

            if (carDb == null) throw new Exception("Машину не знайдено");

            carDb.Update(car);
            _db.SaveChanges();
        }

        public CarsModel SelectCar(int idCar)
        {
            return _db.CarDataBase.FirstOrDefault(c => c.Id == idCar);
        }

        public List<CarsModel> SelectCar()
        {
            return _db.CarDataBase.ToList();
        }
    }
}
