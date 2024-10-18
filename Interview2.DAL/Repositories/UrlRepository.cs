using Interview2.DAL.Contexts;
using Interview2.DAL.Contracts;
using Interview2.Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview2.DAL.Repositories;

public class UrlRepository(ApplicationDbContext dbContext) : IUrlRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public void Add(UrlInfo url)
    {
        dbContext.Add(url);
        dbContext.SaveChanges();
    }

    public UrlInfo Get(string link)
    {
        return dbContext.Urls.FirstOrDefault(u => u.Url == link);
    }

    public void Update(UrlInfo url)
    {
        dbContext.Update(url);
        dbContext.SaveChanges();
    }
}
