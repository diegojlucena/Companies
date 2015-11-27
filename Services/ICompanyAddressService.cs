using MrCMS.Web.Apps.Companies.Entities;

namespace MrCMS.Web.Apps.Companies.Services
{
    public interface ICompanyAddressService
    {
        void Add(CompanyAddress address);
        void Update(CompanyAddress address);
        void Delete(CompanyAddress address);
    }
}