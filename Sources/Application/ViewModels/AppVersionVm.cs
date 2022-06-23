namespace WebApplication1.ViewModels
{
    public class AppVersionVm
    {
        public string Version { get; }
        public string Environment { get; }

        public AppVersionVm(string version, string environment)
        {
            Version = version;
            Environment = environment;
        }

    }
}
