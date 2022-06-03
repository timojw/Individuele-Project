using Abstraction_Layer;
using Microsoft.OpenApi.Models;
using System.Reflection;
using DAL_Layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DALContext = DAL_Layer.DALContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDelivererCollection, DelivererDAL>();
builder.Services.AddScoped<IDelivererCreation, DelivererDAL>();

builder.Services.AddDbContext<DALContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Context"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Order API",
        Description = "An API used for order management",
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

try
{
    using (IServiceScope serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope())
    {
        DbContext context = serviceScope.ServiceProvider.GetRequiredService<DALContext>();
        context.Database.Migrate();
    }
}
catch
{
    Console.WriteLine("An error occured during EF Migration, migration aborted");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
