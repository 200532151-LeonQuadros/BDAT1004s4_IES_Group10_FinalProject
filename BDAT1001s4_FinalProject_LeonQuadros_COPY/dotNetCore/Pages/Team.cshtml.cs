using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManager.Pages;

[AllowAnonymous]
public class TeamModel : PageModel
{
    private readonly ILogger<TeamModel> _logger;

    public TeamModel(ILogger<TeamModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
