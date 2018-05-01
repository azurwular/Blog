﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBA.AP.Blog.Domain.Repositories;
using CBA.AP.Blog.Infrastructure;
using CBA.AP.Blog.Infrastructure.Options;
using CBA.AP.Blog.Infrastructure.Repositories;
using CBA.AP.Blog.Services;
using CBA.AP.Blog.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CBA.AP.Blog
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables();
            
            this.Configuration = builder.Build();
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<DbOptions>(options =>
                options.ConnectionString = this.Configuration.GetConnectionString("MySQL"));

            services.AddSingleton<DbContext>();
            
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IBlogService, BlogService>();
            
            services.AddMvc();
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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}