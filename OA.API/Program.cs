using Microsoft.EntityFrameworkCore;
using OA.API.MiddleWare;
using OA.Domain.Repositories;
using OA.Infra.Persistence;
using OA.Infra.Persistence.Repositories;
using OA.Services;
using OA.Services.Abstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddDbContextPool<ApplicationDbContext>(builder =>
{
    var ConnectionString = "";
    builder.UseSqlServer(ConnectionString);
}
);
builder.Services.AddTransient<ExceptionHandlingMiddleware>();

builder.Services.AddControllers().AddApplicationPart(typeof(OA.Infra.Presentation.AssemblyReference).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
