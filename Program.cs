using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            // Register the CompositionRoot type with the container
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());

            // Resolve an object of type ICompositionRoot (ask the container for an instance)
            // This is analogous to calling new() in a non-IoC application


        }
    }
}
