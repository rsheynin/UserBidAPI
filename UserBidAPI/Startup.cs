using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserBidAPI.DomainServices;
using UserBidAPI.Infrastructure;
using UserBidAPI.Model;
using UserBidAPI.Presentation;

namespace UserBidAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IRepository<User>, UserRepository>();
            services.AddSingleton<IRepository<Bid>, BidRepository>();
            services.AddSingleton<IRepository<UserBid>, UserBidRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IBidService, BidService>();
            services.AddTransient<IUserBidService, UserBidService>();

            services.AddTransient<IUserBidPresenter, UserBidPresenter>();
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
            app.UseMvc();
        }
    }
}
