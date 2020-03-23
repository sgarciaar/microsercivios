using log4net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MS_DAL_PERSON.DataContext;
using MS_DAL_PERSON.Imp;
using MS_DAL_PERSON.Service;
using MS_DAL_PERSON.Util;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Reflection;
/*
* Juan Garcia
* juan.garcia@zentagroup.com
* 
*/

namespace MS_DAL_PERSON
{
    public class Startup
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
                           
               
                services.AddCors(o => o.AddPolicy(Constants.Policy, builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                }));

                services.AddDbContext<GenericContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString(Constants.NameConnection),

                        sqlServerOptionsAction: sqlOptions =>
                        {
                            sqlOptions.UseRowNumberForPaging();
                            sqlOptions.
                            MigrationsAssembly(
                                typeof(Startup).
                                 GetTypeInfo().
                                  Assembly.
                                   GetName().Name);

                        
                        sqlOptions.
                                EnableRetryOnFailure(maxRetryCount: 5,
                                maxRetryDelay: TimeSpan.FromSeconds(30),
                                errorNumbersToAdd: null);

                        });



                   
                    options.ConfigureWarnings(warnings => warnings.Throw(
                            RelationalEventId.QueryClientEvaluationWarning));
                });               

                Logger.Info(Constants.ServiceStartup);
            services.AddTransient<IPersonService, ImpPerson>();
               

                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

                services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "SGS Api",
                    Description = "ASP.NET Core Web API for OL"

                });

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();

            //politica de cors
            app.UseCors(Constants.Policy);
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
                c.RoutePrefix = "swagger";
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
