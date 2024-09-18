using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class LayoutEstateAgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
