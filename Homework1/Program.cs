
namespace Homework
{
    //Ex. 1

    public record Course(string Title, int Credits){
        public override string ToString()
        {
            return Title + ": " + Credits + " credits";
        }
    }

    public record Student(int Id, string Name, int Age, List<Course> Courses)
    {
        public override string ToString()
        {
            return Id + ": " + Name + " age: " + Age + " courses: " + String.Join(", ", Courses.Select(c => c.ToString()));
        }
    }
    
    
    //Ex 2


    public class Instructor()
    {
        public string Name {get; init;}
        public string Departament {get; init;}
        public string Email {get; init;}

        public override string ToString()
        {
            return Name + " " + Departament + " " + Email;
        }
    }
    
    public class Program
    {
        //Ex4
        public static void verifyType(Object obj)
        {
            switch (obj)
            {
                case Student s:
                    Console.WriteLine("Ex4: " + s.Name + " " + s.Courses.Count);
                    break;
                case Course c:
                    Console.WriteLine("Ex4 " + c.Title + ": " + c.Credits);
                    break;
                default:
                    Console.WriteLine("Ex4: Tip necunoscut");
                    break;
            }
        }
        //Sfarsit Ex4
        
        static void Main(string[] args)
        {
            //Ex 1
            Student student1 = new Student(1, "Marcel", 21, new List<Course>
                {new Course(".Net", 4), 
                 new Course("ML", 6)
                });

            Student student2 = student1 with
            {
                Name = "Vasile", Age = 20, Courses = student1.Courses.Concat(new[]
                {
                    new Course("AI", 6),
                    new Course("Python", 4)
                }).ToList()
            };
            
            Console.WriteLine("Exercitiul 1: " + student2.ToString());
            
            //Ex 2
            Instructor instructor = new Instructor()
            {
                Name =  "Nicolae",
                Departament = "Dep1",
                Email = "inst@gmail.com"
            };
            
            Console.WriteLine("Exercitiul 2: " + instructor.ToString());
            //Final Ex2
            
            verifyType(student1);
            
            //Ex5
            List<Course> list = new List<Course>
            {
                new Course(".NET", 4),
                new Course("ML", 6),
                new Course("Python", 2),
                new Course("AI", 3),
            };

            Func<List<Course>, List<Course>> filter = courses =>
            {
                return courses.Where(c => c.Credits > 3).ToList();
            };
            
            Console.WriteLine("Exercitiul 5: " + String.Join(", ", filter(list).Select(c => c.ToString())));
            //Final Ex5
        }
    }
}