var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add CORS support
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Optional: Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Optional: Enable Swagger in Development mode
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Serve default files like index.html in the wwwroot directory
app.UseDefaultFiles();

// Serve static files (e.g., CSS, JS, images) from wwwroot
app.UseStaticFiles();

// Force HTTPS redirection
app.UseHttpsRedirection();

// Enable routing
app.UseRouting();

// Use CORS
app.UseCors("AllowAll");

// Enable authorization
app.UseAuthorization();

// Map API controllers
app.MapControllers();

// Fallback for SPA routes � routes that don't match the API will serve index.html
app.MapFallbackToFile("index.html");

app.Run();
