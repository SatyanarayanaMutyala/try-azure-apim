using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using QTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QTraining.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            await AddTestData(services.GetRequiredService<QTrainingDBContext>());
        }
        public static async Task AddTestData(QTrainingDBContext context)
        {
            if (context.Sessions.Any())
                return;
            context.Sessions.Add(new Session
            {
                Id = Guid.NewGuid(),
                Name = "ASP.NET Core Fundamentals",
                Credits = 3.0M,
                Category = "ASP.NET Core"
            }) ;

            context.Sessions.Add(new Session
            {
                Id = Guid.NewGuid(),
                Name = "ASP.NET Core Web API",
                Credits = 2.0M,
                Category = "ASP.NET Core"
            });

            context.Sessions.Add(new Session
            {
                Id = Guid.NewGuid(),
                Name = "ASP.NET Core MVC",
                Credits = 2.0M,
                Category = "ASP.NET Core"
            });

            await context.SaveChangesAsync();
        }
    }
}
