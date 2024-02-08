using HTMXTest.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTMXTest.UI.Pages;

[ResponseCache(Duration = 1 /* second */)]
public class ServerEvents : PageModel
{
    public void OnGet()
    {
    }

    public ContentResult OnGetRandom()
    {
        return Content($"<span>{Number.Value}</span>", "text/html");
    }
}