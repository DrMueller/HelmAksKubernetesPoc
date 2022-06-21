using WebApplication1.Settings.Models;

namespace WebApplication1.Settings.Services
{
    public interface IAppSettingsProvider
    {
        AppSettings Settings { get; }
    }
}