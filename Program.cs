using ExtraPoints_Grillino.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine(connection);
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

// Add services to the container.
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();




app.UseStaticFiles();

app.UseStatusCodePagesWithRedirects("/Error");

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
