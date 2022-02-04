var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.UseCors(builder => builder.WithOrigins("http://localhost:4200" /* Angular */)
    .AllowAnyMethod()
    .AllowAnyHeader());

app.Run();
