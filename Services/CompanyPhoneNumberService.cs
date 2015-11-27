using MrCMS.Helpers;
using MrCMS.Web.Apps.Companies.Entities;
using NHibernate;

namespace MrCMS.Web.Apps.Companies.Services
{
    public class CompanyPhoneNumberService : ICompanyPhoneNumberService
    {
        private readonly ISession _session;

        public CompanyPhoneNumberService(ISession session)
        {
            _session = session;
        }

        public void Add(CompanyPhoneNumber phoneNumber)
        {
            phoneNumber.Company.PhoneNumbers.Add(phoneNumber);//required to bust page cache
            _session.Transact(session => session.Save(phoneNumber));
        }

        public void Update(CompanyPhoneNumber phoneNumber)
        {
            _session.Transact(session => session.Update(phoneNumber));
        }

        public void Delete(CompanyPhoneNumber phoneNumber)
        {
            phoneNumber.Company.PhoneNumbers.Remove(phoneNumber);//required to bust page cache
            _session.Transact(session => session.Delete(phoneNumber));
        }
    }
}