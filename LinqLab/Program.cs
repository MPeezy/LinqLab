using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
       

            List<int> nums = new List<int>() { 10, 2330, 112233, 10, 949, 3764, 2942 };


            Console.WriteLine("********************************************************");
            double minofWholeList = nums.Min();
            Console.WriteLine("#1). Minimum of the whole list: " + minofWholeList);

            Console.WriteLine("********************************************************");
            double maxofWholeList = nums.Max();
            Console.WriteLine("#2). Maximum of the whole list: " + maxofWholeList);


            Console.WriteLine("********************************************************");
            double maxUnder1000 = nums.Where(n => n <= 10000).Max(); 
            Console.WriteLine("#3). Maximum value less than 10000: " + maxUnder1000);


            Console.WriteLine("********************************************************");
            Console.WriteLine("#4). Method syntax for finding all the Values between 10 and 100 inclusive");
            List<int> numsInRange1 = nums.Where(x => 10 <= x && x <= 100).ToList();

            foreach (int num in numsInRange1)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("********************************************************");



            Console.WriteLine("#5). Method syntax for finding all the Values between 100000 and 999999 inclusive");
            List<int> numsInRange = nums.Where(x => 100000 <= x && x <= 999999).ToList();

            foreach (int num in numsInRange)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("********************************************************"  );


            List<int> evens = nums.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("6). Method syntax for counting even numbers");
            int evensCount = nums.Count(n =>n < 112233  && n % 2 == 0);
            Console.WriteLine("Even numbers count: " + evensCount);
            Console.WriteLine("********************************************************");


            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));



            List<Student> over21 = students.Where(x => x.Age >=21).ToList();
            Console.WriteLine("1). Students over 21:");
            foreach (Student s in over21)
            {
                Console.WriteLine(s.Name);
            
            }
            Console.WriteLine("********************************************************");

            Console.WriteLine("2). Finding the oldest student");
            int oldestAge = students.Max(x => x.Age);

            List<Student> oldeststudents = students.Where(x => x.Age == oldestAge).ToList();
            foreach (Student s in oldeststudents)
            {
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("********************************************************");
            }




            Console.WriteLine("3). Finding the youngest student");
            int youngestAge = students.Min(x => x.Age);

            List<Student> youngeststudents = students.Where(x => x.Age == youngestAge).ToList();
            foreach (Student s in youngeststudents)
            {
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("********************************************************");
            }



            //List<Student> over25 = students.Where(x => x.Age >= 25).ToList();
            //Console.WriteLine("4). Oldest student over 25:");
            //foreach (Student s in over25)
            //{
            //    Console.WriteLine(s.Name);

            //}
            //Console.WriteLine("********************************************************");





            Console.WriteLine("5. Find all students over 21 and with even ages");
            List<Student> over21Even = students.Where(x => x.Age >= 21 && x.Age % 2 ==0).ToList();
            foreach (Student s in over21Even)
            {
                Console.WriteLine(s.Name);

            }
            Console.WriteLine("********************************************************");
            Console.WriteLine();




            Console.WriteLine("#6). Finding all the teenage students between 13 and 19 inclusive");
            List<Student> inRange= students.Where(x => x.Age >= 13 && x.Age <=19).ToList();
         
            foreach (Student s in inRange)
            {
                Console.WriteLine(s.Name);

            }
            Console.WriteLine("********************************************************");
            Console.WriteLine();


            Console.WriteLine("#7). Find all students whose name starts with a vowel");






            //Couldn't get #4 and #7




        }
    }
}




//1.Find the Minimum value
//2. Find the Maximum value
//3. Find the Maximum value less than 10000
//4. Find all the values between 10 and 100
//5. Find all the Values between 100000 and 999999 inclusive
//6. Count all the even numbers


//For students:
//1.Find all students age of 21 and over (aka US drinking age)
//2.Find the oldest student
//3. Find the youngest student
//4. Find the oldest student under the age of 25
//5. Find all students over 21 and with even ages
//6. Find all teenage students (13 to 19 inclusive)
//7.Find all students whose name starts with a vowel