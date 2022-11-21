using TaaghcheBook.Application.Repository;
using TaaghcheBook.Core;
using Xunit;

namespace TaaghcheBook.Test
{
    public class GetBookTest
    {
        private readonly IBookRepository _bookRepository;
        public GetBookTest(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [Theory]
        [InlineData(3)]
        public async void CheckBookProperties(int bookId)
        {
            var book = await _bookRepository.GetBook(bookId);
            Assert.NotNull(book);
            Assert.Equal(bookId, book.Id);
            Assert.Equal("سرهنگ کسی ندارد برایش نامه بنویسد", book.Name);
        }
    }
}