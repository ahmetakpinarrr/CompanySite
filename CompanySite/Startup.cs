using CommerceNet.Helpers;
using CompanySite.AppData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanySite {
    public class Startup {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private static string ConnectionString;

        public void ConfigureServices (IServiceCollection services)
        {
            ConnectionString = Configuration.GetConnectionString("AppDbContext");
            services.AddControllersWithViews();
            services.AddDbContext<develops_OPALFAContext>(op => op.UseSqlServer(ConnectionString));
            services.AddTransient<EmailSender , EmailSender>(i =>
               new EmailSender(
                   Configuration["EmailSender:Host"] ,
                   Configuration.GetValue<int>("EmailSender:Port") ,
                   Configuration.GetValue<bool>("EmailSender:EnableSSL") ,
                   Configuration["EmailSender:UserName"] ,
                   Configuration["EmailSender:Password"]
               ));
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
                options.Cookie.IsEssential = true;
            });

        }

        public void Configure (IApplicationBuilder app , IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default" ,
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
