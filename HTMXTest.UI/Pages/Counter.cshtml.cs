using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTMXTest.UI.Pages;

public class Counter : PageModel
{
    // NOTE: This state is shared across all clients
    //       you can see by opening in multiple tabs
    private static int count;

    public void OnGet()
    {
        count = 0;
    }

    public IActionResult OnPost()
    {

        return Content($"<span>{++count}</span>", "text/html");
    }
}