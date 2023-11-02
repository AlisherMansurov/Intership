using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentL;
using PersonL;
using TeacherL;
using StudentWithAdvisorL;

namespace Mod10DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person { Name = "Ivan", Age = 30 };
            var person2 = new Person { Name = "Vlad", Age = 25 };

            //массив для метода RandomPerson
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 30 },
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 35 }
            };

            //Выводим людей
            Console.WriteLine("Person 1:");
            person1.Print();
            Console.WriteLine("person1 equals person2: " + person1.Equals(person2));
            Console.WriteLine();

            Console.WriteLine("Person 2:");
            person2.Print();
            Console.WriteLine("person2 GetHashCode: " + person2.GetHashCode());
            Console.WriteLine();

            //RandomPerson
            Console.WriteLine("Random Person: " + Person.RandomPerson(people));
            Console.WriteLine();


            var teacher1 = new Teacher { Name = "Teacher Bob", Age = 40, Students = new List<Student>() };
            var teacher2 = new Teacher { Name = "Teacher Tim", Age = 41, Students = new List<Student>() };

            //массив для метода RandomTeacher
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { Name = "John", Age = 30, Students = new List<Student>()  },
                new Teacher { Name = "Alice", Age = 25, Students = new List<Student>() },
                new Teacher { Name = "Bob", Age = 35, Students = new List<Student>()  }
            };

            var student1 = new Student { Name = "Alex", Age = 20, Course = 3 };
            var student2 = new Student { Name = "Vova", Age = 21, Course = 4 };
            var student3 = new Student { Name = "Nikita", Age = 19, Course = 2 };

            //массив для метода RandomStudent
            List<Student> students = new List<Student>
            {
                new Student { Name = "Egor", Age = 20, Course = 3 },
                new Student { Name = "Slava", Age = 20, Course = 3 },
                new Student { Name = "Sasha", Age = 20, Course = 3 }
            };

            var st1 = new StudentWithAdvisor { Teacher = teacher1 };
            var st2 = new StudentWithAdvisor { Teacher = teacher1 };
            var st3 = new StudentWithAdvisor { Teacher = teacher2 };

            // Добавляем студентов к учителю
            teacher1.Students.Add(student1);
            teacher1.Students.Add(student2);
            teacher2.Students.Add(student3);

            //Выводим студентов и учителей
            Console.WriteLine("Teacher:");
            teacher1.Print();
            Console.WriteLine("teacher1 equals teacher2: " + teacher1.Equals(teacher2));
            Console.WriteLine("teacher2 GetHashCode: " + teacher2.GetHashCode());
            Console.WriteLine();

            //RandomTeacher
            Console.WriteLine("Random Teacher: " + Teacher.RandomTeacher(teachers));
            Console.WriteLine();

            Console.WriteLine("Student 1:");
            student1.Print();
            st1.Print();
            Console.WriteLine("student1 equals student2: " + st1.Equals(st2));
            Console.WriteLine("student2 GetHashCode: " + st2.GetHashCode());
            Console.WriteLine();

            Console.WriteLine("Student 2:");
            student2.Print();
            st2.Print();

            //RandomStudent
            Console.WriteLine("Random Student: " + Student.RandomStudent(students));
            Console.WriteLine();


            object[] peopleArray = new object[]
            {
                new Person { Name = "John", Age = 30 },
                new Student { Name = "Alice", Age = 19, Course = 2},
                new Teacher { Name = "Bob", Age = 35 },
                new Student { Name = "Eve", Age = 20, Course = 3}
            };

            int personCount = 0;
            int studentCount = 0;
            int teacherCount = 0;


            for (int i = 0; i < peopleArray.Length; i++)
            {
                if (peopleArray[i] is Person)
                {
                    personCount++;
                }

                if (peopleArray[i] is Student)
                {
                    studentCount++;
                    Student student = peopleArray[i] as Student;
                    student.Course++;
                    peopleArray[i] = student;
                    Console.WriteLine("Student: " + peopleArray[i]);
                }

                if (peopleArray[i] is Teacher)
                {
                    teacherCount++;
                }
            }

            Console.WriteLine($"Количество Person: {personCount}");
            Console.WriteLine($"Количество Students: {studentCount}");
            Console.WriteLine($"Количество Teachers: {teacherCount}");



        }
    }
}
