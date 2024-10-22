using System.Collections.Generic;
using LibrariesProblem.Entities;

namespace LibrariesProblem.Data
{
    internal static class DataStore
    {
        public static List<Members> Member;
        public static List<Books> Book;

        static DataStore()
        {
            Member = new List<Members>()
        {
         new Members{Id=1, Name="Member1",Email="member1@gmail.com"},
         new Members{Id=2, Name="Member2",Email="member2@gmail.com"},
         new Members{Id=3, Name="Member3",Email="member3@gmail.com"}
        };

            Book = new List<Books>()
        {
         new Books{Id=1,NameOfBook="Book 1", PublisherName ="abc",NoOfPages=200},
         new Books{Id=2,NameOfBook="Book 2", PublisherName ="pqr",NoOfPages=150},
         new Books{Id=3,NameOfBook="Book 3", PublisherName ="xyz",NoOfPages=250}
        };
        }
    }
}
