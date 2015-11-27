using System.Web.Mvc;
using MrCMS.Web.Apps.Companies.ModelBinders;
using MrCMS.Web.Apps.Companies.Models;
using MrCMS.Web.Apps.Companies.Pages;
using MrCMS.Web.Apps.Companies.Services;
using MrCMS.Website.Binders;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.Companies.Controllers
{
    public class CompanyController : MrCMSAppUIController<CompaniesApp>
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public ActionResult Show(CompanyList page, [IoCModelBinder(typeof(CompanyListModelBinder))]CompanySearchModel model)
        {
            ViewData["paged-companies"] = _companyService.GetCompanies(page, model);
           // ViewData["article-search-model"] = model;
            return View(page);
        }
    }
}