using personch;

namespace personch
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }

        public Person() { }

        public Person(string name, int age, string address, string nationality)
        {
            Name = name;
            Age = age;
            Address = address;
            Nationality = nationality;
        }

       
      
    }


    public class Student : Person
    {
        public string Study_Level { get; set; }    
        public string Specialization { get; set; }    
        private double gpa;
        public double GPA;
      
        

        public Student() { }

        public Student(string name, int age, string address, string nationality,
                       string studyLevel, string specialization, double gpa)
            : base(name, age, address, nationality)
        {
            Study_Level = studyLevel;
            Specialization = specialization;
            GPA = gpa;
        }


    }

   
    public class Employee : Person
    {
        public decimal Salary { get; set; }  
        public string Rank { get; set; }   
        public string Job { get; set; }     

        public Employee() { }

        public Employee(string name, int age, string address, string nationality,
                        decimal salary, string rank, string job)
            : base(name, age, address, nationality)
        {
            Salary = salary;
            Rank = rank;
            Job = job;
        }

   
    }

}

    internal class Program
    {
    static void Main()
    {
        var s1 = new Student(
            name: "Ahmed",
            age: 21,
            address: "Cairo",
            nationality: "Egyptian",
            studyLevel: "Bachelor",
            specialization: "Information Systems",
            gpa: 3.5
        );

        var e1 = new Employee(
            name: "Mona",
            age: 30,
            address: "Abu Dhabi",
            nationality: "Emirati",
            salary: 18000m,
            rank: "Senior",
            job: "Software Engineer"
        );

  
        List<Person> people = new() { s1, e1 };

        foreach (var p in people)
        {
            Console.WriteLine(p); 
        }
    }
}
