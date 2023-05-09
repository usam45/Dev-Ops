using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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

        IWebDriver driver = new ChromeDriver("D:\\softwares\\chromedriver_win32\\chromedriver.exe");
        driver.Url = "https://usama-arshad-first-web-app.azurewebsites.net/";
        IWebElement emailField = driver.FindElement(By.Id("email"));
        IWebElement passwordField = driver.FindElement(By.Id("password"));

        emailField.SendKeys("admin@admin.com");
        passwordField.SendKeys("admin");

        // Submit the form
        passwordField.Submit();
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
