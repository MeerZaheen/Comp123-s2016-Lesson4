using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
{
    /**
    * This class is the "driver" class for our Program
    *
    * @class Program
    */
    public class Program
    {
        /**
        * the main method for our driver class Program
        *
        * @method Main
        * @param {string[]} args
        */
        public static void Main(string[] args)
        {
            // Create a new instance (tommy) of the student class

            Student Tommy = new Student("Tommy", 26, "12345");
            Tommy.SaysHello();
            Console.WriteLine();
            Tommy.Studies();

            Tommy.Courses.Add(new Course("COMP123", "Programming 2"));
            Console.WriteLine();
            // create instance of the Teacher class

            Teacher Tom = new Teacher("Tom", 26, "T123");
            Tom.SaysHello();
            Console.WriteLine();
            Tom.Teaches();
        }
    }
}

/* MY CODE MISTAKES

public static void Main(string[] args)
{
    Person person;

    // create a new instance for the Person class
    person = new Person();

    //Console.WriteLine(person.Name);

    // set a value in the Name properly of the Person class
    //person.Name = ("Meer");
    //person.Age = (26);

    // get the Name Value and print to console
    Console.WriteLine("{0} says hello", person.Name);
    Console.WriteLine("{0} is {1} years old", person.Name, person.Age);
}
*/
