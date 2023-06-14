using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Models.Realization;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using AutoMapper;
using fireflower_backend;
using fireflower_backend.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
const string myAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddAutoMapper(typeof(AutoMapperController).Assembly);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.Cookie.Name = "check";
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


builder.Services.AddScoped<IShop, ShopModel>();
builder.Services.AddScoped<IProduct, ProductModel>();
builder.Services.AddScoped<IPayment,PaymentModel>();
builder.Services.AddScoped<IShop_Rating, Shop_RatingMode>();
builder.Services.AddScoped<IProduct_Rating, Product_RatingModel>();
builder.Services.AddScoped<IAuth, AuthModel>();
builder.Services.AddScoped<IMalling, MallingModel>();
builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:5277");
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(myAllowSpecificOrigins);
app.UseHttpsRedirection();
app.UseSession();
app.UseAuthorization();

app.MapControllers();

app.Run();
