using UIJP.Modules.Post;
using UIJP.Modules.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddUserModule();
builder.Services.AddPostModule();

// Configure AutoMapper

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

app.Run();
