using Microsoft.EntityFrameworkCore;
using YummyTask.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RelationDbContext>(opt =>



opt.UseSqlServer("Server=LAPTOP-V6781U9D\\SQLEXPRESS01; Database=ElvinYummy; Integrated Security = true")

);
var app = builder.Build();




app.UseStaticFiles();


app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
      );

app.Run();


