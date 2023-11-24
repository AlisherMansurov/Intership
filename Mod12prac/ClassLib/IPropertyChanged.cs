using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    interface IPropertyChanged // Интерфейс для уведомления об изменении свойства
    {
        event PropertyEventHandler PropertyChanged;
    }

    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e); // Делегат для обработки события изменения свойства
}
