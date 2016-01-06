using System.Web.Mvc;
using MrCMS.Entities.Documents;
using MrCMS.Helpers;
using MrCMS.Web.Apps.Companies.Pages;
using MrCMS.Web.Apps.Companies.Widgets;
using MrCMS.Web.Areas.Admin.Services;
using MrCMS.Website;
using NHibernate;

namespace MrCMS.Web.Apps.Companies.Areas.Admin.Services
{
    public class GetCompaniesByTagAdminViewData : BaseAssignWidgetAdminViewData<CompaniesByTag>
    {
        private readonly ISession _session;

        public GetCompaniesByTagAdminViewData(ISession session)
        {
            _session = session;
        }

        public override void AssignViewData(CompaniesByTag widget, ViewDataDictionary viewData)
        {
            viewData["companiesList"] = _session.QueryOver<CompanyList>()
                .Where(article => article.PublishOn != null && article.PublishOn <= CurrentRequestData.Now)
                .Cacheable()
                .List()
                .BuildSelectItemList(item => item.Name,
                    item => item.Id.ToString(),
                    emptyItemText: "Please select a company list");



            viewData["tags"] = _session.QueryOver<Tag>()
                .Cacheable()
                .List()
                .BuildSelectItemList(item => item.Name,
                    item => item.Id.ToString(),
                    emptyItemText: "Please select a tag");
        }
    }
}