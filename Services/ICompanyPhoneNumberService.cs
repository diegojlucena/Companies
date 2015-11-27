using MrCMS.Web.Apps.Companies.Entities;

namespace MrCMS.Web.Apps.Companies.Services
{
    public interface ICompanyPhoneNumberService
    {
        void Add(CompanyPhoneNumber phoneNumber);
        void Update(CompanyPhoneNumber phoneNumber);
        void Delete(CompanyPhoneNumber phoneNumber);
    }
}