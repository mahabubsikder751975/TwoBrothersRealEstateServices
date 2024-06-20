using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TwoBrothersRealEstateServices.Pages;

public class OwnersSpeechModel : PageModel
{
    private readonly ILogger<OwnersSpeechModel> _logger;

    public OwnersSpeechModel(ILogger<OwnersSpeechModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

