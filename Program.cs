using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using ProjektBoat.Interfaces;
using ProjektBoat.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IBoatRepository, JsonBoatRepository>();
builder.Services.AddSingleton < IEventRepository, JsonEventRepository>();
builder.Services.AddTransient<IBookingRepository, JsonBookingRepository>();
builder.Services.AddSingleton<LogInRepository>();
builder.Services.AddTransient<IBlog,JsonBlogRepository>();
builder.Services.AddTransient<IMemberRepository, JsonMemberRepository>();

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
