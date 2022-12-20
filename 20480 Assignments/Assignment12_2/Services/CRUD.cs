using Assignment12_2.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Assignment12_2.Services
{
    public class CRUD : ICRUD
    {
        private List<Book> books;
        public CRUD()
        {
            books = new List<Book>();
            books.Add(new Book() { Id = 1, Title = "2666", Author = "Robert Bolano", Description = "Three academics on the trail of a reclusive German author; a New York reporter on his first Mexican assignment; a widowed philosopher; a police detective in love with an elusive older woman—these are among the searchers drawn to the border city of Santa Teresa, where over the course of a decade hundreds of women have disappeared.", Pages = 912, ImageName = "2666.jpg" });
            books.Add(new Book() { Id = 2, Title = "All The Light We Cannot See", Author = "Anthony Doerr", Description = "Marie-Laure lives in Paris near the Museum of Natural History, where her father works. When she is twelve, the Nazis occupy Paris and father and daughter flee to the walled citadel of Saint-Malo, where Marie-Laure’s reclusive great uncle lives in a tall house by the sea. With them they carry what might be the museum’s most valuable and dangerous jewel. In a mining town in Germany, Werner Pfennig, an orphan, grows up with his younger sister, enchanted by a crude radio they find that brings them news and stories from places they have never seen or imagined. Werner becomes an expert at building and fixing these crucial new instruments and is enlisted to use his talent to track down the resistance. Deftly interweaving the lives of Marie-Laure and Werner, Doerr illuminates the ways, against all odds, people try to be good to one another.", Pages = 544, ImageName = "atlwcs.jpg" });
            books.Add(new Book() { Id = 3, Title = "The Amazing Adventures of Kavalier & Clay", Author = "Michael Chabon", Description = "The Amazing Adventures of Kavalier & Clay is a triumph of originality, imagination, and storytelling, an exuberant, irresistible novel that begins in New York City in 1939. A young escape artist and budding magician named Joe Kavalier arrives on the doorstep of his cousin, Sammy Clay. While the long shadow of Hitler falls across Europe, America is happily in thrall to the Golden Age of comic books, and in a distant corner of Brooklyn, Sammy is looking for a way to cash in on the craze. He finds the ideal partner in the aloof, artistically gifted Joe, and together they embark on an adventure that takes them deep into the heart of Manhattan, and the heart of old-fashioned American ambition. From the shared fears, dreams, and desires of two teenage boys, they spin comic book tales of the heroic, fascist-fighting Escapist and the beautiful, mysterious Luna Moth, otherworldly mistress of the night. Climbing from the streets of Brooklyn to the top of the Empire State Building, Joe and Sammy carve out lives, and careers, as vivid as cyan and magenta ink. Spanning continents and eras, this superb book by one of America’s finest writers remains one of the defining novels of our modern American age.", Pages = 639, ImageName = "taaokac.jpg" });
        }
        public void CreateBook(Book book)
        {
            books.Add(book);
        }
        public void DeleteBook(int? id)
        {
            var bookToRemove = books.Find(x => x.Id == id);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }
        public Book GetBook(int? id)
        {
            var bookToFind = books.Find(x => x.Id == id);
            if (bookToFind != null)
            {
                return bookToFind;
            }
            else
            {
                return null;
            }
        }
        public List<Book> GetBooks()
        {
            return books;
        }
        public void UpdateBook(Book book)
        {
            var bookToUpdate = books.Find(x => x.Id == book.Id);
            if(bookToUpdate != null)
            {
                bookToUpdate.Id = book.Id;
                bookToUpdate.Title = book.Title;
                bookToUpdate.Author = book.Author;
                bookToUpdate.Description = book.Description;
                bookToUpdate.Pages = book.Pages;
                bookToUpdate.ImageName = book.ImageName;
            }
        }
    }
}
