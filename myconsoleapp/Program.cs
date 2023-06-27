using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder=new ConfigurationBuilder();
buildconfiguration(builder);

var host=Host.CreateDefaultBuilder().ConfigureServices((context,services)=>
{
    services.AddTransient<Isatya,SatYa>();
}
).Build();

var st=ActivatorUtilities.CreateInstance<SatYa>(host.Services);

st.readvalues();


static void buildconfiguration(ConfigurationBuilder build)
{
    build.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
}