namespace WitchSaga
{
    public class WitchHunter
    {
        public WitchHunter()
        {
        }

        public double GetAverageVillagerKilled(List<Person> persons)
        {
            var sumTotalKilled = 0;

            foreach (var person in persons)
            {
                if (person.IsContainsNegativeNumber() || person.DateOfBirth < 0)
                {
                    return -1;
                }

                sumTotalKilled += GetTotalVillagerKilledByYear(person.DateOfBirth);
            }

            var result = (double)sumTotalKilled / persons.Count;

            return result;
        }

        public int GetTotalVillagerKilledByYear(int year)
        {
            if (year <= 0)
            {
                return 0;
            }

            var totalKilled = 0;
            var killedSequences = new List<int>();

            for (int i = 0; i < year; i++)
            {
                if(i < 2)
                {
                    killedSequences.Add(1);
                    totalKilled += 1;
                    continue;
                }

                var nextKilled = killedSequences[i - 1] + killedSequences[i - 2];
                killedSequences.Add(nextKilled);

                totalKilled += nextKilled;
            }

            return totalKilled;
        }
    }
}
