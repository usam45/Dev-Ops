using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstAzureWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _configuration;

    public IndexModel(ILogger<IndexModel> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
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
