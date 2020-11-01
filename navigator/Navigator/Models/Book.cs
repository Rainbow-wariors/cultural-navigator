using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Title = "Название не указано";
            }
            else
            {
                Title = title;
            }
            if (string.IsNullOrWhiteSpace(author))
            {
                Author = "Автор не указан";
            }
            else
            {
                Author = author;
            }
        }
    }
}
