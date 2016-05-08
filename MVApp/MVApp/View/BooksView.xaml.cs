using MVApp.Model;
using MVApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVApp.View
{
    public partial class BooksView : ContentPage
    {
        public BooksView()
        {
            InitializeComponent();

            BindingContext = new BooksViewModel();

            //e represents the binded item
            List.ItemTapped += async (sender, e) => {
                var book = e.Item as Book;
                await App.Current.MainPage.Navigation.PushAsync(new AuthorView(book.Author));
            };
        }

        private void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
