﻿using Senparc.Ncf.Service;
using System;

namespace YQWStudio.Xncf.OrganizationUnitManager.Areas.OrganizationUnitManager.Pages
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
