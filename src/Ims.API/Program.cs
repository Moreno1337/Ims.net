using Ims.Application.Clients.Commands;
using Ims.Infrastructure;
using Ims.Domain.Interfaces;
using Ims.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// DB
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("ImsDb"));

// MediatR
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(AddClientCommand).Assembly);
});

// Repository
builder.Services.AddScoped<IClientRepository, ClientRepository>();

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

app.MapControllers();

app.MapPost("/clients", async (AddClientCommand command, IMediator mediator) =>
{
    var id = await mediator.Send(command);
    return Results.Created($"/clients/{id}", new { id });
});

app.Run();
