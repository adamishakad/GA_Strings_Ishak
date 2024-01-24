using System.Xml.Linq;

namespace GA_Strings_Ishak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Clasmates!");
            string myFirstName = "Adam"; 
            Console.WriteLine(myFirstName);
            string myLastName = "Ishak";
            Console.WriteLine(myLastName);
            string myFullName = myFirstName + " " + myLastName;
            Console.WriteLine(myFullName);
            // Reassigning my teachers name to myFirstName
            myFirstName = "William";
            // Reassigning my teachers name to myLastName
            myLastName = "Cram";
            // Adding another string to myFullName
            myFullName = myFirstName + " " + myLastName + " is my professor";
            // Displaying the result
            Console.WriteLine(myFullName);


        }
    }
}
