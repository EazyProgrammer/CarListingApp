using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarListingApp.API.Data;

public class CarListDBContext : IdentityDbContext
{
    List<string> roles = new List<string>() { "Administrator", "User" };
    List<string> RoleIds = new();
    List<string> UserIds = new();

    public CarListDBContext(DbContextOptions<CarListDBContext> options) : base(options) { }

    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        GenerateIds();

        modelBuilder.Entity<Car>().HasData(SeedCars());
        modelBuilder.Entity<IdentityRole>().HasData(SeedRoles());
        modelBuilder.Entity<IdentityUser>().HasData(SeedUsers());
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(SeedUserRoles());
    }

    private void GenerateIds()
    {
        for (int i = 0; i < 2; i++)
            RoleIds.Add(Guid.NewGuid().ToString());

        for (int i = 0; i < 2; i++)
            UserIds.Add(Guid.NewGuid().ToString());
    }

    private List<Car> SeedCars()
    {
        var cars = new List<Car>();

        for (int i = 1; i < 101; i++)
            cars.Add(new Car { Id = i, Make = $"Make {i}", Model = $"Model {i}", Vin = Guid.NewGuid().ToString().ToUpper() });

        return cars;
    }

    private List<IdentityRole> SeedRoles()
    {
        var count = 0;
        var userRoles = new List<IdentityRole>();

        foreach (var r in roles)
        {
            userRoles.Add(new IdentityRole
            {
                Id = RoleIds[count],
                Name = r,
                NormalizedName = r.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });

            count++;
        }
            

        return userRoles;
    }

    private List<IdentityUser> SeedUsers()
    {
        var hasher = new PasswordHasher<IdentityUser>();
        var users = new List<IdentityUser>();
        var domain = "@localhost.com";
        var count = 0;

        foreach (var r in roles)
        {
            users.Add(new IdentityUser
            {
                Id = UserIds[count],
                Email = $"{r.ToLower()}{domain}",
                NormalizedEmail = $"{r.ToLower()}{domain}".ToUpper(),
                NormalizedUserName = $"{r.ToLower()}{domain}".ToUpper(),
                UserName = $"{r.ToLower()}{domain}",
                PasswordHash = hasher.HashPassword(null, r),
                EmailConfirmed = true
            });

            count++;
        }

        return users;
    }

    private List<IdentityUserRole<string>> SeedUserRoles()
    {
        var userRoles = new List<IdentityUserRole<string>>();
        var count = 0;

        foreach (var r in roles)
        {
            userRoles.Add(new IdentityUserRole<string>
            {
                RoleId = RoleIds[count],
                UserId = UserIds[count]
            });

            count++;
        }

        return userRoles;
    }
}
