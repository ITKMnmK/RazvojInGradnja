using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeriDockerCI.Pages
{
    public class IndexModel : PageModel
    {
        public string WelcomeMessage { get; private set; } = string.Empty;

        public void OnGet()
        {
            WelcomeMessage = "Welcome to RazvojInGradnja!";
        }
    }
}
