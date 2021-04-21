using System;
using Ine.Sih.Csi.Areas.Identity.Data;
using Ine.Sih.Csi.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Ine.Sih.Csi.Areas.Identity.IdentityHostingStartup))]
namespace Ine.Sih.Csi.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IneSihCsiContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IneSihCsiContextConnection")));

                services.AddDefaultIdentity<IneSihCsiUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IneSihCsiContext>();
            });
        }
    }
}