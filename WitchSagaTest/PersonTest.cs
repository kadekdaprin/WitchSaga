using WitchSaga;

namespace WitchSagaTest
{
    public class PersonTest
    {
        [Fact]
        public void IsContainsNegativeNumber_WhenContainsNegativeNumber_ReturnsTrue()
        {
            var person = new Person(10, -1);

            var result = person.IsContainsNegativeNumber();

            Assert.True(result);
        }

        [Fact]
        public void IsContainsNegativeNumber_WhenDoesNotContainsNegativeNumber_ReturnsFalse()
        {
            var person = new Person(10, 1);

            var result = person.IsContainsNegativeNumber();

            Assert.False(result);
        }

        [Fact]
        public void GetDateOfBirth_WhenInputIsValid_ReturnsCorrectResult()
        {
            var person = new Person(10, 12);

            var result = person.DateOfBirth;

            Assert.Equal(2, result);
        }

        [Fact]
        public void GetDateOfBirth_WhenAgeOfDeathIsLessThanYearOfDeath_ReturnsNegativeResult()
        {
            var person = new Person(12, 10);

            var result = person.DateOfBirth;

            Assert.Equal(-2, result);
        }
    }
}