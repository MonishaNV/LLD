using System;

namespace AbstactFactory // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the laptop you want, windows or mac");
            string? need = Console.ReadLine();

            IFactory factory = LaptopFactory.CreateFactory(need);

            factory.CreateLaptop();
            factory.CreateDesktop();

        }
    }
    class LaptopFactory
    {
        static public IFactory CreateFactory(string? need)
        {
            IFactory factory = new AppleFactory();
            if (need == "mac") factory = new AppleFactory();
            else if (need == "windows") factory = new WindowsFactory();
            return factory;
        }
    }
    interface IFactory
    {
        public void CreateLaptop();
        public void CreateDesktop();
    }

    class WindowsFactory : IFactory
    {
        void IFactory.CreateDesktop()
        {
            Console.WriteLine("Created windows desktop");
        }

        void IFactory.CreateLaptop()
        {
            Console.WriteLine("Created windows laptop");
        }
    }
    class AppleFactory : IFactory
    {
        void IFactory.CreateDesktop()
        {
            Console.WriteLine("Created mac desktop");
        }

        void IFactory.CreateLaptop()
        {
            Console.WriteLine("Created macbook");
        }
    }
}