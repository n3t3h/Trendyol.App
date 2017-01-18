﻿using System;
using Common.Logging;
using Common.Logging.Configuration;
using Common.Logging.NLog;

namespace Trendyol.App.NLog
{
    public static class TrendyolAppBuilderExtensions
    {
        public static TrendyolAppBuilder UseNLog(this TrendyolAppBuilder builder)
        {
            return builder;
        }

        private static void BuilderOnBeforeBuildEvent(TrendyolAppBuilder builder, InMemoryDataStore dataStore)
        {
            NameValueCollection properties = new NameValueCollection
            {
                ["configType"] = "FILE",
                ["configFile"] = "~/NLog.config"
            };

            LogManager.Adapter = new NLogLoggerFactoryAdapter(properties);
        }
    }
}
