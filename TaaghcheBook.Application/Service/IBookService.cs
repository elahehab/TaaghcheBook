using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaaghcheBook.Core;

namespace TaaghcheBook.Application.Service
{
    public interface IBookService
    {
        Task<Book?> GetBook(int id);
    }
}
