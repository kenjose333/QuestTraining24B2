using System.Collections.Generic;
using System.Linq;
using LibrariesProblem.Data;
using LibrariesProblem.Entities;

namespace LibrariesProblem.Repositories
{
    public class BookRepositories
    {
        public GenericResponse<List<Books>> GetAllBooks()
        {
            var Book = DataStore.Book;
            return new GenericResponse<List<Books>>
            {
                Success = true,
                Data = Book,
            };
        }


        public GenericResponse<Books> GetBooksByIdAndName(int id, string Name)
        {
            var Bookbyid = DataStore.Book.FirstOrDefault(x => x.Id == id);
            var Bookbyname = DataStore.Book.FirstOrDefault(x => x.NameOfBook == Name);
            if (Bookbyid == null && Bookbyname == null)
            {
                return new GenericResponse<Books>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }
            return new GenericResponse<Books>
            {
                Success = true,
                Data = Bookbyid

            };
        }

    }
}

