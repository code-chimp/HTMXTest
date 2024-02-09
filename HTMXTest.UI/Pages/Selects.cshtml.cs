using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HTMXTest.UI.Pages;

public class Selects : PageModel
{
    private readonly Dictionary<string, List<string>> cuisines =
        new()
        {
            { "Italian", ["Spaghetti", "Pizza", "Lasagna"] },
            { "Mexican", ["Tacos", "Enchiladas", "Churros"] },
            { "American", ["Burgers", "Hot dogs", "Barbeque"] }
        };

    public IList<SelectListItem> CuisineItems
    {
        get
        {
            var items = cuisines.Keys
                .Select(c => new SelectListItem(c, c))
                .ToList();

            items.Insert(0, new SelectListItem("Choose an option", "")
            {
                Disabled = true,
                Selected = true
            });

            return items;
        }
    }

    [BindProperty(SupportsGet = true)]
    public string? Cuisine { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Food { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnGetFoods()
    {
        var html = new StringBuilder();

        #region Selection logic

        if (Cuisine is { Length: > 0 } cuisine && cuisines.TryGetValue(cuisine, out var foods))
        {
            html.AppendLine("<option disabled selected>Select a food</option>");
            foreach (var food in foods)
            {
                html.AppendLine($"<option>{food}</option>");
            }
        }

        #endregion

        return Content(html.ToString(), "text/html");
    }

    public IActionResult OnGetLove()
    {
        return Content($"<span><i class=\"fa fa-heart\"></i> I love {Food}!</span>");
    }
}