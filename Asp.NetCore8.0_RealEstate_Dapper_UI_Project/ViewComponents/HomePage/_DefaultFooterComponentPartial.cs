﻿using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.ViewComponents.HomePage
{
    public class _DefaultFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
