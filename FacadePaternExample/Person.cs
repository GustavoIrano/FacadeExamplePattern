namespace FacadePaternExample
{
    public class Person
    {
        private string _name;

        public Person(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
