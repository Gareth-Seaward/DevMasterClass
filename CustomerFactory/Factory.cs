using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CustomerInterface;
using CustomerLibrary;
using CustomerLibrary.Models;
using CustomerLibrary.Validation;
using Microsoft.Practices.Unity;

namespace CustomerFactory
{
    //public static class Factory
    //{
    //    private static readonly Lazy<List<ICustomer>> Customers = null;

    //    static Factory()
    //    {
    //        Customers = new Lazy<List<ICustomer>>(() => LoadCustomers());
    //    }

    //    private static List<ICustomer> LoadCustomers()
    //    {
    //        return new List<ICustomer>() { new Lead(), new Customer() }; 
    //    }

    //    public static ICustomer Create(int customerType)
    //    {
    //        return Customers.Value[customerType].Clone();
    //    }
    //}

    public static class Factory<T>
    {
        private static readonly Lazy<IUnityContainer> Container = null;

        static Factory()
        {
            Container = new Lazy<IUnityContainer>(LoadContainer);
        }

        private static IUnityContainer LoadContainer()
        {
            var cont = new UnityContainer();
            cont.RegisterType<ICustomer, Lead>("Lead", new InjectionConstructor(new CustomerValidation()));
            cont.RegisterType<ICustomer, Customer>("Customer", new InjectionConstructor(new LeadValidation()));
            return cont;
        }

        public static T Create(string type)
        {
            return Container.Value.Resolve<T>(type);
        }
    }
}
