using System.Web.Mvc;
using MrCMS.Web.Apps.Companies.Models;
using MrCMS.Website.Binders;
using Ninject;

namespace MrCMS.Web.Apps.Companies.ModelBinders
{
    public class CompanyListModelBinder : MrCMSDefaultModelBinder
    {
        public CompanyListModelBinder(IKernel kernel)
            : base(kernel)
        {
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            int page;
            int.TryParse(GetValueFromContext(controllerContext, "page"), out page);
           
            return new CompanySearchModel
                       {
                           Page = page
                       };
        }
    }
}