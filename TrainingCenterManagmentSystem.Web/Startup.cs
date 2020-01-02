using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using TrainingCenterManagementSystem.Services.Interfaces;
using TrainingCenterManagementSystem.Services.Implementation;
using TrainingCenterManagementSystem.Infrastructure.Data;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Infrastructure.Repositories;

namespace TrainingCenterManagmentSystem.Web
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
            services.AddDbContext<TMSDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            services.AddScoped<ICourseCategoriesRepository, CourseCategoriesRepository>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IDeleveryTypeService, DeleveryTypeService>();
            services.AddScoped<IDeleveryTypesRepository, DeleveryTypesRepository>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IExamRepository, ExamsRepository>();
            services.AddScoped<ILabService, LabService>();
            services.AddScoped<ILabsRepository, LabsRepository>();
            services.AddScoped<ILearningPathService, LearningPathService>();
            services.AddScoped<ILearningPathRepository, LearningPathRepository>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IMaterialsRepository, MaterialsRepository>();
            services.AddScoped<IPriceTypeService, PriceTypeService>();
            services.AddScoped<IPriceTypesRepository, PriceTypesRepository>();

            services.AddControllers();
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(
                options => options.SetIsOriginAllowed(x => _ = true).AllowAnyMethod().AllowAnyHeader().AllowCredentials()
            );

        //    app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

}
