using System;


namespace Sneakers
{
    internal class Program
    {

        public class Person
        {
            public string name;
            public string surname;
            public int age;
            public float happiness;
            public bool isMarried;

            public void printBase()
            {
                
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Surname:" + surname);
                Console.WriteLine("Age:" + age);
                Console.WriteLine("Happiness " + happiness);
                Console.WriteLine("Is married: " + isMarried);
            }
            public virtual void Work()
            {
                Console.WriteLine("Working on Plays Statyion");
            }

             
        }
        
            public class Person1 :Person
            {
                public bool isStudent = true;
                public void degree()
                {
                    Console.WriteLine("Is student: " + isStudent );
                    Console.WriteLine("Bachelor degree");
                }
            public override void Work()
            {
                Console.WriteLine("Working on Computer");
            }

        }
        
        
            public class Person2 :Person
            {
                public bool hasJob = true;
                public void profession()
                {
                    Console.WriteLine("Has job: " +hasJob);
                    Console.WriteLine("Senior Developer");
                }
            public override void Work()
            {
                Console.WriteLine("Working on Laptop");
            }
        }

        
        static void Main(string[] args)
        {
            Person1 sarkhan = new Person1();
            sarkhan.name = "Sarkhan";
            sarkhan.surname = "Hajibayov";
            sarkhan.age = 21;
            sarkhan.happiness = 4.5f;
            sarkhan.printBase();
            sarkhan.degree();
            sarkhan.Work(); 

            Console.WriteLine();

            Person2 xadica = new Person2();
            xadica.name = "Xadica";
            xadica.surname = "Allahverdi";
            xadica.age = 23;
            xadica.happiness = 5.1f;
            xadica.printBase();
            xadica.profession();
            xadica.Work();



        }
    }
}
