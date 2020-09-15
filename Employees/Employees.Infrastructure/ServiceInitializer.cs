using Employees.Bl.Interface;
using Employees.Bl.Services;
using Employees.Core;
using Employees.Dal.Context;
using Employees.Dal.Interface;
using Employees.Dal.Repository;
using Employees.Dal.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Employees.Infrastructure
{
    public static class ServiceInitializer
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<Employee>, Repository<Employee>>();
            services.AddScoped<IRepository<Position>, Repository<Position>>();
            
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IPositionService, PositionService>();

            var connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
        }
    }
}