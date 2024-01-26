using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.UILayoutsComponent
{
    public class _UILayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
