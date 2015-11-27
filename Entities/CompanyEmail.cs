using System.ComponentModel.DataAnnotations;
using MrCMS.Entities;
using MrCMS.Web.Apps.Companies.Pages;

namespace MrCMS.Web.Apps.Companies.Entities
{
    public class CompanyEmail:SiteEntity
    {
        public virtual  string Kind { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public virtual string EmailAddress { get; set; }

        public virtual Company Company { get; set; }

    }
}