using MVApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVApp.View
{
    public partial class AuthorView : ContentPage
    {
        public AuthorView(Author author)
        {
            InitializeComponent();
            Author.Text = $"{author.Name} is the author of this book";
        }
    }
}
