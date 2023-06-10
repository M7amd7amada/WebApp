var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.EnableSensitiveDataLogging(true);
});

var app = builder.Build();

var context = app.Services.CreateScope().ServiceProvider
    .GetRequiredService<AppDbContext>();
SeedData.SeedDatabase(context);

app.Run();
