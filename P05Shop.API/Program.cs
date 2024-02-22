using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using P05Shop.API.Models;
using P05Shop.API.Services.AuthService;
using P06Shop.Shared.Services.ProductService;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IProductService,P05Shop.API.Services.ProductService>();
builder.Services.AddScoped<IAuthService,AuthService>();

// addScoped - oznacza, że w trakcie jednego requestu będzie istniała tylko jedna instancja klasy ProductService
// addTransient - oznacza, że obiekt będzie tworzony za każdym razem, gdy odwolujemy się do niego
// addSingleton - oznacza, że obiekt będzie tworzony tylko raz i będzie istniał tak długo, jak długo istnieje aplikacja


// dodajemy autentykacje 

string token =builder.Configuration.GetSection("AppSettings:Token").Value;
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(token)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });


// pozwalamy na wykonywanie zapytań z innych domen
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
// gdybysmy chcieli ograniczyc dostep do API tylko do naszej aplikacji, to wtedy:
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAll", builder =>
//    {
//        builder.WithOrigins("http://mySite.pl");
//        builder.AllowAnyMethod();
//        builder.AllowAnyHeader();
//    });
//});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
