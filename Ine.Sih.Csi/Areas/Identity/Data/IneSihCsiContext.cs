using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ine.Sih.Csi.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ine.Sih.Csi.Data
{
    public class IneSihCsiContext : IdentityDbContext<IneSihCsiUser>
    {
        public IneSihCsiContext(DbContextOptions<IneSihCsiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
