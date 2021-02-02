using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _personCheckService;

        public StarbucksCustomerManager(ICustomerCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }
    }
}
