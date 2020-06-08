using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria;
using R5T.Costobocia;
using R5T.Dacia;


namespace R5T.Alamania.Bulgaria
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="RivetOrganizationDirectoryPathProvider"/> implementation of <see cref="IRivetOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRivetOrganizationDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IDropboxDirectoryPathProvider> dropboxDirectoryPathProviderAction,
            IServiceAction<IOrganizationStringlyTypedPathOperator> organizationStringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IRivetOrganizationDirectoryPathProvider, RivetOrganizationDirectoryPathProvider>()
                .RunServiceAction(dropboxDirectoryPathProviderAction)
                .RunServiceAction(organizationStringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RivetOrganizationDirectoryPathProvider"/> implementation of <see cref="IRivetOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRivetOrganizationDirectoryPathProvider> AddRivetOrganizationDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IDropboxDirectoryPathProvider> dropboxDirectoryPathProviderAction,
            IServiceAction<IOrganizationStringlyTypedPathOperator> organizationStringlyTypedPathOperatorAction)
        {
            var serviceAction = new ServiceAction<IRivetOrganizationDirectoryPathProvider>(() => services.AddRivetOrganizationDirectoryPathProvider(
                dropboxDirectoryPathProviderAction,
                organizationStringlyTypedPathOperatorAction));
            return serviceAction;
        }
    }
}
