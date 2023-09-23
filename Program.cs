using SureProfit.IndentityProvider.IndentityConfiguration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
    .AddInMemoryClients(Clients.Get())
    .AddInMemoryApiResources(Resources.GetApiResources())
    .AddInMemoryApiScopes(Scopes.GetApiScopes())
    .AddDeveloperSigningCredential();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.UseAuthorization();

app.Run();
