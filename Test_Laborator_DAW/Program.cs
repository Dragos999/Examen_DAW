using Microsoft.EntityFrameworkCore;
using Test_Laborator_DAW.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<myContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options => options.AddPolicy("ANGperm",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }
    ));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ANGperm");
app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseAuthorization();

app.MapControllers();

app.Run();
