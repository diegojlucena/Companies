using System.Collections.Generic;
using MrCMS.Web.Apps.Companies.Pages;

namespace MrCMS.Web.Apps.Companies.Models
{
    public class CompaniesByTagViewModel
    {
        public IList<Company> Companies { get; set; }
        public string Title { get; set; }
    }
}