using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public struct Student
        {
            public string name;
            public int age;
            public char gender;
        }
        public class Course
        {
            public double result;
            public static char gradeCalc(double r)
            {
                if (r > 80)
                    return 'A';
                else if (r > 70)
                    return 'B';
                else if (r > 60)
                    return 'C';
                else if (r > 50)
                    return 'D';
                else
                    return 'F';

            }
        }

        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("Enter your name: ");
            s.name = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter your age: ");
                s.age = Convert.ToInt32(Console.ReadLine());
                if (s.age <= 0)
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (s.age <= 0);
            do
            {
                Console.WriteLine("Enter your gender(m/f): ");
                s.gender = Convert.ToChar(Console.ReadLine());
                if (!(s.gender == 'm' || s.gender == 'M' || s.gender == 'f' || s.gender == 'F'))
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (!(s.gender == 'm' || s.gender == 'M' || s.gender == 'f' || s.gender == 'F'));


            Course csharp = new Course();
            Course database = new Course();
            Course history = new Course();
            Course math = new Course();

            do
            {
                Console.WriteLine("Enter your csharp result: ");
                csharp.result = Convert.ToDouble(Console.ReadLine());
                if (csharp.result > 100 || csharp.result <= 0)
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (csharp.result > 100 || csharp.result <= 0);

            do
            {
                Console.WriteLine("Enter your database result: ");
                database.result = Convert.ToDouble(Console.ReadLine());
                if (database.result > 100 || database.result <= 0)
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (database.result > 100 || database.result <= 0);

            do
            {
                Console.WriteLine("Enter your history result: ");
                history.result = Convert.ToDouble(Console.ReadLine());
                if (history.result > 100 || history.result <= 0)
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (history.result > 100 || history.result <= 0);

            do
            {
                Console.WriteLine("Enter your math result: ");
                math.result = Convert.ToDouble(Console.ReadLine());
                if (math.result > 100 || math.result <= 0)
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (math.result > 100 || math.result <= 0);

            Console.WriteLine("----------------Student Info----------------");
            Console.WriteLine("Name: " + s.name);
            Console.WriteLine("Age: " + s.age);
            Console.WriteLine("Gender: " + Char.ToUpper(s.gender));
            Console.WriteLine("\n----------------GRADE RESULT----------------");
            Console.WriteLine("Couse        Result      Grade");
            Console.WriteLine("C sharp:      " + csharp.result + "           " + Course.gradeCalc(csharp.result));
            Console.WriteLine("Database:     " + database.result + "           " + Course.gradeCalc(database.result));
            Console.WriteLine("History:      " + history.result + "           " + Course.gradeCalc(history.result));
            Console.WriteLine("Math:         " + math.result + "           " + Course.gradeCalc(math.result));

            Console.ReadLine();
        }

    }

}

