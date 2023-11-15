using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelib
{
    public enum Vacancies
    {
        PoliceOfficer,
        Military,
        Firefighter,
        Medic
    }

    // Определение структуры Employee
    public struct Employee
    {
        // Поле для имени сотрудника
        public string name;

        // Поле для типа должности (используется перечисление Vacancies)
        public Vacancies vacancy;

        // Поле для даты приема на работу (используется массив из трех int для дня, месяца и года)
        public int[] hireDate;

        // Поле для зарплаты сотрудника
        public int salary;
    }
}
