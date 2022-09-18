﻿using Meadow.Units;

namespace Meadow
{
    /// <summary>
    /// Provides an abstraction for OS services such as configuration so that
    /// Meadow can operate on different OS's and platforms.
    /// </summary>
    public partial interface IPlatformOS : IPowerController
    {
        void Initialize();

        Temperature GetCpuTemperature();

        public INtpClient NtpClient { get; }
    }
}
