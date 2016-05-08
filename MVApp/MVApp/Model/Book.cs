using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVApp.Model
{
    public class Book :INotifyPropertyChanged
    {
        //With MVVM framework, it is not needful to do this
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;

                //if is not null, will execute the method, otherwise won't
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));                
            }
        }

        private string _title;

        [JsonProperty(PropertyName = "Nome")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;

                //if is not null, will execute the method, otherwise won't
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        private Author _author;

        [JsonProperty(PropertyName = "Autor")]
        public Author Author
        {
            get { return _author; }
            set
            {
                _author = value;

                //if is not null, will execute the method, otherwise won't
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Author)));
            }
        }
        

        //Everytime something is updated, this event is trigged
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
