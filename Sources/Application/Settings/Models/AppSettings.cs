namespace WebApplication1.Settings.Models
{
    public class AppSettings
    {
        public const string SectionKey = "AppSettings";

        public string ConnectionString { get; set; }

        public string AppVersion { get; set; }
    }
}