using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = (new DateTime(1997,6,27)), FirstName = "Muhammed", 
                LastName = "KOÇAK", NationalityId = "37777344754"}); //Yanlış bilgi gönderdiğim için Exceptiona gidecek !!
            Console.ReadLine();
        }
    }
}
