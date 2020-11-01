using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Navigator.Models
{
    public class BooksRequest
    {
        private class BookJson
        {
            public string[] names = new string[20];
            public string[] authors = new string[20];
        }

        public List<Book> GetBooks()
        {
            var books = new List<Book>();

            string json;
            using (WebClient wc = new WebClient())
            {
                wc.QueryString.Add("name", "Полужизнь");
                wc.QueryString.Add("k", "20");
                json = wc.DownloadString("http://188.134.65.35");
            }

            BookJson ser = JsonConvert.DeserializeObject<BookJson>(json);
            for (int i = 0; i < 20; i++)
            {
                books.Add(new Book(ser.names[i], ser.authors[i]));
            }

            return books;
        }
    }
}
