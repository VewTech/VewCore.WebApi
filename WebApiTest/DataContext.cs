using Microsoft.EntityFrameworkCore;
using VewTech.VewCore.WebApi.WebApiTest.Models;

namespace VewTech.VewCore.WebApi.WebApiTest;

public class DataContext(DbContextOptions<DataContext> dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<TestModel> TestModels { get; set; }
}