﻿using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Extensions
{
    public static class ApplicationExtensions
    {
        public static void AddApplicationServices(this IHostApplicationBuilder builder)
        {
            builder.Services.AddDbContext<CatalogDbContext>(configure =>
            {
                configure.UseSqlServer(builder.Configuration.GetConnectionString(CatalogDbContext.DefaultConnectionStringName));
            });
        }

    }
}
