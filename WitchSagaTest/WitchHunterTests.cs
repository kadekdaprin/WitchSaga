using WitchSaga;

namespace WitchSagaTest
{
    public class WitchHunterTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(4, 7)]
        [InlineData(5, 12)]
        public void GetTotalVillagerKilledByYear_WhenInputValid_ReturnsCorrectResult(int input, int expectedResult)
        {
            var witchHunter = new WitchHunter();

            var result = witchHunter.GetTotalVillagerKilledByYear(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        public void GetTotalVillagerKilledByYear_WhenInputIsNegativeOrZero_ReturnsZero(int input, int expectedResult)
        {
            var witchHunter = new WitchHunter();

            var result = witchHunter.GetTotalVillagerKilledByYear(input);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAverageVillagerKilled_WhenInputValid_ReturnsCorrectResult()
        {
            var witchHunter = new WitchHunter();

            var persons = new List<Person>
            {
                new Person(10, 12),
                new Person(13, 17)
            };

            var result = witchHunter.GetAverageVillagerKilled(persons);
            Assert.Equal(4.5, result);
        }

        [Fact]
        public void GetAverageVillagerKilled_WhenInputContainsNegativeNumber_ReturnMinusOne()
        {
            var witchHunter = new WitchHunter();

            var persons = new List<Person>
            {
                new Person(-1, 12),
                new Person(-1, 17)
            };

            var result = witchHunter.GetAverageVillagerKilled(persons);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void GetAverageVillagerKilled_WhenIfDateOfBirthIsNegative_ReturnMinusOne()
        {
            var witchHunter = new WitchHunter();

            var persons = new List<Person>
            {
                new Person(12, 10),
                new Person(17, 13)
            };

            var result = witchHunter.GetAverageVillagerKilled(persons);
            Assert.Equal(-1, result);
        }
    }
}
