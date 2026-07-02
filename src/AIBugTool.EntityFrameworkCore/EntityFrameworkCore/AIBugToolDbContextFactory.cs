using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AIBugTool.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AIBugToolDbContextFactory : IDesignTimeDbContextFactory<AIBugToolDbContext>
{
    public AIBugToolDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AIBugToolEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AIBugToolDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));
        
        return new AIBugToolDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AIBugTool.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}
