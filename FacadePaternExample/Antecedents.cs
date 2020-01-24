using System;

namespace FacadePaternExample
{
    public class Antecedents
    {
        public bool HasNoBadAntecedents(Person p)
        {
            Console.WriteLine("Check antecedents for " + p.Name);
            return true;
        }
    }
}
