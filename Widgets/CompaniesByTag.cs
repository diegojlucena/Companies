using System.ComponentModel;
using MrCMS.Entities.Documents;
using MrCMS.Entities.Widget;
using MrCMS.Web.Apps.Companies.Pages;
using MrCMS.Website;

namespace MrCMS.Web.Apps.Companies.Widgets
{
    [WidgetOutputCacheable(PerPage = true)]
    public class CompaniesByTag : Widget
    {
        public virtual CompanyList CompanList { get; set; }

        [DisplayName("Show Name As Title")]
        public virtual bool ShowNameAsTitle { get; set; }

        public virtual Tag Tag { get; set; }
    }
}