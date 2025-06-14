using FluentValidation.AspNetCore;
using Innovision_Dashboard.API.Attributes;
using Innovision_Dashboard.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

namespace Innovision_Dashboard.API;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddAppBuilder(this WebApplicationBuilder builder)
    {
        string connString = builder.Configuration.GetConnectionString("AddressDb");

        builder.Services.AddConfiguration(builder.Configuration);

        builder.Services.AddApiVersioning(setup =>
        {
            setup.DefaultApiVersion = new ApiVersion(1, 0);
            setup.AssumeDefaultVersionWhenUnspecified = true;
            setup.ReportApiVersions = true;
        });

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: "allOrigin",
            policy =>
            {
                policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            });
        });

        builder.Services.AddSwaggerGen(opts =>
        {
            opts.SwaggerDoc("v1", new OpenApiInfo { Title = "HappyPlay.API.GATEWAY", Version = "version 1.0" });
            opts.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            opts.OperationFilter<FileUploadOperation>();
            opts.OperationFilter<OptionalRouteParameterOperationFilter>();
            opts.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type=ReferenceType.SecurityScheme,
                            Id="Bearer"
                        }
                    },
                    new string[]{}
                }
            });

            // var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
            // var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            // opts.IncludeXmlComments(xmlPath);
        });

        builder.Services.AddAuthentication();

        builder.Services.AddControllers(options =>
            options.Filters.Add<ApiExceptionFilterAttribute>())
            .AddFluentValidation()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            });

        builder.Services.AddMemoryCache();

        return builder;
    }
}