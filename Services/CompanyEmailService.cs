using MrCMS.Helpers;
using MrCMS.Web.Apps.Companies.Entities;
using NHibernate;

namespace MrCMS.Web.Apps.Companies.Services
{
    public class CompanyEmailService : ICompanyEmailService
    {
        private readonly ISession _session;

        public CompanyEmailService(ISession session)
        {
            _session = session;
        }

        public void Add(CompanyEmail email)
        {
            email.Company.Emails.Add(email);//required to bust page cache
            _session.Transact(session => session.Save(email));
        }

        public void Update(CompanyEmail email)
        {
            _session.Transact(session => session.Update(email));
        }

        public void Delete(CompanyEmail email)
        {
            email.Company.Emails.Remove(email);//required to bust page cache
            _session.Transact(session => session.Delete(email));
        }
    }
}