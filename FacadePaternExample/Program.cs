using System;

namespace FacadePaternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Adoption adoption = new Adoption();

            Person person = new Person("Jeff Strongman");
            bool eligible = adoption.IsEligible(person, 12500);

            Console.WriteLine("\n" + person.Name +
                " has been " + (eligible ? "Approved" : "Rejected") + " to adopt a pet!");

            Console.ReadKey();
        }
    }
}
