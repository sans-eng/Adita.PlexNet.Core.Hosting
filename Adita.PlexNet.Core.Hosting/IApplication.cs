using Microsoft.Extensions.Configuration;

namespace Adita.PlexNet.Core.Hosting
{
    /// <summary>
    /// Provides an abstraction for an application.
    /// </summary>
    public interface IApplication
    {
        #region Properties
        /// <summary>
        /// Gets a <see cref="ServiceProvider"/> of current application.
        /// </summary>
        IServiceProvider ServiceProvider { get; }
        /// <summary>
        /// Gets an <see cref="IConfiguration"/> of current application.
        /// </summary>
        IConfiguration Configuration { get; }
        #endregion Properties

        #region methods
        /// <summary>
        /// Starts the application.
        /// </summary>
        /// <returns>
        /// The <see cref="Int32"/> application exit code that is returned to the operating system when the application shuts down. By default, the exit code value is 0.
        /// </returns>
        int Run();
        /// <summary>
        /// Shuts down the application.
        /// </summary>
        void Shutdown();
        /// <summary>
        /// Shuts down an application that returns the specified <paramref name="exitCode"/> to the operating system.
        /// </summary>
        /// <param name="exitCode">An integer exit code for an application. The default exit code is 0.</param>
        void Shutdown(int exitCode);
        /// <summary>
        /// Sets a <see cref="IServiceProvider"/> to application..
        /// </summary>
        /// <param name="serviceProvider">A <see cref="IServiceProvider"/> to set.</param>
        void SetServiceProvider(IServiceProvider serviceProvider);
        /// <summary>
        /// Sets an <see cref="IConfiguration"/> to current application.
        /// </summary>
        /// <param name="configuration">An <see cref="IConfiguration"/> to set to.</param>
        void SetConfiguration(IConfiguration configuration);
        #endregion methods
    }
}
