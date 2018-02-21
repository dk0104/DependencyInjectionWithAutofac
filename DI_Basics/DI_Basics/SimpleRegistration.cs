using System;
using Autofac;

namespace DI_Basics
{
    public interface IPilot
    {
        void TakeOf();
    } 

    public class Plain  
    {
        public Plain(IPilot pilot)
        {
            Console.WriteLine("Flugzeug ist bereit");
            myPilot = pilot;
        }

        public void StartFlight()
        {
            myPilot.TakeOf();
        }

        private IPilot myPilot;

    }

    public class HumanPilot : IPilot
    {
        public HumanPilot()
        {
            Console.WriteLine("Pilot Stefan ist bereit");
        }

        public void TakeOf()
        {
            Console.WriteLine("Ready for take of");
        }

        private string name;
    }

    public class DroneAI : IPilot
    {
        public DroneAI()
        {
            Console.WriteLine("Drone Alexa ist bereit");
        }

        public void TakeOf()
        {
            Console.WriteLine("Ready for take of");
        }

        private string name;
    }

    //public class BodenSteueruung : IPilot, ITower
    //{
    //    public void SendSignal()
    //    {
    //        Console.WriteLine("Ping Ping Ping ");
    //    }
    //    public void TakeOf()
    //    {
    //        Console.WriteLine("Ready for take of");
    //    }
    //}

    //public interface ITower
    //{
    //    void SendSignal();
    //}

    public class SimpleRegistration
    {

        public void ExecuteExample()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<HumanPilot>().As<IPilot>();
            // -> builder.RegisterType<DroneAI>().As<IPilot>(); .PreserveExistingDefaults
            //builder.RegisterType<HumanPilot>();
            builder.RegisterType<Plain>();
            var container = builder.Build();
            var plain = container.Resolve<Plain>();
            plain.StartFlight();

        }
    }
}