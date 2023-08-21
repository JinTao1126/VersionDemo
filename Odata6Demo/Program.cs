
using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using VersionDemo.Services;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OData.ModelBuilder;

namespace VersionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                .AddOData(options =>
            options.Select().Filter().OrderBy())
            //.AddOData(options => options.AddRouteComponents("v{version}", edmModel))    
                ;


            // version
            builder.Services.AddApiVersioning(
            options =>
            {
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
                options.UseApiBehavior = true;
            });


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddTransient<IDeviceService, DeviceService>();
            builder.Services.AddSwaggerGen(sa=>
            {
                sa.ResolveConflictingActions(s => s.Last());
            });

            

            var app = builder.Build();

            //Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}