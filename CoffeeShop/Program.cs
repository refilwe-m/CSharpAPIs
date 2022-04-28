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
app.MapGet("/birthdays/{m}", (int m) => CoffeeShopController.CountAllBirthdays(m));
app.MapGet("/countallorders", () => CoffeeShopController.CountAllOrders());
app.MapGet("/countallcustomers", () => CoffeeShopController.CountAllCoustomers());
app.MapGet("/countallbaristas", () => CoffeeShopController.CountAllBaristas());

app.MapPost("/addorder", (CoffeeShop.Controllers.Order order) => CoffeeShopController.AddOrder(order));
app.MapPost("/addcustomer", (CoffeeShop.Controllers.Customer customer) => CoffeeShopController.AddCustomer(customer));
app.MapPost("/addbarista", (CoffeeShop.Controllers.Barista barista) => CoffeeShopController.AddBarista(barista));

app.MapDelete("/deleteorder/{id}", (int id) => CoffeeShopController.DeleteOrder(id));
app.MapDelete("/deletecustomer/{id}", (int id) => CoffeeShopController.DeleteCustomer(id));
app.MapDelete("/deletebarista/{id}", (int id) => CoffeeShopController.DeleteBarista(id));

app.MapPut("/updateorder/{id}", (int id, CoffeeShop.Controllers.Order order) => CoffeeShopController.UpdateOrder(order,id));
app.MapControllers();

app.Run();
