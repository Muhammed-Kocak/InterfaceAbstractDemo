using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            return TaskAsync(customer).Result;
        }
        static async Task<bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year));

            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}
