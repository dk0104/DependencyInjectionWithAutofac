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

        [Test]
        public void NamedParameterExampleExecution()
        {
            var cut = new PropertiesAndLifeTimeExample();
            cut.ExecNamedParameterExample();
        }

        [Test]
        public void TypedParameterExampleExecution()
        {
            var cut = new PropertiesAndLifeTimeExample();
            cut.ExeTypedParameterExample();
        }

        [Test]
        public void NamedPropertiesExampleExecution()
        {
            var cut = new PropertiesAndLifeTimeExample();
            cut.ExecNamedPropertiesExample();
        }

        [Test]
        public void AutowiredExampleExecution()
        {
            var cut = new PropertiesAndLifeTimeExample();
            cut.ExecAutowiredPropertiesExample();
        }

        [Test]
        public void MethodInjExampleExecution()
        {
            var cut = new PropertiesAndLifeTimeExample();
            cut.ExecMethodInjectionExample();
        }
    }
}