using MVApp.ApiBooks;
using MVApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVApp.ViewModel
{
    public class BooksViewModel : INotifyPropertyChanged
    {
        //Command is an object that will execute an action. 
        //We cant do binding in events and methods, just for properties
        public ICommand LoadCommand { get; set; }

        //ObservabbleCollection: It is important because everytime that i include an item in my collection, this collection will trigger an
        //action that an item was removed or added. 
        private ObservableCollection<Book> _books;

        public ObservableCollection<Book> Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Books)));                    
            }
        }

        private bool _searching;
            
        public bool IsSearching
        {
            get { return _searching; }
            set
            {
                _searching = value;                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsSearching)));
            }
        }


        public BooksViewModel()
        {
            IsSearching = false;

            LoadCommand = new Xamarin.Forms.Command(async() =>
            {
                //Books.Add(new Book() { Id = 1, Title = $"Book {Books.Count}" });
                IsSearching = true;
                var books = await Api.GetBooksAsync();
                Books = new ObservableCollection<Book>(books);
                IsSearching = false;
            });
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
