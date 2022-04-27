using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria;
using R5T.Costobocia;

using R5T.T0063;


namespace R5T.Alamania.Bulgaria
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="RivetOrganizationDirectoryPathProvider"/> implementation of <see cref="IRivetOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRivetOrganizationDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IDropboxDirectoryPathProvider> dropboxDirectoryPathProviderAction,
            IServiceAction<IOrganizationStringlyTypedPathOperator> organizationStringlyTypedPathOperatorAction)
        {
            services
                .Run(dropboxDirectoryPathProviderAction)
                .Run(organizationStringlyTypedPathOperatorAction)
                .AddSingleton<IRivetOrganizationDirectoryPathProvider, RivetOrganizationDirectoryPathProvider>()
                ;

            return services;
        }
    }
}
