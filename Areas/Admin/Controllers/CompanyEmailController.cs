using System.Web.Mvc;
using MrCMS.Web.Apps.Companies.Entities;
using MrCMS.Web.Apps.Companies.Pages;
using MrCMS.Web.Apps.Companies.Services;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.Companies.Areas.Admin.Controllers
{
    public class CompanyEmailController : MrCMSAppAdminController<CompaniesApp> 
    {
        private readonly ICompanyEmailService _companyEmailService;
        public CompanyEmailController(ICompanyEmailService companyEmailService)
        {
            _companyEmailService = companyEmailService;
        }

        [HttpGet]
        public PartialViewResult Add(Company company)
        {
            return PartialView(new CompanyEmail { Company = company });
        }

        [HttpPost]
        [ActionName("Add")]
        public RedirectToRouteResult Add_POST(CompanyEmail item)
        {
            _companyEmailService.Add(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }

        [HttpGet]
        public PartialViewResult Edit(CompanyEmail item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Edit")]
        public RedirectToRouteResult Edit_POST(CompanyEmail item)
        {
            _companyEmailService.Update(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }

        [HttpGet]
        public PartialViewResult Delete(CompanyEmail item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        public RedirectToRouteResult Delete_POST(CompanyEmail item)
        {
            _companyEmailService.Delete(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }
    }
}