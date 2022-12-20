using Assignment12_2.Models;

namespace Assignment12_2.Services
{
    public interface ICRUD
    {
        List<Book> GetBooks();
        Book GetBook(int? id);
        void CreateBook(Book book);
        void UpdateBook(int? id);
        void DeleteBook(int? id);
    }
}
