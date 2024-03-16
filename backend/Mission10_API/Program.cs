using Microsoft.EntityFrameworkCore;
using Mission10_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

builder.Services.AddDbContext<BowlerContext>(options =>

    options.UseSqlite(builder.Configuration["ConnectionStrings:BowlerConnection"])
);

builder.Services.AddScoped<IBowlerRepository, EFBowlerRepository>(); // as the client logges on and tries to grab an instancew grab the generic and create and instance of EF reopsitory so each person ahs their own instance with their spesific data

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// may need to change url
app.UseCors(p => p.WithOrigins("http://localhost:3000"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
