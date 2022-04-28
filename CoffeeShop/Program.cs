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

app.MapGet("/orders", () => CoffeeShopController.GGetAllOrders());
app.MapGet("/customers", () => CoffeeShopController.GGetAllCustomers());
app.MapGet("/baristas", () => CoffeeShopController.GGetAllBaristas());
app.MapGet("/birthdays/{m}", (int m) => CoffeeShopController.GCountAllBirthdays(m));
app.Map("/africans", () => CoffeeShopController.GCountAllAfricans());
app.MapGet("/countallorders", () => CoffeeShopController.GCountAllOrders());
app.MapGet("/countallcustomers", () => CoffeeShopController.GCountAllCoustomers());
app.MapGet("/countallbaristas", () => CoffeeShopController.GCountAllBaristas());

app.MapPost("/addorder", (CoffeeShop.Utilities.Order order) => CoffeeShopController.PAddOrder(order));
app.MapPost("/addcustomer", (CoffeeShop.Utilities.Customer customer) => CoffeeShop.Controllers.CoffeeShopController.PAddCustomer(customer));
app.MapPost("/addbarista", (CoffeeShop.Utilities.Barista barista) => CoffeeShopController.PAddBarista(barista));
app.MapPost("/saveFile", () => CoffeeShopController.PSaveToFile());

app.MapDelete("/deleteorder/{id}", (int id) => CoffeeShopController.DDeleteOrder(id));
app.MapDelete("/deletecustomer/{id}", (int id) => CoffeeShopController.DDeleteCustomer(id));
app.MapDelete("/deletebarista/{id}", (int id) => CoffeeShopController.DDeleteBarista(id));

app.MapPut("/updateorder/{id}", (int id, CoffeeShop.Utilities.Order order) => CoffeeShopController.UUpdateOrder(order,id));
app.MapPut("/updatecustomer/{id}", (int id, CoffeeShop.Utilities.Customer customer) => CoffeeShopController.UUpdateCustomer(customer,id));
app.MapPut("/updatebarista/{id}", (int id, CoffeeShop.Utilities.Barista barista) => CoffeeShopController.UUpdateBarista(barista,id));

app.MapControllers();

app.Run();
