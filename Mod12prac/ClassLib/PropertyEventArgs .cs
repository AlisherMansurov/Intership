using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class PropertyEventArgs : EventArgs // Дополнительный класс для хранения информации о свойстве, которое изменилось
    {
        public string PropertyName { get; set; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
