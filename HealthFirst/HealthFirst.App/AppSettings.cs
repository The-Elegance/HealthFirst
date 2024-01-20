namespace HealthFirst.App
{
    public static class AppSettings
    {
        public const string APP_FOLDER_NAME = "HealthFirst";
        public static string AppPath = Environment.ExpandEnvironmentVariables("%appdata%") + "/." + APP_FOLDER_NAME;
        public const int VERSION = 0000001;
    }
}
