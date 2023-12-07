using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLib;

namespace Mod15prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type ClassType = typeof(MyClass);
            object obj = Activator.CreateInstance(ClassType); //cоздание экземпляра класса с помощью рефлексии

            Console.WriteLine($"Значение PublicProp до изменений: {(ClassType.GetProperty("PublicProp").GetValue(obj))}"); //значение до изменений
            
            ClassType.GetProperty("PublicProp").SetValue(obj, 10); //изменение значения PublicProp

            Console.WriteLine($"Значение PublicProp после изменений: {(ClassType.GetProperty("PublicProp").GetValue(obj))}"); //значение после изменений

            ClassType.GetMethod("PublicMethod").Invoke(obj, null); //вызов публичного метода

            var privateMethod = ClassType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            string result = (string)privateMethod.Invoke(obj, null); //вызов метода, изменяющее состояние объекта
            Console.WriteLine(result);

            var privateMethod2 = ClassType.GetMethod("PrivateMethod2", BindingFlags.NonPublic | BindingFlags.Instance);
            privateMethod2.Invoke(obj, null); //Найдите и вызовите приватный метод класса `MyClass` с помощью рефлексии.
        }
    }
}
