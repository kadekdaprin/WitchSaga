namespace WitchSaga
{
    public class Person
    {
        public Person(int ageOfDeath, int yearOfDeath)
        {
            AgeOfDeath = ageOfDeath;
            YearOfDeath = yearOfDeath;
        }

        public int AgeOfDeath { get; set; }

        public int YearOfDeath { get; set; }

        public int DateOfBirth
        {
            get => YearOfDeath - AgeOfDeath;
        }

        public bool IsContainsNegativeNumber()
        {
            return AgeOfDeath < 0 || YearOfDeath < 0;
        }
    }
}
