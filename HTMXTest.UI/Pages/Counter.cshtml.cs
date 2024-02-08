using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTMXTest.UI.Pages;

public class Counter : PageModel
{
    private int count;

    public void OnGet()
    {
        count = 0;
    }

    public IActionResult OnPost()
    {
        // TODO: Increment the count on each request
        //       hint {count++}
        return Content("<span></span>", "text/html");
    }
}