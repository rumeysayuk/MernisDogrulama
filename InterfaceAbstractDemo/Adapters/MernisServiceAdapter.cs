using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync( new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody( customer.NationalityId, customer.FirstName.ToUpper(), customer.lastName.ToUpper(), customer.DataOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
