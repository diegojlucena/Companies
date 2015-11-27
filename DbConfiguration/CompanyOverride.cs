using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace MrCMS.Web.Apps.Companies.DbConfiguration
{
    public class CompanyOverride : IAutoMappingOverride<Pages.Company>
    {
        public void Override(AutoMapping<Pages.Company> mapping)
        {
            mapping.Map(item => item.FocusOf).Length(1000);
        }
    }
}