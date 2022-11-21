using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaaghcheBook.Application.Repository;
using TaaghcheBook.Core;

namespace TaaghcheBook.Application.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<Book?> GetBook(int id)
        {
            return await _bookRepository.GetBook(id);
        }
    }
}
