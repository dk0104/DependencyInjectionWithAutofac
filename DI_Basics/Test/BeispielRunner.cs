using DI_Basics;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class ExampleRunner
    {
        [Test]
        public void SimpleRegistrationExecution()
        {
            var cut = new SimpleRegistration();
            cut.ExecuteExample();
        }

        [Test]
        public void ChoiseConstructorExampleExecution()
        {
            var cut = new ChoiseOfConstructorExample();
            cut.ExecuteEcample();
        }
        
    }
}