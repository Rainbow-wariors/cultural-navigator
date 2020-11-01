using Navigator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Navigator.ViewModels
{
    public class RecommendedBooksVm : BaseViewModel
    {
        private const string _titleProperty = "Название:";
        public string TitleProperty { get => _titleProperty; }

        private const string _authorProperty = "Автор:";
        public string AuthorProperty { get => _authorProperty; }

        private Book _referenceItem;
        public Book ReferenceItem
        {
            get => _referenceItem;
            set => SetProperty(ref _referenceItem, value);
        }

        private List<Book> _items;
        public List<Book> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public RecommendedBooksVm()
        {
            var request = new BooksRequest();
            Items = request.GetBooks();
            //Items = request.Books;
        }
    }
}
