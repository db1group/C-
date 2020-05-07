using DB1Group.Greetings.Greeters;
using DB1Group.Greetings.Greeters.Impl;
using Xunit;

namespace DB1Group.Greetins.Tests.Greeters.Impl
{
    public class GreetersTests
    {
        private const string personName = "Person Name";

        [Fact]
        public void ShouldGreetInEnglish()
        {
            var expectedGreet = $"Hello, {personName}";
            IMultiLanguageGreeters greeter = new EnglishGreeter();

            var returnedGreeting = greeter.Greetings(personName);

            Assert.Equal(expectedGreet, returnedGreeting);
        }
    }
}