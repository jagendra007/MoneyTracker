using Microsoft.EntityFrameworkCore;
using MoneyTracker.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Injection for DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzUyMTE5NkAzMjMwMmUzNDJlMzBKR3BZMm1XS09hNkFLMkl2SDNVeFQ2WlZEdlpSVUs4VGhIc0E5eEFwcEkwPQ==;MzUyMTE5N0AzMjMwMmUzNDJlMzBSdjJOREwrQmlESWtsL1dDYkJxd29MWTNuWDRlS2hsNTdFQm51NE9vNUw4PQ==;Mgo+DSMBaFt/QHRqVVhlWFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQFliSX5adkVgXXpbd3xSRw==;Mgo+DSMBPh8sVXJ0S0J+XE9BclRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3pSdkVqWX9ddHFQQWlVUA==;ORg4AjUWIQA/Gnt2VVhkQlFac1tJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxXd0VjUH9ec3BQQ2dVWEU=;NRAiBiAaIQQuGjN/V0Z+WE9EaFpGVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RckRjWXZecHdRQ2VUUEBx;MzUyMTIwMkAzMjMwMmUzNDJlMzBOaDVHS0RaOHJxVkR6UE9zdllVcXVEeEptejEwd2dCMmNtOUw5eFFOdGZVPQ==;MzUyMTIwM0AzMjMwMmUzNDJlMzBVY2ZwMFZ1RVk3WGlHcSt0RXBEMXJsSnlzYVZpQXZsWnJIWmVPbXZ2cTI0PQ==;Mgo+DSMBMAY9C3t2VVhkQlFac1tJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxXd0VjUH9ec3BQQ2hbVkI=;MzUyMTIwNUAzMjMwMmUzNDJlMzBUZVpFdm1oVi9TVkJoS205S1FxNzFPcEZCa2dma0ZtVmJwWllhdmN3cnZZPQ==;MzUyMTIwNkAzMjMwMmUzNDJlMzBrQVNxSU84V0N2VEdFbVU4REk2UjIwemMvblYrQ0JVRmVCMm12MndpYTZrPQ==;MzUyMTIwN0AzMjMwMmUzNDJlMzBOaDVHS0RaOHJxVkR6UE9zdllVcXVEeEptejEwd2dCMmNtOUw5eFFOdGZVPQ==");
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
