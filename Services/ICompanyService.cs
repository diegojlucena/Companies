using MrCMS.Paging;
using MrCMS.Web.Apps.Companies.Models;
using MrCMS.Web.Apps.Companies.Pages;

namespace MrCMS.Web.Apps.Companies.Services
{
    public interface ICompanyService
    {
        IPagedList<Company> GetCompanies(CompanyList page, CompanySearchModel model);
       

    }
}
