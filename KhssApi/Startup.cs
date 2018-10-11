using System;
using khss.Services;
using Khss.ServiceContracts;
using KhssData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KhssApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddXmlDataContractSerializerFormatters();
            services.AddSingleton(Configuration);
            services.AddTransient<IAttendanceSystemService, AttendanceSystemService>();


            services.AddDbContext<KhssContext>(options
                => options.UseSqlServer(Configuration.GetConnectionString("KhssConnection"), opts
               => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)));
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

            //Use this method for redirec the http request 
            app.UseHttpsRedirection();
            //we add this into the middle layer to run api
            app.UseMvc();
        }
    }
}
