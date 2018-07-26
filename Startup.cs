namespace AspNetCoreTest
{
	using Microsoft.AspNetCore.Builder;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.AspNetCore.Http;
	using Microsoft.Extensions.DependencyInjection;
	using System.Diagnostics;
	//using Microsoft.AspNetCore.Server.IIS;

	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!\n\n");
				await context.Response.WriteAsync($"Hello World from {Process.GetCurrentProcess().ProcessName}\n\n");
				// accessing IIS server variables
				//await context.Response.WriteAsync("Server Variables:" + Environment.NewLine);
				//foreach (var varName in IISServerVarNames)
				//{
				//	await context.Response.WriteAsync(varName + ": " + context.GetIISServerVariable(varName) + Environment.NewLine);
				//}
			});
		}
	}
}