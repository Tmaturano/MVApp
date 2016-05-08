using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVApp.Model
{
    public class Author : INotifyPropertyChanged
    {
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

        private string  _name;

        [JsonProperty(PropertyName = "Nome")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;

                //if is not null, will execute the method, otherwise won't
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
