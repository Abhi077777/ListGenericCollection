using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListGenericCollection
{
    class Program
    {
        public static void Main()
        {
            Employee emp1 = new()
            {
                Name = "Abhishek",
                Age = 26,
                Designation = "Developer"
            };

            Employee emp2 = new()
            {
                Name = "Deeepak",
                Age = 28,
                Designation = "JEE"
            };
            Employee emp3 = new()
            {
                Name = "Rahul",
                Age = 17,
                Designation = "Chaser Master"
            };

            List<Employee> Emplist = new()
            {
                emp1,
                emp2,
                emp3
            };

            Employee[] emps = Emplist.ToArray();
            foreach (Employee emp in emps)
            {
                Console.WriteLine("Employee Name is : {0} Age is : {1} Designation is  : {2}", emp.Name, emp.Age, emp.Designation);
            }
            Console.WriteLine("---------------------------------------");

            List<Employee> myEmps = emps.ToList();

            foreach (Employee emp in myEmps)
            {
                Console.WriteLine("Employee Name is : {0} Age is : {1} Designation is  : {2}", emp.Name, emp.Age, emp.Designation);

            }


            
     



            //Employee emp = Emplist.Find(e => e.age > 20);
            //Console.WriteLine("Employee Name is : {0} Age is : {1} Designation : {2}", emp.Name, emp.age, emp.Designation);

            //Console.WriteLine(Emplist.Exists(emp => emp.Name.StartsWith("A"))); 

 






            //List<int> myNumber = new List<int>();
            //myNumber.Add(10);
            //myNumber.Add(20);
            //myNumber.Add(30);
            //myNumber.Add(40);
            //myNumber.Add(50);
            //myNumber.Add(60);
            //myNumber.Add(70);
            //myNumber.Add(80);
            //myNumber.Add(90);

            // Console.WriteLine(myNumber.IndexOf(30));

            // Console.WriteLine(myNumber.LastIndexOf(40));



            //Console.WriteLine(myNumber.Count);
            //Console.WriteLine(myNumber.Capacity);


            //Add Range()----------------------------


            //List<string> names = new List<string>();
            //names.Add("Abhi");
            //names.Add("Rahul");
            //names.Add("Akshay");
            //names.Add(null);
            //names.Add("Rahul");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //foreach (int i in myNumber)
            //{
            //    Console.WriteLine(i);
            //}



            //  Console.WriteLine("------------------");

            //myNumber.AddRange(myNumber);

            //myNumber.Insert(1, 15);

            //myNumber.InsertRange(2, myNumber);

            //myNumber.Remove(10);

            //  myNumber.RemoveRange(0, 4);

            // myNumber.RemoveAt(3);

            // myNumber.RemoveAll();

            //myNumber.Reverse();


            //foreach (int i in myNumber)
            //{
            //    Console.WriteLine(i);
            //}
            //  Console.WriteLine("------------------");

            // Console.WriteLine(myNumber.Contains(40));

            Console.ReadLine();
        }
    }
}