using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    interface ICustomerService : IEntity
    {
        void Save(Customer customer);
    }
}
