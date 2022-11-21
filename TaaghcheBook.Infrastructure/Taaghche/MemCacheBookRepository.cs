using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaaghcheBook.Application.Repository;
using TaaghcheBook.Core;
using TaaghcheBook.Infrastructure.Cache;

namespace TaaghcheBook.Infrastructure.Taaghche;

public class MemCacheBookRepository : IBookRepository
{
    protected readonly IBookRepository _nextBookRepository;
    private readonly ICache _memoryCache;

    public MemCacheBookRepository(IBookRepository nextBookRepository, ICache cache)
    {
        _nextBookRepository = nextBookRepository;
        _memoryCache = cache;
    }

    public async Task<Book?> GetBook(int id)
    {
        var book = _memoryCache.Get<Book>(id.ToString());

        if (book == null)
        {
            book = await _nextBookRepository.GetBook(id);
            _memoryCache.Set(id.ToString(), book);
        }
        return book;
    }


}