using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text;

namespace TwoBrothersRealEstateServices.Pages;

public class ContactUsModel : PageModel
{
    private readonly ILogger<ContactUsModel> _logger;

    public ContactUsModel(ILogger<ContactUsModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string FirstName { get; set; }
    [BindProperty]
    public string MiddleName { get; set; }
    [BindProperty]
    public string LastName { get; set; }
    [BindProperty]
    public string Address { get; set; }
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
            string customerInfo = $"First Name: {FirstName}\nMiddle Name: {MiddleName}\nLast Name: {LastName}\nAddress: {Address}\nEmail ID: {Email}\nPhone Number: {Phone}\nQuery/Messages: {Query}\n\n";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "customer_info.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                writer.WriteLine(customerInfo);
            }

            return RedirectToPage("Success");
        }
}

