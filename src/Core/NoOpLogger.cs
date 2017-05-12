namespace Chimp.Logging
{
    /// <summary>
    /// No-op logger implementation.
    /// </summary>
    public sealed class NoOpLogger : ILogger
    {
        #region Singleton

        /// <summary>
        /// No-op logger instance.
        /// </summary>
        public static readonly NoOpLogger Instance = new NoOpLogger();

        private NoOpLogger()
        {
        }

        #endregion

        #region ILogger Members

        void ILogger.Log(LogLevel level, object obj)
        {
            //Do nothing
        }

        void ILogger.Log(LogLevel level, string str)
        {
            //Do nothing
        }

        void ILogger.Log(LogLevel level, string format, object[] args)
        {
            //Do nothing
        }

        #endregion
    }
}
