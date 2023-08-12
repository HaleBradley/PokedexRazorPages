using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PokedexRazorPages.Data;
using PokedexRazorPages.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PokedexRazorPagesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PokedexRazorPagesContext") ?? throw new InvalidOperationException("Connection string 'PokedexRazorPagesContext' not found.")));
builder.Services.AddHttpClient<PokeApi>();
builder.Services.AddScoped<PokeApi>();

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
