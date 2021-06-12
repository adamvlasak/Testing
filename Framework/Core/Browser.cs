namespace Framework.Core
{
    public enum Browser
    {
        /// <summary>
        /// Remote Chrome browser connected to local docker based selenium hub
        /// </summary>
        RemoteChrome,

        /// <summary>
        /// Local Chrome browser installed on PC
        /// </summary>
        ChromeDriver,

        /// <summary>
        /// Remote Firefox browser connected to local docker based selenium hub
        /// </summary>
        RemoteFirefox,

        /// <summary>
        /// Local Firefox browser installed on PC
        /// </summary>
        FirefoxDriver,

        /// <summary>
        /// Local Edge browser installed on PC
        /// </summary>
        EdgeDriver
    }
}
