using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repository;
using LanchesMac.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddMemoryCache();//HABILITANDO O MEMORYCACHE
builder.Services.AddSession();//AO USAR É NECESSÁRIO ATIVALO COM APP.USESESSION()
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoLocalDan"));
});
builder.Services.AddTransient<ILancheRepository, LancheRepository>();//
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();//SINGLETON => VALE POR TODO TEMPO DE VIDA DA APLICAÇÃO 


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

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//Existe uma falha no model, coloquei nome errado talvez isso possa afeta futuramente, então não apague as migrations