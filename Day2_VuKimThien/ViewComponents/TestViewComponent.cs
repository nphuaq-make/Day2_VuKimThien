
using Microsoft.AspNetCore.Mvc;

public class TestViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return Content("Xin chào!");
    }
}
