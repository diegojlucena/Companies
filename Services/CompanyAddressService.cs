using MrCMS.Helpers;
using MrCMS.Web.Apps.Companies.Entities;
using NHibernate;

namespace MrCMS.Web.Apps.Companies.Services
{
    public class CompanyAddressService : ICompanyAddressService
    {
        private readonly ISession _session;

        public CompanyAddressService(ISession session)
        {
            _session = session;
        }

        public void Add(CompanyAddress address)
        {
            address.Company.Addresses.Add(address);//required to bust page cache
            _session.Transact(session => session.Save(address));
        }

        public void Update(CompanyAddress address)
        {
            _session.Transact(session => session.Update(address));
        }

        public void Delete(CompanyAddress address)
        {
            address.Company.Addresses.Remove(address);////required to bust page cache
            _session.Transact(session => session.Delete(address));
        }
    }
}