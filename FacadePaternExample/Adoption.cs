using System;

namespace FacadePaternExample
{
    //Facade Class
    public class Adoption
    {
        private Bank _bank = new Bank();
        private Antecedents _antecedents = new Antecedents();

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool IsEligible(Person person, int amount)
        {
            Console.WriteLine("{0} have {1:C} saving to adopt\n",
              person.Name, amount);

            bool eligible = true;

            if (!_bank.HasSufficientSavings(person, amount))
            {
                eligible = false;
            }
            else if (!_antecedents.HasNoBadAntecedents(person))
            {
                eligible = false;
            }

            return eligible;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
