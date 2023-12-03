using Microsoft.OpenApi.Models;

using Pavon.Grpc.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddGrpcSwagger();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo { Title = "gRPC transcoding", Version = "v1" });
});


builder.Services.AddCors(options =>
{
    options.AddPolicy("Pavon", policy =>
    {
        policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});
var app = builder.Build();


app.UseCors("Pavon");
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

// Configure the HTTP request pipeline.
app.MapGrpcService<CategoriesService>();

app.UseRouting();

app.Run();
