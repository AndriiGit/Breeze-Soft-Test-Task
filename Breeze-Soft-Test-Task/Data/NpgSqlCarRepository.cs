using Breeze_Soft_Test_Task.Domain;
using Microsoft.EntityFrameworkCore;

namespace Breeze_Soft_Test_Task.Data;
public class NpgSqlCarRepository : IRepository<Car>
{
    private NpgSqlDataContext _context;
    public NpgSqlCarRepository(NpgSqlDataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Car>> GetAllAsync()
    {
        return await _context.Cars.ToListAsync();
    }

    public async Task<Car> FindByIdAsync(int id)
    {
        return await _context.Cars.FirstAsync(x => x.Id == id);
    }

    public async Task UpdateAsync(Car car)
    {
        _context.Attach(car).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
    public async Task<byte[]?> GetPhoto(int id)
    {
        var car = await _context.Cars.FirstAsync(x => x.Id == id);
        return car.Image;
    }
}
