using Microsoft.EntityFrameworkCore;
using OA.Domain.Repositories;
using OA.Infra.Persistence;
using OA.Infra.Persistence.Repositories;
using OA.Services;
using OA.Services.Abstractions;
using OA.Web.MiddleWare;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
