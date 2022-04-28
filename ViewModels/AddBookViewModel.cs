using couse_work_web;
using couse_work_web.ModelsApi;
using couse_work_web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cousework_3_kurs.ViewModels
{
    class AddBookViewModel
    {
        public List<BookApi> books { get; set; }
        public BookApi AddBook { get; set; }
        public CustomCommand SaveBook { get; set; }

        public AddBookViewModel(BookApi book)
        {
            Task.Run(GetListBooks);

            if (book == null)
            {
                AddBook = new BookApi();
                
            }
            else
            {
                AddBook = new BookApi
                {
                    Id = book.Id,
                    TitleBook = book.TitleBook,
                    Genres = book.Genres,
                    Authors = book.Authors,
                    Publishes = book.Publishes,
                    
                };

            }
            SaveBook = new CustomCommand(() =>
            {
                if (AddBook.Id == 0)
                    Task.Run(CreateNewBook);
                else
                    Task.Run(EditBook);
            });
        }

        public async Task CreateNewBook()
        {
            await Api.PostAsync<BookApi>(AddBook, "Book");
        }

        public async Task EditBook()
        {
            await Api.PutAsync<BookApi>(AddBook, "Book");
        }

        public async Task GetListBooks()
        {
            var result = await Api.GetListAsync<BookApi[]>("Book");
            books = new List<BookApi>(result);
            SignalChanged("books");

        }

        private void SignalChanged(string v)
        {
            throw new NotImplementedException();
        }
    }
}


