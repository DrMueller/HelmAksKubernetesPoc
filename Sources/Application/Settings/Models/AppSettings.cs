namespace WebApplication1.Settings.Models
{
    public class AppSettings
    {
        public const string SectionKey = "AppSettings";

        public string AppVersion { get; set; }

        public string Environment { get; set; }

        public string AppBasePath { get; set; }
    }
}