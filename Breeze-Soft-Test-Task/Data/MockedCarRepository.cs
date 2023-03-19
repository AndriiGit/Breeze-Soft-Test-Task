using Breeze_Soft_Test_Task.Domain;

namespace Breeze_Soft_Test_Task.Data;

public class MockedCarRepository: IRepository<Car>
{
    private List<Car> _cars;

    public MockedCarRepository()
    {
        _cars = new List<Car>()
        {
            new Car(){Id=1, Producer="VW", Name="Polo", Engine=1, EnginePower=80.4F, AmountOfCylinders=4, Color="Gray", ProducedDate=new DateOnly(2022, 12, 3), Available=true },
            new Car(){Id=2, Producer="Audi", Name="A4", Engine=2, EnginePower=250.2F, AmountOfCylinders=12, Color="Red", ProducedDate=new DateOnly(2015, 2, 13), Available=false },
            new Car(){Id=3 }
        };
    }

    private Car FindById(int id)
    {
        return _cars.First(x => x.Id == id);
    }

    public async Task<IEnumerable<Car>> GetAllAsync()
    {
        return await Task.Run(() => { return _cars; });
    }

    public async Task<Car> FindByIdAsync(int id)
    {
        return await Task.Run(() => { return FindById(id); });
    }

    public async Task UpdateAsync(Car car)
    {
        await Task.Run(() => { 
            var carToUpdate = FindById(car.Id);
            carToUpdate.Producer = car.Producer;
            carToUpdate.Name = car.Name;
            carToUpdate.Engine = car.Engine;
            carToUpdate.EnginePower = car.EnginePower;
            carToUpdate.AmountOfCylinders = car.AmountOfCylinders;
            carToUpdate.Color = car.Color;
            carToUpdate.ProducedDate = car.ProducedDate;
            carToUpdate.Available = car.Available;
            carToUpdate.Image = car.Image;
        });
    }

    public async Task<byte[]?> GetPhoto(int id)
    {
        return await Task.Run(() => {
            var car = FindById(id);
            return car.Image;
        });
    }
}
