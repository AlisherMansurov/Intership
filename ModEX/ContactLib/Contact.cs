using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLib
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $" Имя: {FirstName}\n Фамилия: {LastName}\n Телефон: {PhoneNumber}\n Email: {Email}\n Id: {ID}";
        }
    }
}
