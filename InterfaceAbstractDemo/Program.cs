using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrate;
using InterfaceAbstractDemo.Entities;
using System;


namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //customer NationalityID sini kendi bilgilerinizi doğru şekilde yazarak çalıştırabilirsiniz ...
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { FirstName = "Rümeysa", lastName = "Yük", NationalityId = 23200433928, Id = 1, DataOfBirth = new DateTime(1997, 11, 23) });
            Console.ReadLine();
        }
    }
}
