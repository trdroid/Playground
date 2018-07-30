using NBuilder = FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzWare.NBuilder;

namespace StudentExample
{
    class Student
    {
        public string Id;
        public string Name;
        public int Age;
        public string Gender;
        public int Grade;
        public DateTime DateOfBirth;
        public string Address;

        public override string ToString()
        {
            return string.Format("Id:{0}" +
                "\nName:{1}" +
                "\nAge:{2}" +
                "\nGender:{3}" + 
                "\nGrade:{4}" + 
                "\nDateOfBirth:{5}" + 
                "\nAddress:{6}",                
                this.Id, this.Name, this.Age, this.Gender, this.Grade, this.DateOfBirth, this.Address);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = NBuilder.Builder<Student>
                .CreateNew()
                .Build();

            Console.WriteLine(student);

            List<Student> customStudents = NBuilder.Builder<Student>
                .CreateListOfSize(1)
                .All()
                .With(s => s.Gender = "Male")
                .Build()
                .ToList();

            customStudents.ForEach(s => Console.WriteLine(s));

            var students = NBuilder.Builder<Student>
                .CreateListOfSize(3)
                .Build();

            Console.WriteLine(students);

            Console.ReadKey();
        }
    }
}
