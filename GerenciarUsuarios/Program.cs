using GerenciarUsuarios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.ConfigureDI();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuario}/{action=Index}/{id?}");

app.Run();
