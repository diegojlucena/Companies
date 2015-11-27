using System.Web.Mvc;
using MrCMS.Web.Apps.Companies.Entities;
using MrCMS.Web.Apps.Companies.Pages;
using MrCMS.Web.Apps.Companies.Services;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.Companies.Areas.Admin.Controllers
{
    public class CompanyAddressController : MrCMSAppAdminController<CompaniesApp> 
    {
        private readonly ICompanyAddressService _companyAddressService;
        public CompanyAddressController(ICompanyAddressService companyAddressService)
        {
            _companyAddressService = companyAddressService;
        }

        [HttpGet]
        public PartialViewResult Add(Company company)
        {
            return PartialView(new CompanyAddress { Company = company });
        }

        [HttpPost]
        [ActionName("Add")]
        public RedirectToRouteResult Add_POST(CompanyAddress item)
        {
            _companyAddressService.Add(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }

        [HttpGet]
        public PartialViewResult Edit(CompanyAddress item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Edit")]
        public RedirectToRouteResult Edit_POST(CompanyAddress item)
        {
            _companyAddressService.Update(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }

        [HttpGet]
        public PartialViewResult Delete(CompanyAddress item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        public RedirectToRouteResult Delete_POST(CompanyAddress item)
        {
            _companyAddressService.Delete(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Company.Id });
        }
    }
}