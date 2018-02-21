using System;
using Autofac;

namespace DI_Basics
{
    public interface IDeviceCompinent
    {
        void ExecMainFunction();
    }

    class Fax:IDeviceCompinent
    {
        public void ExecMainFunction()
        {
            Console.WriteLine($"Fax in Farbe drücken {hostPrinter.Color}");
            if (telNumber!=0)
            {
                Console.WriteLine($"sende fax an +{telNumber}");
            }
        }

        public void SetNumber(int number)
        {
            telNumber = number;
        }

        public Printer hostPrinter { get; set; }
        private int telNumber;
    }

    class Printer:IDeviceCompinent
    {
        public void ExecMainFunction()
        {
            Console.WriteLine($"Print with color {Color}");
        }

        public bool Color { get; set; }
    }

    class Scanner:IDeviceCompinent
    {
        public Scanner(string resolution)
        {
            this.resolution = resolution;
        }
        public void ExecMainFunction()
        {
            Console.WriteLine($"Scan with resolution {resolution}");
        }

        public string resolution;
    }
    

    class MFC
    {
        public MFC(Printer printer)
        {
            this.printer = printer;
            Console.WriteLine("Nur Printer");

        }

        public MFC(Printer printer, Scanner scaner)
        {
            this.printer = printer;
            this.scaner = scaner;

        }

        public MFC(Printer printer, Scanner scaner,Fax fax)
        {
            this.printer = printer;
            this.scaner = scaner;
            this.fax = fax;

        }

        public void Run()
        {
            printer?.ExecMainFunction();
            scaner?.ExecMainFunction();
            fax?.ExecMainFunction();
        }


        private Printer printer;
        private Scanner scaner;
        private Fax fax;
    }

    public class PropertiesAndLifeTimeExample
    {
        public void ExecNamedParameterExample()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Printer>();
            builder.RegisterType<Scanner>().WithParameter("resolution","720p");
            builder.RegisterType<MFC>();
            var container = builder.Build();
            var mfc = container.Resolve<MFC>();
            mfc.Run();
        }

        public void ExeTypedParameterExample()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Printer>();
            builder.RegisterType<Scanner>().WithParameter(new TypedParameter(typeof(string), "720p"));
            builder.RegisterType<MFC>();
            var container = builder.Build();
            var mfc = container.Resolve<MFC>();
            mfc.Run();
        }

        public void ExecNamedPropertiesExample()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Printer>().WithProperty("Color",true);
            builder.RegisterType<Scanner>().WithParameter(new TypedParameter(typeof(string), "720p"));
            builder.RegisterType<MFC>();
            var container = builder.Build();
            var mfc = container.Resolve<MFC>();
            mfc.Run();
        } 

        public void ExecAutowiredPropertiesExample()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Printer>().WithProperty("Color",true);
            builder.RegisterType<Scanner>().WithParameter(new TypedParameter(typeof(string), "720p"));
            builder.RegisterType<Fax>().PropertiesAutowired();
            builder.RegisterType<MFC>();
            var container = builder.Build();
            var mfc = container.Resolve<MFC>();
            mfc.Run();
        } 

        public void ExecMethodInjectionExample()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Printer>().WithProperty("Color",true);
            builder.RegisterType<Scanner>().WithParameter(new TypedParameter(typeof(string), "720p"));
            builder.Register(c =>
            {
                var fax = new Fax();
                fax.hostPrinter = c.Resolve<Printer>();
                fax.SetNumber(491800088);
                return fax;
            });
            builder.RegisterType<MFC>();
            var container = builder.Build();
            var mfc = container.Resolve<MFC>();
            mfc.Run();
        } 
        
    }
}