using Microsoft.EntityFrameworkCore;

namespace Breeze_Soft_Test_Task.Data;
public class NpgSqlDataContext : DbContext
{
    public NpgSqlDataContext(DbContextOptions<NpgSqlDataContext> options)
        : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; } = default!;
}