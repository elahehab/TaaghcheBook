using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaaghcheBook.Infrastructure.WebClient;

public interface IHttpService
{
    public Task<T?> Get<T>(string request);
}
