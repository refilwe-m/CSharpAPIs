using CoffeeShop.Controllers;
using CoffeeShop.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseRouting();

app.MapGet("/orders", () => CoffeeShopController.GetAllOrders());
app.MapGet("/customers", () => CoffeeShopController.GetAllCustomers());
app.MapGet("/baristas", () => CoffeeShopController.GetAllBaristas());
app.MapGet("/africans", () => CoffeeShopController.CountAllAfricans());


app.MapPost("/addorder", (CoffeeShop.Controllers.Order order) => CoffeeShopController.AddOrder(order));
app.MapDelete("/deleteorder/{id}", (int id) => CoffeeShopController.DeleteOrder(id));

app.MapControllers();

app.Run();
