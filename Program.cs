var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.UseCors(builder => builder.WithOrigins("http://localhost:4200", "http://localhost:8080")
    .AllowAnyMethod()
    .AllowAnyHeader());

app.Run();
