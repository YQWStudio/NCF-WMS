using Senparc.Ncf.Service;
using System;

namespace YQWStudio.Xncf.OrganizationUnit.Areas.OrganizationUnit.Pages
{
    public class Index : Senparc.Ncf.AreaBase.Admin.AdminXncfModulePageModelBase
    {
        public Index(Lazy<XncfModuleService> xncfModuleService) : base(xncfModuleService)
        {

        }

        public void OnGet()
        {
        }
    }
}
