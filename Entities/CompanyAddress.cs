using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MrCMS.Entities;
using MrCMS.Web.Apps.Companies.Pages;

namespace MrCMS.Web.Apps.Companies.Entities
{
    public class CompanyAddress:SiteEntity
    {
        [DisplayName("Address 1")]
        [Required]
        public virtual string Address1 { get; set; }

        [DisplayName("Address 2")]
        public virtual string Address2 { get; set; }

        [Required]
        public virtual string City { get; set; }

        [DisplayName("State/Province")]
        public virtual string StateProvince { get; set; }

        [Required]
        public virtual string CountryCode { get; set; }

        [DisplayName("Postal Code")]
        public virtual string PostalCode { get; set; }

        public virtual Company Company { get; set; }

    }
}