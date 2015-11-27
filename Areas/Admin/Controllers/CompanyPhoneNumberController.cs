using System.Web.Mvc;
using MrCMS.Web.Apps.Companies.Entities;
using MrCMS.Web.Apps.Companies.Pages;
using MrCMS.Web.Apps.Companies.Services;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.Companies.Areas.Admin.Controllers
{
    public class CompanyPhoneNumberController : MrCMSAppAdminController<CompaniesApp> 
    {
        private readonly ICompanyPhoneNumberService _companyPhoneNumberService;
        public CompanyPhoneNumberController(ICompanyPhoneNumberService companyPhoneNumberService)
        {
            _companyPhoneNumberService = companyPhoneNumberService;
        }

        [HttpGet]
        public PartialViewResult Add(Company company)
        {
            return PartialView(new CompanyPhoneNumber { Company = company });
        }

        [HttpPost]
        [ActionName("Add")]
        public RedirectToRouteResult Add_POST(CompanyPhoneNumber item)
        {
            _companyPhoneNumberService.Add(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }

        [HttpGet]
        public PartialViewResult Edit(CompanyPhoneNumber item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Edit")]
        public RedirectToRouteResult Edit_POST(CompanyPhoneNumber item)
        {
            _companyPhoneNumberService.Update(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }

        [HttpGet]
        public PartialViewResult Delete(CompanyPhoneNumber item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        public RedirectToRouteResult Delete_POST(CompanyPhoneNumber item)
        {
            _companyPhoneNumberService.Delete(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }
    }
}