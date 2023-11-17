using CarListingApp.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServiceCollections(builder.Configuration);

var app = builder.Build();

ApplicationMiddleWare.BootStrapMiddleware(ref app);

app.Run();
