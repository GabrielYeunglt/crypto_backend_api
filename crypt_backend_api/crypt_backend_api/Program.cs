using crypt_backend_api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<CryptoService>();

var kestrelConfig = builder.Configuration.GetSection("Kestrel:Endpoints:Https");
string certPath = kestrelConfig["Certificate:Path"];
string certPassword = kestrelConfig["Certificate:Password"]; 
if (!string.IsNullOrEmpty(certPath) && !string.IsNullOrEmpty(certPassword))
{
    builder.WebHost.ConfigureKestrel(options =>
    {
        options.ListenAnyIP(5001, listenOptions =>
        {
            listenOptions.UseHttps(certPath, certPassword);
        });
    });
}

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

app.Run();
