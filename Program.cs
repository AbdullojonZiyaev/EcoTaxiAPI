using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EcoTaxiAPI.Middleware;
using EcoTaxiAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//load configuration
var configuration = builder.Configuration;

// Configure SMTP settings
builder.Services.Configure<SmtpSettings>(configuration.GetSection("SmtpSettings"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
