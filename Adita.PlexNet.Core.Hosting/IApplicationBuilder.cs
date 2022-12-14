using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adita.PlexNet.Core.Hosting
{
    /// <summary>
    /// Provides a mechanism for building application.
    /// </summary>
    public interface IApplicationBuilder<TApp> where TApp : class
    {
        #region Properties
        /// <summary>
        /// Gets an <see cref="IServiceCollection"/> that used for building the application.
        /// </summary>
        IServiceCollection Services { get; }
        /// <summary>
        /// Gets a <see cref="Configuration"/> that used for building the application.
        /// </summary>
        IConfiguration Configuration { get; }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Sets up application configuration using specified <paramref name="configureAction"/>, This can be called multiple times and the results will be replaced.
        /// </summary>
        /// <param name="configureAction">An <see cref="Action{T}"/> of <see cref="IConfigurationBuilder"/> to sets up the application configuration
        /// that will be used to construct the application.</param>
        /// <returns>A current builder instance.</returns>
        IApplicationBuilder<TApp> ConfigureAppConfiguration(Action<IConfigurationBuilder> configureAction);
        /// <summary>
        /// Adds services to the container. This can be called multiple times and the results will be additive.
        /// </summary>
        /// <param name="configureAction">An <see cref="Action{T}"/> of <see cref="IServiceCollection"/> to add services
        /// that will be used to construct the application.</param>
        /// <returns>A current builder instance.</returns>
        IApplicationBuilder<TApp> ConfigureServices(Action<IServiceCollection> configureAction);
        /// <summary>
        /// Builds and returns the application.
        /// </summary>
        /// <returns>An application.</returns>
        TApp Build();
        #endregion Methods
    }
}
