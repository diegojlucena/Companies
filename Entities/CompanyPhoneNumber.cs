using System.ComponentModel;
using MrCMS.Entities;
using MrCMS.Web.Apps.Companies.Pages;

namespace MrCMS.Web.Apps.Companies.Entities
{
    public class CompanyPhoneNumber:SiteEntity
    {
        public virtual string Kind { get; set; }

        [DisplayName("Phone Number")]
        public virtual string PhoneNumber { get; set; }

        public virtual Company Company { get; set; }
    }
}