using Life.Debugging;

namespace Life
{
    public class LifeConsts
    {
        public const string LocalizationSourceName = "Life";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f0d49eb348744cffa38bc109afc6f569";
    }
}
