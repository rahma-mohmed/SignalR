using SignalR.Hubs;

namespace SignalR
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			// register SignalR service
			builder.Services.AddSignalR();

			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			// Add SignalR route
			app.MapHub<ChatHub>("/chatHub");

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=chat}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
