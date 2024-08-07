﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text;

namespace TwoBrothersRealEstateServices.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string FirstName { get; set; }
    [BindProperty]
    public string LastName { get; set; }

    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Phone { get; set; }
    [BindProperty]
    public string Query { get; set; }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
        {
            string customerInfo = $"First Name: {FirstName}\nLast Name: {LastName}\nEmail ID: {Email}\nPhone Number: {Phone}\nMessage: {Query}\n\n";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "customer_info.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                writer.WriteLine(customerInfo);
            }

            return RedirectToPage("Success");
        }
}
