using MVP.Models;
using MVP.Repository.Context;
namespace MVP.Repository
{
    public class CarRepository : BaseRepository, ICarRepository
    {
        private readonly CarContext _context;

        public CarRepository(string connectionString)
            :base(connectionString)
        {
            _context = new CarContext(connectionString);
        }

        public void Create(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var car = ReadById(id);
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }

        public List<Car> ReadAll()
        {
            return _context.Cars.ToList();
        }

        public Car? ReadById(Guid id)
        {
            return _context.Cars.FirstOrDefault(c=>c.Id == id);
        }

        public void Update(Car car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
        }
    }
}
