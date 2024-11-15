using DemoPracticeMediatr.Command;
using DemoPracticeMediatr.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(efg => efg.RegisterServicesFromAssembly(typeof(Program).Assembly));

// builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(
//     typeof(AddProductHandler).Assembly,
//     typeof(GetProductByIdQuery).Assembly
//     ));

builder.Services.AddSingleton<MockProducts>();

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
