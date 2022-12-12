using ProjektBoat.Interfaces;
using ProjektBoat.Models;

using ProjektBoat.Interfaces;
using ProjektBoat.Services;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton < IEventRepository, EventRepository>();
builder.Services.AddTransient<IBookingRepository, JsonBookingRepository>();

builder.Services.AddTransient<IBlog,JsonBlogRepository>();

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

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
