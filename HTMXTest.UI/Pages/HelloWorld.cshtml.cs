using Htmx;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTMXTest.UI.Pages;

public class HelloWorld : PageModel
{
    public IActionResult OnGet()
    {
        return Request.IsHtmx()
            // TODO: <span>Hello, World!</span>
            ? Content("<span>Hello, World!</span>", "text/html")
            : Page();
    }
}