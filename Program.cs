using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proiect3._0.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy =>
policy.RequireRole("Admin"));
});

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/Spectacole");
   
    options.Conventions.AuthorizeFolder("/Membri", "AdminPolicy");

    options.Conventions.AuthorizeFolder("/Locatii");
    options.Conventions.AuthorizeFolder("/Participari");
    options.Conventions.AuthorizeFolder("/Regizori");
    options.Conventions.AuthorizeFolder("/Tipuri");




});

// Configure the primary application database context
builder.Services.AddDbContext<Proiect3_0Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Proiect3_0Context")
    ?? throw new InvalidOperationException("Connection string 'Proiect3_0Context' not found.")));

// Configure the Identity database context
builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Proiect3_0Context")
    ?? throw new InvalidOperationException("Connection string 'Proiect3_0Context' not found.")));

// Add Identity services
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<LibraryIdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Ensure authentication middleware is added
app.UseAuthorization();

app.MapRazorPages();

app.Run();
