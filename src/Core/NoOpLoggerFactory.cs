using System;

namespace Chimp.Logging
{
    /// <summary>
    /// No-op logger factory implementation.
    /// </summary>
    public sealed class NoOpLoggerFactory : ILoggerFactory
    {
        #region Singleton

        /// <summary>
        /// No-op logger instance.
        /// </summary>
        public static readonly NoOpLoggerFactory Instance = new NoOpLoggerFactory();

        private NoOpLoggerFactory()
        {
        }

        #endregion

        #region ILoggerFactory Members

        ILogger ILoggerFactory.CreateLogger(string name)
        {
            return NoOpLogger.Instance;
        }

        ILogger ILoggerFactory.CreateLogger(Type type)
        {
            return NoOpLogger.Instance;
        }

        ILogger ILoggerFactory.CreateLogger<T>()
        {
            return NoOpLogger.Instance;
        }

        #endregion
    }
}
