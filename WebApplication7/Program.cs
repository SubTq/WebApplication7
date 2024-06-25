using Microsoft.EntityFrameworkCore;
using WebApplication7.Data;


var builder = WebApplication.CreateBuilder(args);

// Dodanie us³ug do kontenera DI
builder.Services.AddControllersWithViews();

// Konfiguracja Entity Framework Core z u¿yciem SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Konfiguracja potoku przetwarzania ¿¹dañ HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();