using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaaghcheBook.Application.Repository;
using TaaghcheBook.Core;
using TaaghcheBook.Infrastructure.WebClient;

namespace TaaghcheBook.Infrastructure.Taaghche;

public class TaaghcheBookRepository : IBookRepository
{
    private readonly string TAAGHCHE_URL = "https://get.taaghche.com/v2/book/{0}";
    private readonly IHttpService _httpService;

    public TaaghcheBookRepository(IHttpService httpService)
    {
        _httpService = httpService;
    }
    public async Task<Book?> GetBook(int id)
    {
        var url = string.Format(TAAGHCHE_URL, id);
        return await _httpService.Get<Book>(url);

    }

}

