using CarListingApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace CarListingApp.API
{
    public static class ApplicationMiddleWare
    {

        public static void BootStrapMiddleware(ref WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<CarListDBContext>())
                if (context != null)
                    context.Database.Migrate();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();
            app.UseSwaggerUI();
            //}

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors("AllowAll");

            ApplicatoinEndPoints.MapEndPoints(ref app);
        }
    }
}
