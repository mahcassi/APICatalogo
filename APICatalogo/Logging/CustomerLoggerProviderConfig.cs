﻿namespace APICatalogo.Logging
{
    public class CustomerLoggerProviderConfig
    {

        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public int EventId { get; set; } = 0;
    }
}
