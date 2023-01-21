using System;
using System.Collections.Generic;
using System.Text;

namespace WikiIntegrator
{
    public static class EnvironmentConfig
    {
        public static class System
        {
            public const String SystemName = "WikiIntegrator";
        }
        public static class Twitter
        {
            public static string ConsumerKey { get { return GetEnviromentVariable("Twitter.ConsumerKey") ?? "XXXXXXX"; } }
            public static string ConsumerKeySecret { get { return GetEnviromentVariable("Twitter.ConsumerKeySecret") ?? "XXXXXXXXX"; } }
            public static string AccessToken { get { return GetEnviromentVariable("Twitter.AccessToken") ?? "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"; } }
            public static string AccessTokenSecret { get { return GetEnviromentVariable("Twitter.AccessTokenSecret") ?? "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"; } }

        }

        private static string GetEnviromentVariable(string name)
        {
            string value = Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Machine);
            if (value == null)
                value = Environment.GetEnvironmentVariable(name);
            return value;
        }
    }
}
