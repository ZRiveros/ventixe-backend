var builder = WebApplication.CreateBuilder(args);

// Lägg till MVC-controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger-UI i development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Koppla controllers till routing
app.MapControllers();

app.Run();