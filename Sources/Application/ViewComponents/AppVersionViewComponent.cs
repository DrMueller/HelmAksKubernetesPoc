using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Settings.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.ViewComponents
{
    public class AppVersionViewComponent : ViewComponent
    {
        private readonly IAppSettingsProvider _appSettingsProvider;

        public AppVersionViewComponent(IAppSettingsProvider appSettingsProvider)
        {
            _appSettingsProvider = appSettingsProvider;
        }

        public IViewComponentResult Invoke()
        {
            var vm = new AppVersionVm(
                _appSettingsProvider.Settings.AppVersion,
                _appSettingsProvider.Settings.Environment);

            return View(vm);
        }
    }
}
