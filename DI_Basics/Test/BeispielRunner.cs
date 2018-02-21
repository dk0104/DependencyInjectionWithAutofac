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
            cut.ExecuteConstructorExample();
        }

        [Test]
        public void RegisterInstanceExampleExecution()
        {
            var cut = new ChoiseOfConstructorExample();
            cut.ExecuteInstanceUnitTestExample();
        }
        
        [Test]
        public void LambdaExpExampleExecution()
        {
            var cut = new ChoiseOfConstructorExample();
            cut.LambdaExpressionTestExample();
        }

        [Test]
        public void GenericsExampleExecution()
        {
            var cut = new ChoiseOfConstructorExample();
            cut.GenericsExample();
        }
    }
}