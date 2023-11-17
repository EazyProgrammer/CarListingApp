using CarListingApp.API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CarListingApp.API
{
    public static class ApplicatoinEndPoints
    {
        public static void MapEndPoints(ref WebApplication app)
        {
            app.MapGet("/cars", async (CarListDBContext db) =>
            {
                var cars = await db.Cars.ToListAsync();
                return cars;
            });

            app.MapGet("/cars/{id}", async (int id, CarListDBContext db) => await db.Cars.FindAsync(id) is Car car ? Results.Ok(car) : Results.NotFound());

            app.MapPut("/cars/{id}", async (int id, Car car, CarListDBContext db) =>
            {
                var record = await db.Cars.FindAsync(id);

                if (record == null) return Results.NotFound();

                record.Make = car.Make;
                record.Model = car.Model;
                record.Vin = car.Vin;

                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            app.MapDelete("/cars/{id}", async (int id, CarListDBContext db) =>
            {
                var record = await db.Cars.FindAsync(id);

                if (record == null) return Results.NotFound();

                db.Remove(record);
                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            app.MapPost("/cars/", async (Car car, CarListDBContext db) =>
            {
                await db.AddAsync(car);
                await db.SaveChangesAsync();

                return Results.Created($"/cars/{car.Id}", car);
            });

            app.MapPost("/login", async (LoginDto loginDto, UserManager<IdentityUser> userManager, IConfiguration config) =>
            {
                var user = await userManager.FindByNameAsync(loginDto.UserName);

                if (user is null) return Results.Unauthorized();

                var isValidPassword = await userManager.CheckPasswordAsync(user, loginDto.Password);

                if (!isValidPassword) return Results.Unauthorized();

                //Generate access token
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JwtSettings:Key"] ?? throw new Exception("Error! Unable to find security key.")));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var roles = await userManager.GetRolesAsync(user);
                var claims = await userManager.GetClaimsAsync(user);

                var tokenClaims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email ?? throw new Exception("User Email is empty")),
                    new Claim("email_confirmed", user.EmailConfirmed.ToString())
                }.Union(claims)
                .Union(roles.Select(r => new Claim(ClaimTypes.Role, r)));

                var securityToken = new JwtSecurityToken(
                    issuer: config["JwtSettings:Issuer"], 
                    audience: config["JwtSettings:Audience"], 
                    expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(config["JwtSettings:DurationInMinutes"])),
                    signingCredentials: credentials,
                    claims: tokenClaims
                    );

                var token = new JwtSecurityTokenHandler().WriteToken(securityToken);

                var response = new AuthResponseDto
                {
                    UserId = user.Id,
                    UserName = loginDto.UserName,
                    Token = token
                };

                return Results.Ok(response);
            }).AllowAnonymous();
        }
    }
}
