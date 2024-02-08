﻿using System.Text;
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

    // Step #1
    // TODO: Add string? parameters Cuisine and Food
    // hint: don't forget BindProperty

    public void OnGet()
    {
    }

    public IActionResult OnGetFoods()
    {
        var html = new StringBuilder();

        // Step #2
        // Todo: Generate Options for Select Element
        // hint: use the selected cuisine to get the 

        #region Selection logic

        /*
        if (Cuisine is { Length: > 0 } cuisine && cuisines.TryGetValue(cuisine, out var foods))
        {
            html.AppendLine("<option disabled selected>Select a food</option>");
            foreach (var food in foods)
            {
                html.AppendLine($"<option>{food}</option>");
            }
        }
         */

        #endregion

        return Content(html.ToString(), "text/html");
    }

    public IActionResult OnGetLove()
    {
        // Step 3
        // Todo: Return Span proclaiming your love for Food
        // hint: <span><i class=\"fa fa-heart\"></i> I love {Food}!</span>

        return Content("");
    }
}