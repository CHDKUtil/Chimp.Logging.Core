using System;

namespace Chimp.Logging
{
    /// <summary>
    /// Logger factory interface.
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// Creates a logger for a given name.
        /// </summary>
        /// <param name="name">Logger name.</param>
        /// <returns>Logger.</returns>
        ILogger CreateLogger(string name);

        /// <summary>
        /// Creates a logger for a given type.
        /// </summary>
        /// <param name="type">Logger type.</param>
        /// <returns>Logger.</returns>
        ILogger CreateLogger(Type type);

        /// <summary>
        /// Creates a logger for a given type.
        /// </summary>
        /// <typeparam name="T">Logger type.</typeparam>
        /// <returns>Logger.</returns>
        ILogger CreateLogger<T>();
    }
}
