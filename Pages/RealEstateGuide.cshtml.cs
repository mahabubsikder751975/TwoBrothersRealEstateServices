using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TwoBrothersRealEstateServices.Pages;

public class RealEstateGuideModel : PageModel
{
    private readonly ILogger<RealEstateGuideModel> _logger;

    public RealEstateGuideModel(ILogger<RealEstateGuideModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

