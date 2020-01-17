using CarAPI.CarDBContext;
using CarAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Models.DataManager
{
    public class CarManager:IDataRepository<Car>
    {
        readonly CarContext _carContext;
        public CarManager(CarContext context)
        {
            _carContext = context;
        }
        public IEnumerable<Car> GetAll()
        {
            return _carContext.Cars.ToList();
        }
        public Car Get(long id)
        {
            return _carContext.Cars.FirstOrDefault(c => c.CarId == id);
        }
        public void Add(Car entity)
        {
            _carContext.Cars.Add(entity);
            _carContext.SaveChanges();
        }
        public void Update(Car car, Car entity)
        {
            car.CarName = entity.CarName;
            car.CarName = entity.CarModel;
            car.CarPrice = entity.CarPrice;
            car.Year = entity.Year;
            car.PhoneNumber = entity.PhoneNumber;
            _carContext.SaveChanges();
        }
        public void Delete(Car car)
        {
            _carContext.Cars.Remove(car);
            _carContext.SaveChanges();
        }
        
    }
}
