using System;
using System.Collections.Generic;
using MrCMS.Entities.Documents;
using MrCMS.Entities.Documents.Metadata;
using MrCMS.Web.Apps.Companies.Pages;

namespace MrCMS.Web.Apps.Companies.Metadata
{
    public class CompanyMetaData : DocumentMetadataMap<Company>
    {
        public override string IconClass
        {
            get { return "fa fa-building-o"; }
        }

        public override ChildrenListType ChildrenListType
        {
            get { return ChildrenListType.WhiteList; }
        }

        public override bool RequiresParent
        {
            get { return true; }
        }

        public override bool AutoBlacklist
        {
            get { return true; }
        }

        public override bool Sortable
        {
            get { return false; }
        }

        public override IEnumerable<Type> ChildrenList
        {
            get { yield break; }
        }

        public override bool RevealInNavigation
        {
            get { return false; }
        }
    }
}

