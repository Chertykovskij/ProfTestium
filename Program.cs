using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProfTestium.Models.Contexts;

var builder = WebApplication.CreateBuilder(args);

//БД
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ProfTestiumContext>(options => options.UseSqlServer(connection));




// Add services to the container.
builder.Services.AddControllersWithViews();

// Работа с авторизированными пользователями
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ProfTestiumContext>();

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

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
