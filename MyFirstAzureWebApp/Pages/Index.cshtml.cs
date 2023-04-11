using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstAzureWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var environment = _configuration["BuildEnvironment:Name"];
        ViewData["environment"] = environment;
    }
    public int add (int a, int b)
    {
        return a + b;
    }
}
