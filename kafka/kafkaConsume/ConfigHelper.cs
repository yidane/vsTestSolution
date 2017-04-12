using System;

namespace kafkaConsume
{
    public class ConfigHelper
    {
        public static string Broker
        {
            get
            {
                return ReadAppSetting("KafkaBroker");
            }
        }

        public static string Topic
        {
            get
            {
                return ReadAppSetting("KafkaTopic");
            }
        }

        /// <summary>
        /// Read AppSetting
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string ReadAppSetting(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name), "argument name cannot be null");
            var appSetting = System.Configuration.ConfigurationManager.AppSettings[name];
            if (string.IsNullOrEmpty(appSetting))
                throw new Exception($"cannot find [{name}] in AppSetting Section");

            return appSetting;
        }
    }
}
