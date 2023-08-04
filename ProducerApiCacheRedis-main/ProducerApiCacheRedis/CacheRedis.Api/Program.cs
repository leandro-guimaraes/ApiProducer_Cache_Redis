using System.Security.Authentication;
using CacheRedis.Api.DbContexts;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CotacaoContext>(options =>
{
    options.UseNpgsql("Host=localhost;Database=allog_cotacao;Username=postgres;Password=123456");
});

builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.SetKebabCaseEndpointNameFormatter();
    busConfigurator.UsingRabbitMq((context, busFactoryConfigurator) =>
    {
        busFactoryConfigurator.Host("jackal-01.rmq.cloudamqp.com", 5671, "orxcfbhg", h =>
        {
            h.Username("orxcfbhg");
            h.Password("Sn0ws-oL3UwS2hW76Bo6Bby-Yhl2MDKD");

            h.UseSsl(s =>
            {
                s.Protocol = SslProtocols.Tls12;
            });
        });
    });
});

builder.Services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect("redis-16293.c308.sa-east-1-1.ec2.cloud.redislabs.com:16293,password=TYBXhsGEBphN89wCBpmsHkbxDkWRjk1Q"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
