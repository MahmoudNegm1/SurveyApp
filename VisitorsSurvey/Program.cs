using Microsoft.EntityFrameworkCore;
using VisitorsSurvey.BLL;
using VisitorsSurvey.BLL.AppService;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.DLL;
using VisitorsSurvey.DLL.Data;

namespace VisitorsSurvey
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddAutoMapper(c => c.AddProfile<AutoMapping>());


            builder.Services.AddScoped<IVisitorReviewAppService, VisitorReviewAppService>();
            builder.Services.AddScoped<IParkAppService, ParkAppService>();
            builder.Services.AddScoped<ICityAppService, CityAppService>();
            builder.Services.AddScoped<IRegionAppService, RegionAppService>();
            builder.Services.AddScoped<IGovernateAppService, GovernateAppService>();
            builder.Services.AddScoped<IVisitorReviewItemsAppService, VisitorReviewItemsAppService>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddDbContextPool<AppDbContext>(options =>
                options.UseSqlServer(
               builder.Configuration.GetConnectionString("VisitorSurvey")));


            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Database.Migrate();
            }
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=VisitorReviews}/{action=save}/{id?}");

            app.Run();
        }
    }
}
