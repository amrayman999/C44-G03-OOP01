using Demo.Enums;
using Demo.UserDefinedDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum => Enumeration
            #region Example01
            //Person person = new Person();
            //person.Id = 1;
            //person.Name = "Ahmed";
            //person.Gender = Gender.male;

            //Console.WriteLine(person.Gender);

            //Grade grade = Grade.A;
            //if(grade == Grade.A)
            //    Console.WriteLine("Excellent");
            //else
            //    Console.WriteLine("Good luck next time");

            //grade = (Grade)5;
            //Console.WriteLine(grade);

            //Grade grade2 = new Grade();
            //Console.WriteLine(grade2);


            #endregion

            #region Example02
            //Student student = new Student();
            //bool isParsed;
            //Console.WriteLine("Enter Student Data: ");
            //Console.Write("Id: ");
            //int id;
            //do
            //{
            //    isParsed = int.TryParse(Console.ReadLine(), out id);
            //    if(!isParsed)
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //} while (!isParsed);
            //student.Id = id;

            //Console.Write("Name: ");
            //student.Name = Console.ReadLine();

            //Console.Write("Gender: ");
            //object gender;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(),true , out gender );
            //    if (!isParsed)
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //} while (!isParsed);
            //student.Gender = (Gender)gender;

            //Console.Write("Grade: ");
            //object grade;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(Grade), Console.ReadLine(),true,  out grade);
            //    if (!isParsed)
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //} while (!isParsed);
            //student.Grade = (Grade)grade;

            //Console.Write("Branch: ");
            //object branch;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(Branch), Console.ReadLine(),true,  out branch);
            //    if (!isParsed)
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //} while (!isParsed);
            //student.Branch = (Branch)branch;

            //Console.WriteLine("Student Data:");
            //Console.Write($"Id: {student.Id} ");
            //Console.Write($"Name: {student.Name} ");
            //Console.Write($"Gender: {student.Gender} ");
            //Console.Write($"Grade: {student.Grade} ");
            //Console.Write($"Branch: {student.Branch} ");
            #endregion

            #region example03
            //User user = new User();
            //user.Id = 1;

            //user.Permission = (Permission) 15;
            //Console.WriteLine(user.Permission);

            //user.Permission = user.Permission ^ Permission.Read;
            //Console.WriteLine(user.Permission);

            //user.Permission = user.Permission ^ Permission.Read;
            //Console.WriteLine(user.Permission);

            //user.Permission = user.Permission | Permission.Delete;
            //Console.WriteLine(user.Permission);
            #endregion

            #region EnumMethods
            //string branch = "Alex";
            //Branch branch1 = (Branch)Enum.Parse(typeof(Branch), branch);

            //string[] branchesNames = Enum.GetNames(typeof(Branch));
            //foreach (string name in branchesNames)
            //{
            //    Console.WriteLine(name);
            //}

            //Array branchesValues = Enum.GetValues(typeof(Branch));
            //foreach (var branchValue in branchesValues)
            //{
            //    Console.WriteLine((int)branchValue);
            //}

            //bool isExist = Enum.IsDefined(typeof(Branch), 70);
            //Console.WriteLine(isExist);
            #endregion

            #endregion
        }
    }
}
