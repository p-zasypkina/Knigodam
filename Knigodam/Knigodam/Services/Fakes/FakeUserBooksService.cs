﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Knigodam.Models;

namespace Knigodam.Services.Fakes
{
    public class FakeUserBooksService : IUserBooksService
    {
        List<Book> books;
        public async Task<List<Book>> GetUserBooks(int userId)
        {
            books = new List<Book>()
            {
            new Book {Id = 1, Title="Тобол. Мало избранных", ImagePath="tobol.jpg", Description="Описание1", UserId = 1 },
            new Book {Id = 2, Title="Python для детей", ImagePath="python.jpg", Description="Описание2", UserId = 1},
            new Book {Id = 3, Title="Тонкое искусство пофигизма", ImagePath="pofigizm.jpg", Description="Описание3", UserId = 2 },
            new Book {Id = 4, Title="Центр тяжести", ImagePath="centre.jpg", Description="Описание4", UserId = 1 },
            new Book {Id = 5, Title="123456", ImagePath="centre.jpg", Description="Описание4", UserId = 2 },
            };

            List<Book> userBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.UserId == userId)
                {
                    userBooks.Add(book);
                }
            }
            return userBooks;
        }
    }
}
