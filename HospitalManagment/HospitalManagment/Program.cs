var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//var ProjectName = builder.Configuration["ProjectName"]; // To get the variable from app settings file
var ProjectName = builder.Configuration["ConnectionString:KeyName"]; // To get the variable from section in the app settings file
//var ProjectName = builder.Configuration.GetSection("ConnectionString:KeyName").Value; // To get the variable from section in the app settings file
var app = builder.Build();
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{Action=Index}"
    );
app.MapGet("/",()=> ProjectName);
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
