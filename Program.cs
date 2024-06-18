using EcoTaxiAPI.Middleware;
using EcoTaxiAPI.Services;
using Microsoft.Extensions.Options;

string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
    policyBuilder => policyBuilder.WithOrigins(
                        "http://www.ecotaxi.tj", 
                        "https://www.ecotaxi.tj",
						"http://ecotaxi.tj",
						"https://ecotaxi.tj",
						"http://www.ecotaxi.tj/",
						"https://www.ecotaxi.tj/")
					  .AllowAnyMethod()
                      .AllowAnyHeader()); ;
});

//load configuration
var configuration = builder.Configuration;

// Configure SMTP settings
builder.Services.Configure<SmtpSettings>(configuration.GetSection("SmtpSettings"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Register TemplateService 
string templatePath = Path.Combine(builder.Environment.ContentRootPath, "Templates", "AnketaTemplate.docx");
builder.Services.AddSingleton<ITemplateService>(sp => { 
    var smtpSettings = sp.GetRequiredService<IOptions<SmtpSettings>>().Value;
    return new TemplateService(templatePath, smtpSettings);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Register Middleware
app.UseMiddleware<ExceptionMiddleware>();

//enable CORS
app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
