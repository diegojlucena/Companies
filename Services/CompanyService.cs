using System;
using System.Collections.Generic;
using System.Linq;
using MrCMS.Entities.Documents;
using MrCMS.Helpers;
using MrCMS.Paging;
using MrCMS.Web.Apps.Companies.Models;
using MrCMS.Web.Apps.Companies.Pages;
using NHibernate;


namespace MrCMS.Web.Apps.Companies.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ISession _session;

        public CompanyService(ISession session)
        {
            _session = session;
        }

        public IPagedList<Company> GetCompanies(CompanyList page, CompanySearchModel model)
        {
            var query = _session.QueryOver<Company>()
                                .Where(a => a.Parent == page);

            //if (!String.IsNullOrEmpty(model.Category))
            //{
            //    Tag tagAlias = null;
            //    query = query.JoinAlias(article => article.Tags, () => tagAlias).Where(() => tagAlias.Name.IsInsensitiveLike(model.Category, MatchMode.Exact));
            //}

            //if (model.Month.HasValue)
            //{
            //    query =
            //        query.Where(
            //            article => article.PublishOn != null && article.PublishOn.Value.MonthPart() == model.Month);
            //}
            //if (model.Year.HasValue)
            //{
            //    query =
            //        query.Where(
            //            article => article.PublishOn != null && article.PublishOn.Value.YearPart() == model.Year);
            //}

            return query.OrderBy(x => x.Name).Asc.ThenBy(x => x.PublishOn).Desc.Paged(model.Page, page.PageSize);
        }

        
    }
}