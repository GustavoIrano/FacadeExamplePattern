using System;

namespace FacadePaternExample
{
    public class Bank
    {
        public bool HasSufficientSavings(Person p, int amount)
        {
            Console.WriteLine("Check bank for " + p.Name);

            return (amount < 10000) ? false : true;
        }
    }
}
