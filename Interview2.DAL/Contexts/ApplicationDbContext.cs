using Interview2.Model.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview2.DAL.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
       : base(options)
    {
    }

    public DbSet<UrlInfo> Urls { get; set; }
}
