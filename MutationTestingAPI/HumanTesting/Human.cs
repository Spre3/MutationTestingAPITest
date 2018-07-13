namespace HumanTesting
{
    public class Human
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Human() { }

        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetFullName() => FirstName + LastName;

        public bool CanBeGivenAbilities() => Age < 25 && Age > 1;

    }
}
