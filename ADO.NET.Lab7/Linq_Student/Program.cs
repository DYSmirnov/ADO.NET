using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Student
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();

           
        }

        //Ex1.
        static void Ex1()
        {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90
                select student;
            foreach (var student in studentQuery)
            {
                Console.WriteLine("{0} {1}", student.Last, student.First);
            }
        }

        //Ex2
        static void Ex2()
        {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                select student;
            var studentQwerty2 = students.Where(st => st.Scores[0] > 90 && st.Scores[3] < 80).OrderBy(st => st.ID); 
           
            var studentList2 = students.Where(st => st.Scores[0] > 90 && st.Scores[3] < 80).OrderBy(st=> st.Last).ToList();
            
            var studentCount2 = students.Where(st => st.Scores[0] > 90 && st.Scores[3] < 80).Count();
            foreach (var student in studentQuery)
            {
                Console.WriteLine("1.{0} {1}", student.Last, student.First);
            }
            foreach (var stud in studentQwerty2)
            {
                Console.WriteLine("2.{0} {1}", stud.Last, stud.First);
            }
            foreach (var stud in studentList2)
            {
                Console.WriteLine("2.{0} {1}", stud.Last, stud.First);
            }
            Console.WriteLine("2. Cont = {0}", studentCount2);

            var studentQwery3 =
                from student in students
                group student by student.Last[0];
            foreach (var stGroup in studentQwery3)
            {
                Console.WriteLine("3. {0}", stGroup.Key);
                foreach (var student in stGroup)
                {
                    Console.WriteLine("3. {0} {1}", student.Last, student.First);
                }
            }
        }

        //Ex3
        static void Ex3()
        {
            var stQwery =
                from student in students
                group student by student.Last[0];
            foreach (var groupOfStudents in stQwery)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine("1. {0}, {1}",
                    student.Last, student.First);
                }
            }

            var stQw = students.GroupBy(st => st.Last[0]);
            foreach (var groupOfStudents in stQw)
            {
                Console.WriteLine("2.{0}", groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine("2. {0}, {1}",
                    student.Last, student.First);
                }
            }
            var stQwery2 =
                from student in students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;
            foreach (var groupOfStudents in stQwery2)
            {
                Console.WriteLine("3 {0}", groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine("3. {0}, {1}",
                    student.Last, student.First);
                }
            }
            var stQw2 = students.GroupBy(st => st.Last[0]).OrderBy(st=>st.Key);
            foreach (var groupOfStudents in stQw2)
            {
                Console.WriteLine("4.{0}", groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine("4. {0}, {1}",
                    student.Last, student.First);
                }
            }

        }

        //Ex4
        static void Ex4()
        {
            var stQwery =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where totalScore / 4 < student.Scores[0]
                orderby totalScore descending
                select student.Last + " " + student.First + " Total: " + totalScore;

            foreach (var st in stQwery)
            {
                Console.WriteLine(st);
            }
        }


        //ex5
        static  void Ex5()
        {
            var stQw =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                select totalScore;

            double averageScore = stQw.Average();
            Console.WriteLine("Class average score = {0}", averageScore);
        }


        //Ex6
        static void Ex6()
        {
            IEnumerable<string> stQw =
                from student in students
                where student.Last == "Garcia"
                select student.First;
            Console.WriteLine("The Garcia in the class are:");
            foreach (var item in stQw)
            {
                Console.WriteLine(item);
            }
        }


        //Ex7
        static void Ex7()
        {
            var stQw1 = 
                from student in students
                let totalScore = (student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3])
                select totalScore;

            double ts = stQw1.Average();
            
            var stQw2 =
                from student in students
                let x = (student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3])
                where x > ts
                select new {id = student.ID, score = x };

            foreach(var st in stQw2)
            {
                Console.WriteLine("Student ID: {0}, Score: {1}", st.id, st.score);
            }

        }

        static List<Student> students = new List<Student>
        {
            new Student {First = "Svetlana",  Last = "Omelchenko", ID = 111, Scores = new List<int>{97, 92, 81, 60 } },
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Vitaliy", Last="Vitalev", ID=116, Scores= new List<int> {45, 73, 91, 70}},
            new Student {First="Ivan", Last="Ivanov", ID=117, Scores= new List<int> { 91, 53, 44, 79}},
        };
    }
}
