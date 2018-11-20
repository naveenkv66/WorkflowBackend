using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Workflow.Repository;
using Workflow.Domain.Contracts;
using Newtonsoft.Json.Serialization;

namespace WorkflowApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration); //IConfigurationRoot
            services.AddSingleton<IConfiguration>(Configuration);

            //Add Support for strongly typed Configuration and map to class
            services.AddOptions();
           // services.Configure<AppConfig>(Configuration.GetSection("AppConfig"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(opt =>
            {
                var resolver = opt.SerializerSettings.ContractResolver;
                if (resolver != null)
                {
                    var res = resolver as DefaultContractResolver;
                    res.NamingStrategy = null;
                }
            }); ;
            

            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DbClient.WorkflowDataContext>(c =>
                 c.UseSqlServer(connection));

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            }); 

            services.AddScoped(typeof(DbClient.WorkflowDataContext));
            services.AddScoped(typeof(IGenericRepository<>), typeof(RepositoryBase<>));     
            services.AddScoped(typeof(Workflow.Common.IAutoMapConverter<,>), typeof(Workflow.Common.AutoMapConverter<,>));

            services.AddScoped<Workflow.Repository.Contract.IWorkflowConfiguration, WorkFlowConfigurationRepository>();
            services.AddScoped<IWorkFlowConfigurationDomain,Workflow.Domain.WorkFlowConfigurationDomain>();
            services.AddScoped<Workflow.Repository.Contract.IUserRepository, UserRepository>();
            services.AddScoped<IUserDomain, Workflow.Domain.UserDomaian>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //Apply CORS.
            app.UseCors("CorsPolicy");
            app.UseMvc();
           

        }
    }
}
