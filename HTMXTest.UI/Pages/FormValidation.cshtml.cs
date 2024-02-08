using System.ComponentModel.DataAnnotations;
using Htmx;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTMXTest.UI.Pages;

public class FormValidation : PageModel
{
    [BindProperty] [Required] public string? Name { get; init; } = string.Empty;

    [BindProperty] [Required] public int Age { get; init; }

    public async Task<IActionResult> OnPost()
    {
        // artificial delay to see loading spinner
        await Task.Delay(TimeSpan.FromSeconds(2));

        return Request.IsHtmx()
            ? Partial("_Form", this)
            : Page();
    }
}