namespace Breeze_Soft_Test_Task.Domain;

public interface IRepository<T>
{
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<T> FindByIdAsync(int id);
    public Task UpdateAsync(T inst);
    public Task<byte[]?> GetPhoto(int id);
}
