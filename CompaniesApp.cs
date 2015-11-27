using MrCMS.Apps;
using Ninject;

namespace MrCMS.Web.Apps.Companies
{
    public class CompaniesApp : MrCMSApp
    {
        public override string AppName
        {
            get { return "Companies"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        protected override void RegisterServices(IKernel kernel)
        {
            
        }

        protected override void RegisterApp(MrCMSAppRegistrationContext context)
        {
        }
    }
}