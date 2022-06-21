using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Settings.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAppSettingsProvider _settingsProvider;
        public string AppVersion => _settingsProvider.Settings.AppVersion;

        public IndexModel(
            ILogger<IndexModel> logger,
            IAppSettingsProvider settingsProvider)
        {
            _logger = logger;
            _settingsProvider = settingsProvider;
        }

        public void OnGet()
        {
        }
    }
}