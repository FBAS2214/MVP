using MVP.Models;

namespace MVP.Repository
{
    public interface ICarRepository
    {
        void Create(Car car);
        void Update(Car car);
        void Delete(Guid id);
        List<Car> ReadAll();
        Car? ReadById(Guid id);
    }
}
