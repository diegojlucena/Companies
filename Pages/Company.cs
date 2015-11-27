using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MrCMS.Web.Apps.Companies.Entities;
using MrCMS.Web.Apps.Core.Pages;

namespace MrCMS.Web.Apps.Companies.Pages
{
    public class Company : TextPage
    {
        [DisplayName("ID Number")]
        public virtual  string IdNumber { get; set; }

        [Url]
        [DataType(DataType.Url)]
        public virtual string WebSite { get; set; }

        [DisplayName("Focus Of")]
        public virtual string FocusOf { get; set; }

        public virtual IList<CompanyAddress> Addresses { get; set; }
        public virtual IList<CompanyPhoneNumber> PhoneNumbers { get; set; }
        public virtual IList<CompanyEmail> Emails { get; set; }


    }
}