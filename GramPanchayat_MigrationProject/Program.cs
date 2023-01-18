using GramPanchayat_MigrationProject.API.Data;
using GramPanchayat_MigrationProject.API.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<GramPanchayatDBContext>(options =>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("constring"));
});

builder.Services.AddScoped<ILoginRepository,LoginRepository>();
builder.Services.AddScoped<IMarriageRegRepository,MarriageRegRepository>();
builder.Services.AddScoped<IDeadBirthRepository,DeadBirthRepository>();
builder.Services.AddScoped<IDeathRegRepository,DeathRegRepository>();
builder.Services.AddScoped<IPropertyTaxRepository,PropertyTaxRepository>();
builder.Services.AddScoped<IBirthRegRepository,BirthRegRepository>();
builder.Services.AddScoped<IAssasmenttaxRepository,AssasmenttaxRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors();
app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) // allow any origin
                    .AllowCredentials()); // allow credentials

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
