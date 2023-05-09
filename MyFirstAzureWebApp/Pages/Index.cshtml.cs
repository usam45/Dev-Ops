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


   
    public void  OnPost(string email, string password)
    {
        if (email != null && password != null )
        {
            if (email== "admin@admin.com" && password == "admin")
            {
                ViewData["message"] = "you have logged-In successfully";
            }
        }
    }
    
    public int add (int a, int b)
    {
        return a + b;
    }
}
