using MrCMS.Web.Apps.Companies.Entities;

namespace MrCMS.Web.Apps.Companies.Services
{
    public interface ICompanyEmailService
    {
        void Add(CompanyEmail email);
        void Update(CompanyEmail email);
        void Delete(CompanyEmail email);
    }
}