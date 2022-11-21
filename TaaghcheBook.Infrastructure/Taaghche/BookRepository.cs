using TaaghcheBook.Application.Repository;
using TaaghcheBook.Core;
using TaaghcheBook.Infrastructure.Cache;
using TaaghcheBook.Infrastructure.WebClient;

namespace TaaghcheBook.Infrastructure.Taaghche
{
    public class BookRepository : IBookRepository
    {
        private readonly IHttpService _httpService;

        public BookRepository(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public Task<Book?> GetBook(int id)
        {
            return new TaaghcheBookRepository(_httpService).GetBook(id);
        }
    }
}