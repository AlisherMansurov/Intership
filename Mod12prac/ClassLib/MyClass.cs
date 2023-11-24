using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class MyClass : IPropertyChanged // Класс, реализующий интерфейс и содержащий свойство
    {
        private string myProperty;

        public string MyProperty
        {
            get { return myProperty; }
            set
            {
                if (myProperty != value)
                {
                    myProperty = value;
                    NotifyPropertyChanged(nameof(MyProperty));
                }
            }
        }

        public event PropertyEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }
}
