using WitchSaga;

public class Program
{
    private static void Main(string[] args)
    {
        var isExit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome To Witch Saga App");
            Console.WriteLine();
            Console.Write("Please input number of person: ");
            var totalPerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var persons = new List<Person>();

            for (int i = 1; i <= totalPerson; i++)
            {
                Console.WriteLine("Please input data for person {0}", i);
                Console.Write("Input age of death: ");
                var ageOfDeath = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input year of death: ");
                var yearOfDeath = Convert.ToInt32(Console.ReadLine());

                persons.Add(new Person(ageOfDeath, yearOfDeath));

                Console.WriteLine();
            }

            var witchHunter = new WitchHunter();

            var totalAverageKilled = witchHunter.GetAverageVillagerKilled(persons);

            Console.WriteLine("The total average killed is: {0}", totalAverageKilled);

            Console.WriteLine();

            Console.WriteLine("Do you want to exit? (Y/N)");
            isExit = Console.ReadLine()?.ToUpper() == "Y";
        } while (!isExit);
    }

}