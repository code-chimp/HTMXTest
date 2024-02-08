using Htmx;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTMXTest.UI.Pages;

public class Tabs : PageModel
{
    public IEnumerable<string> Items { get; }
        = new[] { "First", "Second", "Third" };

    [BindProperty(Name = "tab", SupportsGet = true)]
    public string? Tab { get; set; }

    public bool IsSelected(string name)
    {
        return name.Equals(Tab?.Trim(), StringComparison.OrdinalIgnoreCase);
    }

    public string? IsSelectedCss(string tab, string? cssClass)
    {
        return IsSelected(tab) ? cssClass : null;
    }

    public IActionResult OnGet()
    {
        Tab = Items.Any(IsSelected) ? Tab : Items.First();

        return Request.IsHtmx()
            ? Partial("_Tabs", this)
            : Page();
    }
}