using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace StateExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }
        
        //pipeline
        public void Configure(IApplicationBuilder app)
        {
            SessionOptions options = new SessionOptions();
            options.IdleTimeout = TimeSpan.FromMinutes(10.0);
            app.UseSession(options);
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
