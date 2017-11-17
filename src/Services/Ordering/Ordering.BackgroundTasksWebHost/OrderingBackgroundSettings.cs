﻿namespace Ordering.BackgroundTasksWebHost
{
    public class OrderingBackgroundSettings
    {
        public string ConnectionString { get; set; }

        public string EventBusConnection { get; set; }

        public int GracePeriodTime { get; set; }

        public int CheckUpdateTime { get; set; }
    }
}
