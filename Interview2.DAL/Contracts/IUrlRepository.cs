using Interview2.Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview2.DAL.Contracts;

public interface IUrlRepository
{

    void Add(UrlInfo url);
    void Update(UrlInfo url);
    UrlInfo Get(string link);
}
