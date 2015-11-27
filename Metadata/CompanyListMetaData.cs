using System;
using System.Collections.Generic;
using MrCMS.Entities.Documents;
using MrCMS.Entities.Documents.Metadata;
using MrCMS.Web.Apps.Companies.Pages;

namespace MrCMS.Web.Apps.Companies.Metadata
{
    public class CompanyListMetaData : DocumentMetadataMap<CompanyList>
    {
        public override string WebGetController
        {
            get { return "Company"; }
        }
        public override string IconClass
        {
            get { return "fa fa-building"; }
        }
        
        public override ChildrenListType ChildrenListType
        {
            get { return ChildrenListType.WhiteList; }
        }

        public override IEnumerable<Type> ChildrenList
        {
            get { yield return typeof(Pages.Company); }
        }


        public override int MaxChildNodes
        {
            get { return 5; }
        }
    }
}

