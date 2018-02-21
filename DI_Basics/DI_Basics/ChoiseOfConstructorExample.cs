using System;
using Autofac;

namespace DI_Basics
{
    public interface IEngine
    {
        void StartRunning();
    }

    public interface IBus
    {
        void SendSignals();
    }

    public class Car
    {
        public Car(IEngine engine)
        {
            Console.WriteLine("Mal sehen , ob es anspringt ");
            myEngine = engine;
        }

        public Car(IEngine engine, IBus bus)
        {
            Console.WriteLine("Neues Auto mit Bus uns Top Motor ist bereit");
            myEngine = engine;
            myBus = bus;
        }

        public void Drive()
        {
            myEngine.StartRunning();
            myBus?.SendSignals();

        }

        private IEngine myEngine;
        private IBus myBus;
    }

    class CanBus:IBus
    {
        public void SendSignals()
        {
            Console.WriteLine("ping ping ping");
        }
    }

    class TestCanBus:IBus
    {
        public void SendSignals()
        {
            Console.WriteLine("Ich bin nur ein Stub");
        }
    }

    public class SlowEngine:IEngine
    {
        public void StartRunning()
        {
            Console.WriteLine(" Tuk Tuk Tuk ");
        }
    }

    public class FastEngine:IEngine
    {
        public void StartRunning()
        {
            Console.WriteLine("RRRRRRRRRRRRRRRRRRR");
        }
    }

    public class ChoiseOfConstructorExample
    {
        public void ExecuteConstructorExample()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CanBus>().As<IBus>();
            builder.RegisterType<FastEngine>().As<IEngine>();
            //builder.RegisterType<Car>();
            builder.RegisterType<Car>().UsingConstructor(typeof(IEngine));
            var container = builder.Build();
            var car = container.Resolve<Car>();
            car.Drive();
        }

        public void ExecuteInstanceUnitTestExample()
        {
            var builder = new ContainerBuilder();

            var testCanBus = new TestCanBus();
            //builder.RegisterType<CanBus>().As<IBus>();
            builder.RegisterInstance(testCanBus).As<IBus>();
            builder.RegisterType<FastEngine>().As<IEngine>();
            //builder.RegisterType<Car>();
            builder.RegisterType<Car>();
            var container = builder.Build();
            var car = container.Resolve<Car>();
            car.Drive();
        }

        public void LambdaExpressionTestExample()
        {
            var builder = new ContainerBuilder();

            var testCanBus = new TestCanBus();
            //builder.RegisterType<CanBus>().As<IBus>();
            builder.RegisterInstance(testCanBus).As<IBus>();
            builder.RegisterType<FastEngine>().As<IEngine>();
            //builder.RegisterType<Car>();
            builder.RegisterType<Car>();
            var container = builder.Build();
            var car = container.Resolve<Car>();
            car.Drive();
        }
    }
}