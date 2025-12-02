using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5075");

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors();

app.MapGet("/cats", () => new[]
{
    new Cat("Julius"),
    new Cat("Henry"),
    new Cat("Leon"),
    new Cat("Milo"),
    new Cat("Luna"),
    new Cat("Oliver"),
    new Cat("Bella"),
    new Cat("Charlie"),
    new Cat("Lucy"),
    new Cat("Max"),
    new Cat("Chloe"),
    new Cat("Simba"),
    new Cat("Nala"),
    new Cat("Tiger"),
    new Cat("Shadow"),
    new Cat("Whiskers"),
    new Cat("Smokey"),
    new Cat("Ginger"),
    new Cat("Cleo"),
    new Cat("Zoe"),
    new Cat("Loki"),
    new Cat("Oreo"),
    new Cat("Pumpkin"),
    new Cat("Midnight"),
    new Cat("Sassy"),
    new Cat("Willow"),
    new Cat("Jasper"),
    new Cat("Bailey"),
    new Cat("Mocha"),
    new Cat("Poppy"),
    new Cat("Hazel"),
    new Cat("Finn"),
    new Cat("Misty"),
    new Cat("Storm"),
    new Cat("Cocoa"),
    new Cat("Snowball"),
    new Cat("Boots"),
    new Cat("Pepper"),
    new Cat("Scout"),
    new Cat("Maple"),
    new Cat("River"),
    new Cat("Dusty"),
    new Cat("Toby"),
    new Cat("Felix"),
    new Cat("Bandit"),
    new Cat("Casper"),
    new Cat("Amber"),
    new Cat("Stella"),
    new Cat("Rosie"),
    new Cat("Harley"),
    new Cat("Tigger"),
    new Cat("Mochi"),
    new Cat("Pumpkin"),
    new Cat("Salem"),
    new Cat("Blu"),
    new Cat("Moony"),
    new Cat("Raven"),
    new Cat("Sushi"),
    new Cat("Mango"),
    new Cat("Fig"),
    new Cat("Sprout"),
    new Cat("Pebble"),
    new Cat("Marble"),
    new Cat("Socks"),
    new Cat("Cotton"),
    new Cat("Cricket"),
    new Cat("Sunny"),
    new Cat("Dusty"),
    new Cat("Fiona"),
    new Cat("Izzy"),
    new Cat("Archie"),
    new Cat("George"),
    new Cat("Marley"),
    new Cat("Trixie"),
    new Cat("Basil"),
    new Cat("Pluto"),
    new Cat("Freckles"),
    new Cat("Bubbles"),
    new Cat("Echo"),
    new Cat("Fable"),
    new Cat("Nugget"),
    new Cat("Tango"),
    new Cat("Copper"),
    new Cat("Lemon"),
    new Cat("Waffles"),
    new Cat("Mittens"),
    new Cat("Hobbes"),
    new Cat("Pixel"),
    new Cat("Bug"),
    new Cat("Mallow"),
    new Cat("Cinder"),
    new Cat("Nova"),
    new Cat("Onyx"),
    new Cat("Daisy"),
    new Cat("Pearl"),
    new Cat("Piper"),
    new Cat("Frost"),
    new Cat("Teddy"),
    new Cat("Opal"),
    new Cat("Sage"),
    new Cat("Holly")
});


app.Run();

record Cat(string Name);

