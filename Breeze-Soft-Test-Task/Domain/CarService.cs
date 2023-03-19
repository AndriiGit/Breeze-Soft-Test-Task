using AutoMapper;

namespace Breeze_Soft_Test_Task.Domain;
public class CarService
{
    private readonly IRepository<Data.Car> _repository;
    private readonly IMapper _mapper;

    public CarService(IRepository<Data.Car> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Car>> GetCarsAsync()
    {
        var cars = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<Car>>(cars);
    }

    public async Task<Car> FindByIdAsync(int id)
    {
        var car = await _repository.FindByIdAsync(id);
        return _mapper.Map<Car>(car);
    }

    public async Task UpdateCar(Car car)
    {
        await _repository.UpdateAsync(_mapper.Map<Data.Car>(car));
    }

    public async Task<byte[]?> GetPhoto(int id)
    {
        return await _repository.GetPhoto(id);
    }
}
