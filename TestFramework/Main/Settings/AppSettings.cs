﻿using Microsoft.Extensions.Configuration;

namespace TestFramework.Main.Settings
{
    public class AppSettings
    {
        private static IConfiguration InitConfiguration() => new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public static string ReadSettings(string settingName) => InitConfiguration()[settingName];
    }
}
