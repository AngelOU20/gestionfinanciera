using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using gestion_financiera.Models;

namespace gestion_financiera.Data
{
    //dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 3.1.4
    //dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 3.1.4
    //dotnet add package Microsoft.EntityFrameworkCore --version 3.1.4
    //dotnet ef migrations add db
    //dotnet ef database update
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<usuario> usuario { get;set; }
    }
}
