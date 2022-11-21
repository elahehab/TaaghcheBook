using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaaghcheBook.Application.Repository;
using TaaghcheBook.Core;

namespace TaaghcheBook.Infrastructure.Taaghche;

internal class RedisBookRepository : IBookRepository
{
    protected readonly IBookRepository _nextBookRepository;

    public RedisBookRepository(IBookRepository nextBookRepository)
    {
        _nextBookRepository = nextBookRepository;
    }

    public async Task<Book?> GetBook(int id)
    {
        //read from Redis
        var book = new Book();

        if (book == null)
        {
            book = await _nextBookRepository.GetBook(id);
            //save book in Redis
        }
        return book;
    }
}
