using MrCMS.Entities.Documents;
using MrCMS.Services.Widgets;
using MrCMS.Web.Apps.Articles.Models;
using MrCMS.Web.Apps.Articles.Pages;
using MrCMS.Web.Apps.Articles.Widgets;
using MrCMS.Web.Apps.Companies.Models;
using MrCMS.Web.Apps.Companies.Pages;
using MrCMS.Web.Apps.Companies.Widgets;
using MrCMS.Website;
using NHibernate;
using NHibernate.Criterion;

namespace MrCMS.Web.Apps.Companies.Services.Widgets
{
    public class GetCompaniesByTagModel : GetWidgetModelBase<CompaniesByTag>
    {
        private readonly ISession _session;

        public GetCompaniesByTagModel(ISession session)
        {
            _session = session;
        }

        public override object GetModel(CompaniesByTag widget)
        {
            if (widget.CompanList == null)
                return null;

            var query = _session.QueryOver<Company>()
                .Where(
                    company =>
                        company.Parent.Id == widget.CompanList.Id && company.PublishOn != null &&
                        company.PublishOn <= CurrentRequestData.Now);

            if (widget.Tag != null)
            {
                Tag tagAlias = null;
                query = query.JoinAlias(company => company.Tags, () => tagAlias).Where(() => tagAlias.Name.IsInsensitiveLike(widget.Tag.Name, MatchMode.Exact));
            }

            return new CompaniesByTagViewModel
            {
                Companies = 
                    query.OrderBy(x => x.Name).Asc
                    .Cacheable()
                    .List(),
                Title = widget.Name
            };
        }
    }
}