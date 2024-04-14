using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using WebQuanLyNhaKhoa.Data;
using Microsoft.AspNetCore.Identity;
using WebQuanLyNhaKhoa.Data.QlnhaKhoaContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<QlnhaKhoaContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("NKhoa"));
});

builder.Services.AddDefaultIdentity<TaiKhoan>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<cs>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
.AddDefaultTokenProviders()
.AddDefaultUI()
.AddEntityFrameworkStores<QlnhaKhoaContext>();

builder.Services.AddControllers(options =>
{
	options.ModelMetadataDetailsProviders.Add(new SystemTextJsonValidationMetadataProvider());
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options => {
		options.LoginPath = "/Login";
		options.AccessDeniedPath = "/AccessDenied";
							});

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
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
